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
        ToolTip toolTip1;
        public frmKhenThuongKyLuat()
        {
            InitializeComponent();
        }

        private void frmKhenThuongKyLuat_Load(object sender, EventArgs e)
        {
            _ktkl = new BLLKhenThuongKyLuat();
            _nhanvien = new BLLNhanVien();
            toolTip1 = new ToolTip();
            loadData();
            LoadCombobox();
            cbbNhanVien.SelectedIndex = -1;
        }
        void loadData()
        {
            
            dgvKhenThuongKyLuat.DataSource = _ktkl.GetAllKhenThuongKyLuat();
            // Bỏ chọn tất cả các dòng
            dgvKhenThuongKyLuat.ClearSelection();
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
            // sau khi thêm xong thì load lại data ở frm này để hiển thị thông tin vừa thêm
            loadData();
        }

        private void btnSuaKTKL_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn khen thưởng kỷ luật cần sửa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //bấm sửa thì bật formm điều chỉnh và truyền dòng đó vào để lấy thông tin từ dòng đó để hiển thị lên frm
            new frmDieuChinhKTKL(r).ShowDialog();
            //sau khi sửa thì load lại data ở frm này để hiển thị lại thông tin 
            loadData();
        }

        private void btnXoaKTKL_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn khen thưởng kỷ luật cần xóa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //người dùng chọn ok trả về true tức là xác nhận xóa, còn bấm hủy thì false 
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
                MessageBox.Show("Vui lòng chọn nhân viên cần tìm kiếm", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvKhenThuongKyLuat.DataSource = _ktkl.TimKiemKhenThuongKyLuat(int.Parse(cbbNhanVien.SelectedValue.ToString()));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //làm mới lại combobox và load lại data ban đầu
            cbbNhanVien.SelectedIndex = -1;
          
            loadData();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            // Thay đổi cursor khi di chuyển vào PictureBox và bật tooltip
            Cursor = Cursors.Hand;

            toolTip1.Show("Làm mới", pictureBox1, 0, -20);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            // Khôi phục cursor khi rời khỏi PictureBox
            Cursor = Cursors.Default;
            toolTip1.Hide(pictureBox1);
        }
    }
}
