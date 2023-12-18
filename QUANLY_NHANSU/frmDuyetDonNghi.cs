using BLLQLNS;
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
    public partial class frmDuyetDonNghi : Form
    {
        BLLNghiPhep _nghiphep;
        private DataGridViewRow r;
        BLLNhanVien _nhanvien;
        ToolTip toolTip1;
        public frmDuyetDonNghi()
        {
            InitializeComponent();
        }

        private void frmDuyetDonNghi_Load(object sender, EventArgs e)
        {
            _nghiphep = new BLLNghiPhep();
            _nhanvien = new BLLNhanVien();
            toolTip1 = new ToolTip();

            LoadData();
            LoadCombobox();
            cbbNhanVien.SelectedIndex = -1;
            cbbTrangThai.SelectedIndex = -1;
        }
        void LoadCombobox()
        {
            cbbNhanVien.DataSource = _nhanvien.GetAllNhanVien();
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "MaNhanVien";
            //tạo dictionary gồm key và value để custom giá thành phần hiển thị và thành phần giá trị
            Dictionary<int, string> trangThaiItems = new Dictionary<int, string>
                                {
                                    { 0, "Chờ duyệt" },
                                    { 1, "Từ chối" },
                                    { 2, "Đã duyệt" }
                                };

            // Tạo một BindingSource và gán Dictionary cho DataSource
            BindingSource bindingSource = new BindingSource(trangThaiItems, null);

            // Gán BindingSource cho ComboBox
            cbbTrangThai.DataSource = bindingSource;

            // Thiết lập các thuộc tính ValueMember và DisplayMember
            cbbTrangThai.ValueMember = "Key";
            cbbTrangThai.DisplayMember = "Value";
        }
            void LoadData()
        {
            dgvDonNghi.DataSource = _nghiphep.GetAllDonNghiPhep();
            // Bỏ chọn tất cả các dòng
            dgvDonNghi.ClearSelection();
        }

        private void dgvDonNghi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                r = dgvDonNghi.Rows[e.RowIndex]; // xác định được 1 hàng vừa click

            }
        }

        private void btnDuyetDon_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn đơn nghỉ cần duyệt", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (r != null && int.Parse(r.Cells["TrangThai"].Value.ToString()) == 1)
            {
                MessageBox.Show("Đơn này đã được từ chối rồi", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (r != null && int.Parse(r.Cells["TrangThai"].Value.ToString()) == 2)
            {
                MessageBox.Show("Đơn này đã được duyệt rồi", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //người dùng chọn ok trả về true tức là xác nhận duyệt, còn bấm hủy thì false 
            if (MessageBox.Show($"Bạn có chắc chắn duyệt đơn nghỉ của: {r.Cells["TenNhanVien"].Value?.ToString()} ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _nghiphep.DuyetDonNghiPhep(int.Parse(r.Cells["MaDonNghiPhep"].Value.ToString()));
                    MessageBox.Show("Duyệt đơn nghỉ thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Duyệt đơn nghỉ thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn đơn nghỉ cần từ chối", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(r != null && int.Parse(r.Cells["TrangThai"].Value.ToString()) == 1)
            {
                MessageBox.Show("Đơn này đã được từ chối rồi", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (r != null && int.Parse(r.Cells["TrangThai"].Value.ToString()) == 2)
            {
                MessageBox.Show("Đơn này đã được duyệt rồi", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //người dùng chọn ok trả về true tức là xác nhận từ chối, còn bấm hủy thì false 
            if (MessageBox.Show($"Bạn có chắc chắn từ chối đơn nghỉ của: {r.Cells["TenNhanVien"].Value?.ToString()} ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _nghiphep.TuChoiDonNghiPhep(int.Parse(r.Cells["MaDonNghiPhep"].Value.ToString()));
                    MessageBox.Show("Từ chối đơn nghỉ thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Từ chối đơn nghỉ thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }
        //format lại giá trị hiển thị của cột TrangThai trên datagridview vì nó đang có giá trị 0,1,2 => chờ duyệt , từ chối , đã duyệt
        private void dgvDonNghi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvDonNghi.Columns["TrangThai"].Index && e.Value != null)
            {
                int trangThaiValue = Convert.ToInt32(e.Value);

                switch (trangThaiValue)
                {
                    case 0:
                        e.Value = "Chờ duyệt";
                        break;
                    case 1:
                        e.Value = "Từ chối";
                        break;
                    case 2:
                        e.Value = "Đã duyệt";
                        break;
                        
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbNhanVien.SelectedIndex < 0 && cbbTrangThai.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm kiếm", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // nếu không chọn thì truyền -1 để có thể tìm kiếm 1 trong 2 hoặc cả 2
            dgvDonNghi.DataSource = _nghiphep.TimKiemNghiPhep(cbbNhanVien.SelectedIndex >= 0 ? int.Parse(cbbNhanVien.SelectedValue.ToString()) : -1, cbbTrangThai.SelectedIndex >= 0 ? int.Parse(cbbTrangThai.SelectedValue.ToString()) : -1);
        }

        //private void btnTaoThongBao_Click(object sender, EventArgs e)
        //{
        //    new frmDieuChinhThongBao().ShowDialog();
        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //làm mới lại những cái đã tìm kiếm và load lại danh sách ban đầu
            cbbNhanVien.SelectedIndex = -1;
            cbbTrangThai.SelectedIndex = -1;
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
