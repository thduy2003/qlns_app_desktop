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
    public partial class frmDoiMatKhau : Form
    {
        BLLAccount _taikhoan;
        private NhanVien _nhanvien;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        public frmDoiMatKhau(NhanVien _nhanvien)
        {
            this._nhanvien = _nhanvien;
            InitializeComponent();
        }
        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            _taikhoan = new BLLAccount();

        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            #region rang_buoc
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện tại", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtNewPass.Text) || string.IsNullOrEmpty(txtConfirmPass.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPass.Select();
                return;
            }
            if (!txtNewPass.Text.Equals(txtConfirmPass.Text))
            {
                MessageBox.Show("Mật khẩu mới và xác nhận không khớp", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPass.Select();
                return;
            }
            #endregion
           try
            {
                var tk = _taikhoan.ValidateAccount(_nhanvien.Email, txtPass.Text);
                if(tk == null)
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPass.Select();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _taikhoan.DoiMatKhau(_nhanvien.Email, txtNewPass.Text);
                MessageBox.Show("Đổi mật khẩu thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
}
