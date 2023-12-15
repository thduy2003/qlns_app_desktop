using BLLQLNS;
using DALQLNS;
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
    public partial class frmKhenThuongKyLuat : Form
    {
        BLLKhenThuongKyLuat _ktkl;

        private DataGridViewRow r;
        BLLNhanVien _nhanvien;

        public frmKhenThuongKyLuat()
        {
            InitializeComponent();
        }

        private void frmKhenThuongKyLuat_Load(object sender, EventArgs e)
        {
            _ktkl = new BLLKhenThuongKyLuat();
            _nhanvien = new BLLNhanVien();
            loadData();
            LoadCombobox();
            cbbNhanVien.SelectedIndex = -1;
        }
        void loadData()
        {
            
            dgvKhenThuongKyLuat.DataSource = _ktkl.GetAllKhenThuongKyLuat();
        }
        void LoadCombobox()
        {
            cbbNhanVien.DataSource = _nhanvien.GetAllNhanVien();
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "MaNhanVien";
        }





        private void dgvKhenThuongKyLuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                r = dgvKhenThuongKyLuat.Rows[e.RowIndex]; // xác định được 1 hàng vừa click
              
            }
        }

        private void btnThemKTKL_Click(object sender, EventArgs e)
        {
            new frmDieuChinhKTKL().ShowDialog();
            loadData();
        }

        private void btnSuaKTKL_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn khen thưởng kỷ luật cần sửa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            new frmDieuChinhKTKL(r).ShowDialog();
            loadData();
        }

        private void btnXoaKTKL_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn khen thưởng kỷ luật cần xóa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show($"Bạn có chắc chắn xóa khen thưởng kỷ luật của: {r.Cells["TenNhanVien"].Value?.ToString()} ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _ktkl.Delete(int.Parse(r.Cells["MaKhenThuongKyLuat"].Value.ToString()));
                    MessageBox.Show("Xóa khen thưởng kỷ luật thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa khen thưởng kỷ luật thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbNhanVien.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm kiếm", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvKhenThuongKyLuat.DataSource = _ktkl.TimKiemKhenThuongKyLuat(int.Parse(cbbNhanVien.SelectedValue.ToString()));
        }
    }
}
