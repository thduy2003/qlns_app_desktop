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
    public partial class frmTangCa : Form
    {
        BLLTangCa _tangca;
        BLLNhanVien _nhanvien;
        private DataGridViewRow r;
        ToolTip toolTip1;
        public frmTangCa()
        {
            InitializeComponent();
        }

        private void frmTangCa_Load(object sender, EventArgs e)
        {
            _tangca = new BLLTangCa();
            _nhanvien = new BLLNhanVien();
         
            toolTip1 = new ToolTip();
            LoadData();
            LoadComboBox();
            //ban đầu chưa cho cbb chọn gì
            cbbNhanVien.SelectedIndex = -1;
        }
        void LoadData()
        {
            dgvTangCa.DataSource = _tangca.GetAllTangCa();
            // Bỏ chọn tất cả các dòng
            dgvTangCa.ClearSelection();
        }
        void LoadComboBox()
        {
            cbbNhanVien.DataSource = _nhanvien.GetAllNhanVien();
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "MaNhanVien";

         
        }
        private void dgvTangCa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                r = dgvTangCa.Rows[e.RowIndex]; // xác định 1 dòng vừa chọn
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //bấm thêm thì mở form điều chỉnh
            new frmDieuChinhTangCa().ShowDialog();
            //load lại data sau khi thêm
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //bấm sửa thì mở form điều chỉnh
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn tăng ca cần sửa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //load lại data sau khi sửa
            new frmDieuChinhTangCa(r).ShowDialog();

            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn tăng ca cần xóa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //nếu người dùng chọn xác nhận thì true tức sẽ xóa , còn không  thì false là không xóa

            if (MessageBox.Show($"Bạn có chắc chắn xóa tăng ca của: {r.Cells["TenNhanVien"].Value?.ToString()} ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _tangca.Delete(int.Parse(r.Cells["MaTangCa"].Value.ToString()));
                    MessageBox.Show("Xóa tăng ca thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa tăng ca thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbNhanVien.SelectedIndex < 0 )
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm kiếm", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvTangCa.DataSource = _tangca.TimKiemTangCa(int.Parse(cbbNhanVien.SelectedValue.ToString()));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // bấm làm mới thì set lại cbb và load lại data 

            cbbNhanVien.SelectedIndex = -1;

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
