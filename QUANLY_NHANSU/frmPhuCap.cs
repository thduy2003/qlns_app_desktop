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
    public partial class frmPhuCap : Form
    {
        BLLPhuCap _phucap;
        private DataGridViewRow r;
        BLLNhanVien _nhanvien;
        public frmPhuCap()
        {
            InitializeComponent();
        }

        private void frmPhuCap_Load(object sender, EventArgs e)
        {
            _phucap = new BLLPhuCap();
            _nhanvien = new BLLNhanVien();
            LoadData();
            LoadComboBox();
            cbbNhanVien.SelectedIndex = -1;
            cbbPhuCap.SelectedIndex = -1;


        }
        void LoadData()
        {
            dgvPhuCap.DataSource = _phucap.GetAllPhuCap();
        }
        void LoadComboBox()
        {
            cbbNhanVien.DataSource = _nhanvien.GetAllNhanVien();
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "MaNhanVien";

            cbbPhuCap.DataSource = _phucap.GetAllLoaiPhuCap();
            cbbPhuCap.DisplayMember = "TenPhuCap";
            cbbPhuCap.ValueMember = "MaLoaiPhuCap";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new frmDieuChinhPhuCap().ShowDialog();
            LoadData();
        }

        private void dgvPhuCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                r = dgvPhuCap.Rows[e.RowIndex];
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn phụ cấp cần sửa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            new frmDieuChinhPhuCap(r).ShowDialog();

            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn phụ cấp cần xóa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show($"Bạn có chắc chắn xóa phụ cấp của: {r.Cells["TenNhanVien"].Value?.ToString()} ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _phucap.Delete(int.Parse(r.Cells["MaPhuCap"].Value.ToString()));
                    MessageBox.Show("Xóa phụ cấp thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa phụ cấp thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbNhanVien.SelectedIndex < 0 && cbbPhuCap.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm kiếm", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvPhuCap.DataSource = _phucap.TimKiemPhuCap(cbbNhanVien.SelectedIndex >= 0 ? int.Parse(cbbNhanVien.SelectedValue.ToString()) : -1, cbbPhuCap.SelectedIndex >= 0 ? int.Parse(cbbPhuCap.SelectedValue.ToString()) : -1);
        }
    }
}
