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
    public partial class frmDieuChinhBangLuong : Form
    {
        private DataGridViewRow r;
        BLLLuong _bangluong;
        public frmDieuChinhBangLuong()
        {
            InitializeComponent();
        }
        // khởi tạo form với dòng truyền vào để hiển thị thông tin vào form
        public frmDieuChinhBangLuong(DataGridViewRow r)
        {
            this.r = r;
            InitializeComponent();
        }


        private void frmDieuChinhBangLuong_Load(object sender, EventArgs e)
        {
            _bangluong = new BLLLuong();
            // nếu có dòng truyền vào là đang sửa ngược lại đang xóa
            if (r != null)
            {
                txtNam.Text = r.Cells["Nam"].Value.ToString() ?? string.Empty;
                txtThang.Text = r.Cells["Thang"].Value.ToString() ?? string.Empty;
                txtTrangThai.Text = r.Cells["TrangThai"].Value?.ToString() ?? string.Empty;
                btnThem.Text = "Sửa";
            }
            else
            {
                txtNam.Text = string.Empty;
                txtThang.Text = string.Empty;
                txtTrangThai.Text = string.Empty;
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
                var l = _bangluong.GetBangLuong(int.Parse(r.Cells["MaLuong"].Value.ToString()));
                l.Nam = txtNam.Text;
                l.Thang = int.Parse(txtThang.Text);
                l.TrangThai = txtTrangThai.Text;


                try
                {
                    var updatedBangLuong = _bangluong.Update(l);
                    MessageBox.Show("Cập nhật bảng lương thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật bảng lương thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                //Thêm thông tin
                Luong l = new Luong();
                l.Nam = txtNam.Text;
                l.Thang = int.Parse(txtThang.Text);
                l.TrangThai = txtTrangThai.Text;
                try
                {
                    var addedBangLuong = _bangluong.Add(l);
                    MessageBox.Show("Thêm bảng lương thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm bảng lương thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //ràng buộc phải nhập số và giới hạn kí tự nhập vào

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.HandleNumberKeyPress(sender as TextBox, e, "Vui lòng chỉ nhập số.", 4);
        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.HandleNumberKeyPress(sender as TextBox, e, "Vui lòng chỉ nhập số.", 2);
        }
    }
}
