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
    public partial class frmThongBaoNghi : Form
    {
        BLLThongBaoNghi _thongbao;
        private DataGridViewRow r;
        ToolTip toolTip1;
        public frmThongBaoNghi()
        {
            InitializeComponent();
        }

        private void frmThongBaoNghi_Load(object sender, EventArgs e)
        {
            _thongbao = new BLLThongBaoNghi();
            toolTip1 = new ToolTip();
            LoadData();

        }
        void LoadData()
        {

            dgvThongBao.DataSource = _thongbao.GetAllThongBaoNghi();
            // Bỏ chọn tất cả các dòng
            dgvThongBao.ClearSelection();
        }

        private void dgvThongBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                r = dgvThongBao.Rows[e.RowIndex]; // xác định được 1 hàng vừa click

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Bấm thêm thì mở formr điều chỉnh 
            new frmDieuChinhThongBao().ShowDialog();
            // thêm xong thì load lại data vừa thêm
            LoadData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //bấm sửa thì mở form điều chỉnh và truyền dòng vừa chọn vào để hiển thị thông tin của dòng đó vào form điều chỉnh
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn thông báo cần sửa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            new frmDieuChinhThongBao(r).ShowDialog();
            //cập nhật xong thì load lại data vừa update
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn thông báo cần xóa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //nếu người dùng chọn xác nhận thì true tức sẽ xóa , còn không  thì false là không xóa
            if (MessageBox.Show($"Bạn có chắc chắn xóa thông báo: {r.Cells["MaThongBao"].Value?.ToString()} ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _thongbao.Delete(int.Parse(r.Cells["MaThongBao"].Value.ToString()));
                    MessageBox.Show("Xóa thông báo thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông báo thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbThang.SelectedIndex < 0 || cbbNam.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ tháng và năm cần tìm kiếm", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvThongBao.DataSource = _thongbao.TimKiemThongBao(int.Parse(cbbThang.SelectedItem.ToString()), cbbNam.SelectedItem.ToString());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // bấm làm mới thì set lại cbb và load lại data 
            cbbThang.SelectedIndex = -1;
            cbbNam.SelectedIndex = -1;
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
