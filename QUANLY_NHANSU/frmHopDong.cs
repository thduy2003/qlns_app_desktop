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
    public partial class frmHopDong : Form
    {
        BLLHopDong _hopdong;
        BLLNhanVien _nhanvien;
        DataGridViewRow r;
        ToolTip toolTip1;
        public frmHopDong()
        {

            InitializeComponent();
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            _hopdong = new BLLHopDong();
            _nhanvien = new BLLNhanVien();
            toolTip1 = new ToolTip();
            LoadData();
            LoadCombobox();
            cbbNhanVien.SelectedIndex = -1;
        }
        void LoadCombobox()
        {
            cbbNhanVien.DataSource = _nhanvien.GetAllNhanVien();
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "MaNhanVien";
        }
        void LoadData()
        {
            dgvHopDong.DataSource = _hopdong.GetAllHopDong();
            // Bỏ chọn tất cả các dòng
            dgvHopDong.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new frmDieuChinhHopDong().ShowDialog();
            // mở frm điều chỉnh thêm và sau khi thêm xong thì load lại data để hiển thị thông tin vừa thêm
            LoadData();
        }

        private void dgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex >= 0)
            {

                r = dgvHopDong.Rows[e.RowIndex]; // xác định được 1 hàng vừa click
               
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần sửa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // mở form đồng thời truyền dòng đó vào để lấy thông tin từ dòng đó hiện lên form , sau khi sửa xong thì load lại data để hiển thị lại thông tin
            new frmDieuChinhHopDong(r).ShowDialog();

            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần xóa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //người dùng chọn ok trả về true tức là xác nhận xóa, còn bấm hủy thì false 
            if (MessageBox.Show($"Bạn có chắc chắn xóa hợp đồng của: {r.Cells["TenNhanVien"].Value?.ToString()} ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _hopdong.Delete(int.Parse(r.Cells["MaHopDong"].Value.ToString()));
                    MessageBox.Show("Xóa hợp đồng thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa hợp đồng thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbNhanVien.SelectedIndex < 0 && string.IsNullOrEmpty(txtTenHopDong.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm kiếm", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // nếu không chọn thì truyền -1 , để có thể tìm kiếm 1 trong 2 hoặc cả 2 
            dgvHopDong.DataSource = _hopdong.TimKiemHopDong(cbbNhanVien.SelectedIndex >= 0 ? int.Parse(cbbNhanVien.SelectedValue.ToString()) : -1, txtTenHopDong.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //làm mới lại tìm kiếm và load lại data ban đầu
            cbbNhanVien.SelectedIndex = -1;
            txtTenHopDong.Text = String.Empty;
            LoadData();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            // Thay đổi cursor khi di chuyển vào PictureBox và hiển thị tooltip
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
