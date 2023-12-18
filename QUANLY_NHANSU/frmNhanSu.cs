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
        ToolTip toolTip1;
        private void frmNhanSu_Load(object sender, EventArgs e)
        {
            _nhanvien = new BLLNhanVien();
            _phongban = new BLLPhongBan();
            toolTip1 = new ToolTip();


            loadData();
           
            // điều chỉnh lại layout hiển thị hình ảnh
            ((DataGridViewImageColumn)dgvNhanVien.Columns["HinhAnh"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            LoadComboBox();
            cbbNhanVien.SelectedIndex = -1;
            cbbPhongBan.SelectedIndex = -1;

        }
        //load data
        void loadData()
        {
            dgvNhanVien.DataSource = _nhanvien.GetAllNhanVien();
            // Bỏ chọn tất cả các dòng
            dgvNhanVien.ClearSelection();

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
            // thêm thì mở frm điều chỉnh sau thêm thì load lại để hiện ra thằng vừa thêm
            loadData();
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 )
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
            // sửa thì mở form điều chỉnh và truyền dòng vừa chọn để lấy thông tin dòng tương ứng
            new frmDieuChinhNhanSu(r).ShowDialog();
            // sau khi sửa xong thì load lại data để hiển thị lại data
            loadData();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //người dùng chọn ok trả về true tức là xác nhận xóa, còn bấm hủy thì false 
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
            // nếu không chọn nhân viên thì truyền vào trừ 1 ngược lại thì truyền giá trị, tương tự phòng ban, để có thể tìm theo mỗi nhân viên hoặc theo mỗi phòng ban hoặc tìm theo cả 2
            dgvNhanVien.DataSource = _nhanvien.TimKiemNhanVien(cbbNhanVien.SelectedIndex >= 0 ? int.Parse(cbbNhanVien.SelectedValue.ToString()) : -1, cbbPhongBan.SelectedIndex >= 0 ? int.Parse(cbbPhongBan.SelectedValue.ToString()) : -1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // làm mới lại , bỏ chọn combobox tìm kiếm đồng thời load lại data 
            cbbNhanVien.SelectedIndex = -1;
            cbbPhongBan.SelectedIndex = -1;
            loadData();
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
