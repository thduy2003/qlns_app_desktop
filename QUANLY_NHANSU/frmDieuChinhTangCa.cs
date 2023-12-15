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
    public partial class frmDieuChinhTangCa : Form
    {
        private DataGridViewRow r;
        BLLTangCa _tangca;
        BLLNhanVien _nhanvien;
        public frmDieuChinhTangCa()
        {
            InitializeComponent();
        }
        public frmDieuChinhTangCa(DataGridViewRow r)
        {
            this.r = r;
            InitializeComponent();
        }

        private void frmDieuChinhTangCa_Load(object sender, EventArgs e)
        {
            _tangca = new BLLTangCa();
            _nhanvien = new BLLNhanVien();
            LoadComboBox();

            if (r != null)
            {
                cbbNhanVien.Text = r.Cells["TenNhanVien"].Value.ToString();
                dtpNgay.Text = r.Cells["Ngay"].Value.ToString();
                txtSoGio.Text = r.Cells["SoGio"].Value.ToString();
                btnThem.Text = "Sửa";
            }
            else
            {
                cbbNhanVien.SelectedIndex = -1;
                txtSoGio.Text = String.Empty;
                dtpNgay.Value = DateTime.Today;
                btnThem.Text = "Thêm";
            }
        }
        void LoadComboBox()
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

            if (string.IsNullOrEmpty(txtSoGio.Text) )
            {
                MessageBox.Show("Vui lòng nhập số giờ tăng ca", "Chú ý", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (r != null)
            {
                // Sửa thông tin
                var hd = _tangca.GetTangCa(int.Parse(r.Cells["MaTangCa"].Value.ToString()));
                hd.MaNhanVien = int.Parse(cbbNhanVien.SelectedValue.ToString());
                hd.Ngay = dtpNgay.Value;
                hd.SoGio = int.Parse(txtSoGio.Text);

                try
                {
                    var updatedTangCa = _tangca.Update(hd);
                    MessageBox.Show("Cập nhật tăng ca thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật tăng ca thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                //Thêm thông tin
                TangCa hd = new TangCa();

                hd.MaNhanVien = int.Parse(cbbNhanVien.SelectedValue.ToString());
                hd.Ngay = dtpNgay.Value;
                hd.SoGio = int.Parse(txtSoGio.Text);


                try
                {
                    var addedTangCa = _tangca.Add(hd);
                    MessageBox.Show("Thêm tăng ca thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm tăng ca thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
