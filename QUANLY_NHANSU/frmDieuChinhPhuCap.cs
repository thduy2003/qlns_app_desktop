using BLLQLNS;
using DALQLNS;
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
    public partial class frmDieuChinhPhuCap : Form
    {
        BLLPhuCap _phucap;
        BLLNhanVien _nhanvien;
        private DataGridViewRow r;
        public frmDieuChinhPhuCap()
        {
            InitializeComponent();
        }
        //khởi tạo có dòng truyền vào để lấy thông tin ra từ dòng để truyền vào form điều chỉnh
        public frmDieuChinhPhuCap(DataGridViewRow r)
        {
            this.r = r;
            InitializeComponent();
        }

        private void frmDieuChinhPhuCap_Load(object sender, EventArgs e)
        {
            _phucap = new BLLPhuCap();
            _nhanvien = new BLLNhanVien();
            LoadCombobox();
            // nếu có dòng truyền vào tức là đang sửa thông tin và ngược lại là thêm
            if (r != null)
            {
                cbbNhanVien.Text = r.Cells["TenNhanVien"].Value.ToString();
                cbbPhuCap.Text = r.Cells["TenPhuCap"].Value.ToString();
                txtNoiDung.Text = r.Cells["NoiDung"].Value != null ? r.Cells["NoiDung"].Value.ToString() : String.Empty;
                btnThem.Text = "Sửa";
            }
            else
            {
                cbbNhanVien.SelectedIndex = -1;
                cbbPhuCap.SelectedIndex = -1;
                
                btnThem.Text = "Thêm";
            }
        }
        void LoadCombobox()
        {
            cbbPhuCap.DataSource = _phucap.GetAllLoaiPhuCap();
            cbbPhuCap.DisplayMember = "TenPhuCap";
            cbbPhuCap.ValueMember = "MaLoaiPhuCap";

            cbbNhanVien.DataSource = _nhanvien.GetAllNhanVien();
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "MaNhanVien";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Chú ý", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (cbbPhuCap.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phụ cấp", "Chú ý", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
          

            if (r != null)
            {
                // Sửa thông tin
                var pc = _phucap.GetPhuCap(int.Parse(r.Cells["MaPhuCap"].Value.ToString()));
                pc.MaNhanVien = int.Parse(cbbNhanVien.SelectedValue.ToString());
                pc.MaLoaiPhuCap = int.Parse(cbbPhuCap.SelectedValue.ToString());
                pc.NoiDung = txtNoiDung.Text;

                try
                {
                    var updatedPC = _phucap.Update(pc);
                    MessageBox.Show("Cập nhật phụ cấp thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật phụ cấp thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                //Thêm thông tin
                PhuCap pc = new PhuCap();

                pc.MaNhanVien = int.Parse(cbbNhanVien.SelectedValue.ToString());
                pc.MaLoaiPhuCap = int.Parse(cbbPhuCap.SelectedValue.ToString());
                pc.NoiDung = txtNoiDung.Text;


                try
                {
                    var addedLichLam = _phucap.Add(pc);
                    MessageBox.Show("Thêm phụ cấp thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm phụ cấp thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
