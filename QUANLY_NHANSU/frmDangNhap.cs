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
    public partial class frmDangNhap : Form
    {
        BLLAccount _taikhoan;
        public NhanVien _nhanvien;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            _taikhoan = new BLLAccount();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "EMAIL ĐĂNG NHẬP")
            {
                txtEmail.Text = null;
              
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "EMAIL ĐĂNG NHẬP";
          
            }
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "MẬT KHẨU")
            {
                txtPass.Text = null;
             
            }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "MẬT KHẨU";
                txtPass.PasswordChar = '\0';
               
            }
        }

        private void chkAnHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnHienMatKhau.Checked == true)
                txtPass.PasswordChar = '\0';
            else
                txtPass.PasswordChar = '*';
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if(!chkAnHienMatKhau.Checked)
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Select();
                return;
            }
           
            var tk = _taikhoan.ValidateAccount(txtEmail.Text, txtPass.Text);
            if (tk != null)
            {
                MessageBox.Show("Đăng nhập thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _nhanvien = tk;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tài khoản và mật khẩu", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Select();
                return;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu phím Enter được nhấn
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Ngăn chặn sự kiện KeyPress để không thêm ký tự Enter vào TextBox
                e.Handled = true;

                // Gọi sự kiện Click của nút đăng nhập
                btnDangNhap.PerformClick();
            }
        }
    }
}
