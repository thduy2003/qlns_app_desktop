using BLLQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BLLQLNS.BLLBangChamCong;

namespace QUANLY_NHANSU
{
    public partial class frmBCCT : Form
    {
        public frmBCCT(int thang, string nam, int maBangChamCong)
        {
            this.thang = thang;
            this.nam = nam;
            this.maBangChamCong = maBangChamCong;
            InitializeComponent();
            
        }
        public int thang;
        public string nam;
        public int maBangChamCong;
        
        BLLBangChamCong _bcc;
        

        private void frmBCCT_Load(object sender, EventArgs e)
        {
            _bcc = new BLLBangChamCong();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _bcc.TaoBangChamCongChiTiet(maBangChamCong);

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
          
            
            var result = _bcc.TaoBangChamCongChiTiet(maBangChamCong);
            DataTable dt = new DataTable();

            // Thêm các cột từ danh sách result
            foreach (var prop in typeof(DTOBangChamCongChiTiet).GetProperties())
            {
                dt.Columns.Add(prop.Name, prop.PropertyType);
            }

            // Thêm hai cột mới Thang và Nam
            dt.Columns.Add("Thang", typeof(int));
            dt.Columns.Add("Nam", typeof(string));

            // Thêm dữ liệu từ danh sách ChamCongChiTiet vào DataTable
            foreach (var chamCong in result)
            {
                var row = dt.NewRow();

                // Gán giá trị cho các cột từ danh sách result
                foreach (var prop in typeof(DTOBangChamCongChiTiet).GetProperties())
                {
                    row[prop.Name] = prop.GetValue(chamCong);
                }

                // Gán giá trị cho hai cột mới Thang và Nam
                row["Thang"] = thang;
                row["Nam"] = nam;

                dt.Rows.Add(row);
            }

            rpBCCT r = new rpBCCT();
            r.SetDataSource(dt);
           
            frmInBangChamCong f = new frmInBangChamCong();
            f.crystalReportViewer1.ReportSource = r;
            f.ShowDialog();
        }
        private DataGridViewRow r;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                

                DateTime date = DateTime.ParseExact($"{int.Parse(nam)}/{thang}/{e.ColumnIndex - 1}", "yyyy/M/d", CultureInfo.InvariantCulture);
                string thu = _bcc.GetThuFromNgay(date);
              
                r = dataGridView1.Rows[e.RowIndex];
                new frmSuaBCCCT(int.Parse(r.Cells["MaNV"].Value.ToString()),thu,date, r.Cells["HoTen"].Value.ToString(), maBangChamCong).ShowDialog();


            }
        }
    }
}
