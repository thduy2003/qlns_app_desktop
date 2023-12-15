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
    public partial class frmLichLamViec : Form
    {
        BLLLichLamViec _lichlamviec;
        BLLNhanVien _nhanvien;
        BLLLoaiCa _loaica;
        private DataGridViewRow r;

        public frmLichLamViec()
        {
            InitializeComponent();
        }

        private void frmLichLamViec_Load(object sender, EventArgs e)
        {
            _lichlamviec = new BLLLichLamViec();
            _nhanvien = new BLLNhanVien();
            _loaica = new BLLLoaiCa();

            loadData();
            LoadComboBox();
            cbbNhanVien.SelectedIndex = -1;
            cbbCa.SelectedIndex = -1;


        }
        public void loadData()
        {
            dgvLichLamViec.DataSource = _lichlamviec.GetAllLichLamViec();
        }
        void LoadComboBox()
        {
            cbbNhanVien.DataSource = _nhanvien.GetAllNhanVien();
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "MaNhanVien";

            cbbCa.DataSource = _loaica.GetAllLoaiCa();
            cbbCa.DisplayMember = "TenLoaiCa";
            cbbCa.ValueMember = "MaLoaiCa";
        }
        private void dgvLichLamViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                r = dgvLichLamViec.Rows[e.RowIndex]; // xác định được 1 hàng vừa click
               
            }
        }

        private void btnThemLich_Click(object sender, EventArgs e)
        {
            new frmDieuChinhLLV().ShowDialog();
            loadData();
        }

        private void btnSuaLich_Click(object sender, EventArgs e)
        {
            if(r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn lịch làm việc cần sửa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       return;
            }
            new frmDieuChinhLLV(r).ShowDialog();
           
            loadData();
        }



        private void btnXoaLich_Click(object sender, EventArgs e)
        {
            
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn lịch làm việc cần xóa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show($"Bạn có chắc chắn xóa lịch làm việc của: {r.Cells["HoTenNV"].Value?.ToString()} ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _lichlamviec.Delete(int.Parse(r.Cells["MaLichLamViec"].Value.ToString()));
                    MessageBox.Show("Xóa lịch làm việc thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa lịch làm việc thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbNhanVien.SelectedIndex < 0 && cbbCa.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm kiếm", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvLichLamViec.DataSource = _lichlamviec.TimKiemLichLamViec(cbbNhanVien.SelectedIndex >= 0 ? int.Parse(cbbNhanVien.SelectedValue.ToString()) : -1, cbbCa.SelectedIndex >= 0 ? int.Parse(cbbCa.SelectedValue.ToString()) : -1);
        }
    }
}
