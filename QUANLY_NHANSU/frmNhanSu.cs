using BLLQLNS;
using DALQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_NHANSU
{
    public partial class frmNhanSu : Form
    {
        public frmNhanSu()
        {
            InitializeComponent();
        }
        BLLNhanVien _nhanvien;
        
        private DataGridViewRow r;
   
        BLLPhongBan _phongban;

        private void frmNhanSu_Load(object sender, EventArgs e)
        {
            _nhanvien = new BLLNhanVien();
            _phongban = new BLLPhongBan();  
           

            loadData();
           
            ((DataGridViewImageColumn)dgvNhanVien.Columns["HinhAnh"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            LoadComboBox();
            cbbNhanVien.SelectedIndex = -1;
            cbbPhongBan.SelectedIndex = -1;
        }
        //load data
        void loadData()
        {
            dgvNhanVien.DataSource = _nhanvien.GetAllNhanVien();

        }
        //load data cho combobox
        void LoadComboBox()
        {
            cbbNhanVien.DataSource = _nhanvien.GetAllNhanVien();
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "MaNhanVien";

            cbbPhongBan.DataSource = _phongban.GetAllPhongBan();
            cbbPhongBan.DisplayMember = "TenPhongBan";
            cbbPhongBan.ValueMember = "MaPhongBan";
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            new frmDieuChinhNhanSu().ShowDialog();
            loadData();
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                r = dgvNhanVien.Rows[e.RowIndex]; // xác định được 1 hàng vừa click
               
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            new frmDieuChinhNhanSu(r).ShowDialog();

            loadData();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show($"Bạn có chắc chắn xóa nhân viên: {r.Cells["HoTen"].Value?.ToString()} ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _nhanvien.Delete(int.Parse(r.Cells["MaNhanVien"].Value.ToString()));
                    MessageBox.Show("Xóa nhân viên thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa nhân viên thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbNhanVien.SelectedIndex < 0 && cbbPhongBan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm kiếm", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvNhanVien.DataSource = _nhanvien.TimKiemNhanVien(cbbNhanVien.SelectedIndex >= 0 ? int.Parse(cbbNhanVien.SelectedValue.ToString()) : -1, cbbPhongBan.SelectedIndex >= 0 ? int.Parse(cbbPhongBan.SelectedValue.ToString()) : -1);
        }
    }
}
