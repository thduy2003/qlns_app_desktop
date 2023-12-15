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
    public partial class frmDieuChinhKTKL : Form
    {
        private DataGridViewRow r;
        BLLKhenThuongKyLuat _ktkl;
        BLLNhanVien _nhanvien;
        public frmDieuChinhKTKL()
        {
            InitializeComponent();
        }
        public frmDieuChinhKTKL(DataGridViewRow r)
        {
            this.r = r;
            InitializeComponent();
        }

        private void frmDieuChinhKTKL_Load(object sender, EventArgs e)
        {
            _ktkl = new BLLKhenThuongKyLuat();
            _nhanvien = new BLLNhanVien();
            LoadCombobox();

            if (r != null)
            {
                cbbNhanVien.Text = r.Cells["TenNhanVien"].Value.ToString();
                dtpNgay.Text = r.Cells["Ngay"].Value.ToString();
                txtLyDo.Text = r.Cells["LyDo"].Value.ToString();
                txtNoiDung.Text = r.Cells["NoiDung"].Value.ToString();
                btnThem.Text = "Sửa";
            }
            else
            {
                cbbNhanVien.SelectedIndex = -1;
                dtpNgay.Value = DateTime.Today;
                txtLyDo.Text = string.Empty;
                txtNoiDung.Text = string.Empty;
                btnThem.Text = "Thêm";
            }
        }
        void LoadCombobox()
        {
            cbbNhanVien.DataSource = _nhanvien.GetAllNhanVien();
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "MaNhanVien";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Chú ý", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            

            if (r != null)
            {
                // Sửa thông tin
                var ktkl = _ktkl.GetKhenThuongKyLuat(int.Parse(r.Cells["MaKhenThuongKyLuat"].Value.ToString()));
                ktkl.MaNhanVien = int.Parse(cbbNhanVien.SelectedValue.ToString());
                ktkl.Ngay = dtpNgay.Value;
                ktkl.LyDo = txtLyDo.Text;
                ktkl.NoiDung = txtNoiDung.Text;

                try
                {
                    var updatedKTKL = _ktkl.Update(ktkl);
                    MessageBox.Show("Cập nhật khen thưởng kỷ luật thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật khen thưởng kỷ luật thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (dtpNgay.Value < DateTime.Today)
                {
                    MessageBox.Show("Không được chọn ngày trong quá khứ", "Chú ý", MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                    return;
                }
                //Thêm thông tin
                KhenThuongKyLuat ktkl = new KhenThuongKyLuat();
                ktkl.MaNhanVien = int.Parse(cbbNhanVien.SelectedValue.ToString());
                ktkl.Ngay = dtpNgay.Value;
                ktkl.LyDo = txtLyDo.Text;
                ktkl.NoiDung = txtNoiDung.Text;


                try
                {
                    var addedKTKL = _ktkl.Add(ktkl);
                    MessageBox.Show("Thêm khen thưởng kỹ luật thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm khen thưởng kỹ luật thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
