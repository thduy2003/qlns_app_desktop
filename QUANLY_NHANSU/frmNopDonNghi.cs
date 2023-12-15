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
    public partial class frmNopDonNghi : Form
    {
        private DataGridViewRow r;
        BLLNghiPhep _nghiphep;
        private NhanVien _nhanvien;
        public frmNopDonNghi()
        {
            InitializeComponent();
        }
        public frmNopDonNghi(NhanVien _nhanvien)
        {
            this._nhanvien = _nhanvien;
            InitializeComponent();
        }

        private void frmNopDonNghi_Load(object sender, EventArgs e)
        {
            _nghiphep = new BLLNghiPhep();
            LoadData();

        }
        void LoadData()
        {
            dgvDonNghi.DataSource = _nghiphep.GetAllDonNghiPhepOfNV(_nhanvien.MaNhanVien);

        }

        private void dgvDonNghi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                r = dgvDonNghi.Rows[e.RowIndex]; // xác định được 1 hàng vừa click

            }
        }

        private void btnThemDon_Click(object sender, EventArgs e)
        {
            new frmDieuChinhDonNghi(_nhanvien.MaNhanVien).ShowDialog();
            LoadData();
        }

        private void btnSuaDon_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn đơn nghỉ cần sửa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            new frmDieuChinhDonNghi(r, _nhanvien.MaNhanVien).ShowDialog();

            LoadData();
        }

        private void btnXoaDon_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn đơn nghỉ cần xóa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show($"Bạn có chắc chắn xóa đơn nghỉ phép: {r.Cells["MaDonNghiPhep"].Value?.ToString()} ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _nghiphep.DeleteDon(int.Parse(r.Cells["MaDonNghiPhep"].Value.ToString()));
                    MessageBox.Show("Xóa đơn nghỉ thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa đơn nghỉ thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

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
    }
}
