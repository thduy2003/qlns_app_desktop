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
    public partial class frmDieuChinhBCC : Form
    {
        private DataGridViewRow r;
        BLLBangChamCong _bangchamcong;
        public frmDieuChinhBCC()
        {
            InitializeComponent();
        }
        public frmDieuChinhBCC(DataGridViewRow r)
        {
            InitializeComponent();
            this.r = r;
        }

        private void frmDieuChinhBCC_Load(object sender, EventArgs e)
        {
            _bangchamcong = new BLLBangChamCong();
            if (r != null)
            {

                txtNam.Text = r.Cells["Nam"].Value.ToString() ?? string.Empty;
                txtThang.Text = r.Cells["Thang"].Value.ToString() ?? string.Empty;
                txtTrangThai.Text = r.Cells["TrangThai"].Value?.ToString() ?? string.Empty;
                btnThem.Text = "Sửa";
            }
            else
            {
                txtNam.Text =  string.Empty;
                txtThang.Text =  string.Empty;
                txtTrangThai.Text =  string.Empty;
                btnThem.Text = "Thêm";
            }

           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNam.Text) || string.IsNullOrEmpty(txtThang.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin bảng chấm công", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNam.Select();
                return;
            }
            if (!(int.Parse(txtThang.Text) > 0 && int.Parse(txtThang.Text) < 13))
            {
                MessageBox.Show("Vui lòng nhập đúng tháng", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThang.Select();
                return;
            }
            if (r != null)
            {
                // Sửa thông tin
                var bcc = _bangchamcong.GetBangChamCong(int.Parse(r.Cells["MaBangChamCong"].Value.ToString()));
                bcc.Nam = txtNam.Text;
                bcc.Thang = int.Parse(txtThang.Text);
                bcc.TrangThai = txtTrangThai.Text;


                try
                {
                    var updatedNhanVien = _bangchamcong.Update(bcc);
                    MessageBox.Show("Cập nhật bảng chấm công thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật bảng chấm công thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                //Thêm thông tin
                BangChamCong bcc = new BangChamCong();
                bcc.Nam = txtNam.Text;
                bcc.Thang = int.Parse(txtThang.Text);
                bcc.TrangThai = txtTrangThai.Text;
                try
                {
                    var addedNhanVien = _bangchamcong.Add(bcc);
                    MessageBox.Show("Thêm bảng chấm công thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm bảng chấm công thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
