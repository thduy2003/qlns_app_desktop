using BLLQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_NHANSU
{
    public partial class frmChiTietLuong : Form
    {
        BLLLuong _luong;
        private string nam;
        private int thang;
        private int maLuong;
        public frmChiTietLuong(string nam, int thang, int maLuong)
        {
            this.nam = nam;
            this.thang = thang;
            this.maLuong = maLuong;
            InitializeComponent();
        }
        
        private void frmChiTietLuong_Load(object sender, EventArgs e)
        {
            _luong = new BLLLuong();
            dgvChiTietLuong.DataSource = _luong.GetChiTietLuong(nam, thang, maLuong);
            dgvChiTietLuong.Columns["ThucLanh"].DefaultCellStyle.Format = "N0";

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            var result = _luong.GetChiTietLuong(nam, thang, maLuong);
            DataTable dt = new DataTable();

            // Thêm các cột từ danh sách result
            foreach (var prop in typeof(DTOChiTietLuong).GetProperties())
            {
                dt.Columns.Add(prop.Name, prop.PropertyType);
            }

            // Thêm hai cột mới Thang và Nam
            dt.Columns.Add("Thang", typeof(int));
            dt.Columns.Add("Nam", typeof(string));

            // Thêm dữ liệu từ danh sách ChamCongChiTiet vào DataTable
            foreach (var luong in result)
            {
                var row = dt.NewRow();

                // Gán giá trị cho các cột từ danh sách result
                foreach (var prop in typeof(DTOChiTietLuong).GetProperties())
                {
                    row[prop.Name] = prop.GetValue(luong);
                }

                // Gán giá trị cho hai cột mới Thang và Nam
                row["Thang"] = thang;
                row["Nam"] = nam;

                dt.Rows.Add(row);
            }

            rpBangLuong r = new rpBangLuong();
            r.SetDataSource(dt);

            frmInBangLuong f = new frmInBangLuong();
            f.crystalReportViewer2.ReportSource = r;
            f.ShowDialog();
        }
    }
}
