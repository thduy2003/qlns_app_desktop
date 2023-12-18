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
    public partial class frmDieuChinhDonNghi : Form
    {
        private DataGridViewRow r;
        BLLNghiPhep _nghiphep;
        private int maNhanVien;
        // khởi tạo form có maNhanVien truyền vào để biết thằng nào nộp đơn
        public frmDieuChinhDonNghi(int maNhanVien)
        {
            this.maNhanVien = maNhanVien;
            InitializeComponent();
        }
        // đã bỏ không cho sửa thông tin nữa nha
        public frmDieuChinhDonNghi(DataGridViewRow r, int maNhanVien)
        {
            this.r = r;
            this.maNhanVien = maNhanVien;   
            InitializeComponent();
        }

        private void frmDieuChinhDonNghi_Load(object sender, EventArgs e)
        {
            _nghiphep = new BLLNghiPhep();
            LoadComboBox();
            if (r != null)
            {
                cbbLoaiPhep.Text = r.Cells["TenLoaiNghiPhep"].Value.ToString();
                txtLyDo.Text = r.Cells["LyDo"].Value.ToString() ?? string.Empty;
                dtpNgayNghi.Text = r.Cells["NgayNghi"].Value.ToString();
                dtpNgayNopDon.Text = r.Cells["NgayNopDon"].Value.ToString();
                btnThem.Text = "Sửa";
            }
            else
            {
                cbbLoaiPhep.SelectedIndex = -1;
                txtLyDo.Text = string.Empty;
                dtpNgayNghi.Value = DateTime.Today;
                dtpNgayNopDon.Value = DateTime.Today;
                btnThem.Text = "Thêm";
            }
        }
        void LoadComboBox()
        {
            cbbLoaiPhep.DataSource = _nghiphep.GetAllLoaiPhep();
            cbbLoaiPhep.DisplayMember = "TenLoaiNghiPhep";
            cbbLoaiPhep.ValueMember = "MaLoaiNghiPhep";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbLoaiPhep.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại phép", "Chú ý", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            

            if (r != null)
            {
                // Sửa thông tin
                var dnp = _nghiphep.GetDonNghi(int.Parse(r.Cells["MaDonNghiPhep"].Value.ToString()));
                dnp.MaLoaiNghiPhep = int.Parse(cbbLoaiPhep.SelectedValue.ToString());
                dnp.NgayNopDon = dtpNgayNopDon.Value;
                dnp.NgayNghi = dtpNgayNghi.Value;
                dnp.LyDo = txtLyDo.Text;

                try
                {
                    var updateDNP = _nghiphep.UpdateDon(dnp);
                    MessageBox.Show("Cập nhật đơn nghỉ thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật đơn nghỉ thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                //Thêm thông tin
                DonNghiPhep dnp = new DonNghiPhep();
                dnp.MaNhanVien = maNhanVien;
                dnp.MaLoaiNghiPhep = int.Parse(cbbLoaiPhep.SelectedValue.ToString());
                dnp.NgayNopDon = dtpNgayNopDon.Value;
                dnp.NgayNghi = dtpNgayNghi.Value;
                dnp.LyDo = txtLyDo.Text;
                dnp.Thu = cbbThu.SelectedItem.ToString();
                dnp.TrangThai = 0;




                try
                {
                    var addedDNP = _nghiphep.AddDon(dnp);
                    MessageBox.Show("Thêm đơn nghỉ thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm đơn nghỉ thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
