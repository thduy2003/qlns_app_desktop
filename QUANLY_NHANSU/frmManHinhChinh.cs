﻿using BLLQLNS;
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
    public partial class frmManHinhChinh : Form
    {
        private NhanVien _nhanvien;
        BLLAccount _taikhoan;
        public frmManHinhChinh()
        {
            InitializeComponent();
        }

        private void frmManHinhChinh_Load(object sender, EventArgs e)
        {
            _taikhoan = new BLLAccount();
            var f = new frmDangNhap();
            f.ShowDialog();
            _nhanvien = f._nhanvien;
            if (_nhanvien != null)
            {
                lblNhanVien.Text = String.Format("Nhân viên: {0}", _nhanvien.HoTen);

                try
                {
                    //Nếu là không phải là admin thì không được truy cập quản lý
                    if(!_taikhoan.KiemTraAdmin(_nhanvien.MaNhanVien))
                    {
                        chamCongToolStripMenuItem.Visible = false;
                        luongToolStripMenuItem.Visible = false;
                        KTKLToolStripMenuItem.Visible = false;
                        lichLamViecToolStripMenuItem.Visible = false;
                        hopDongToolStripMenuItem.Visible = false;
                        phuCapToolStripMenuItem.Visible = false;
                        nhanSuToolStripMenuItem.Text = "Thông tin cá nhân";
                        hoSoNhanVienToolStripMenuItem.Visible = false;
                        nghiPhepToolStripMenuItem.Text = "Yêu cầu nghỉ phép";
                        
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
            }
            else
            {
                Application.Exit();
            }
        }
        private void addForm(Form f)
        {
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill; // tu dong co gian

            f.TopLevel = false;
            f.TopMost = true;
            grbContent.Controls.Clear(); // xoa cac item dang co tren group box
            grbContent.Controls.Add(f);
            f.Show();
        }

        private void hoSoNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Nếu là không phải là admin thì không được truy cập quản lý
                if (!_taikhoan.KiemTraAdmin(_nhanvien.MaNhanVien))
                {
                    var f = new frmThongTinNhanVien(_nhanvien);
                    addForm(f);
                }
                else
                {
                    var f = new frmNhanSu();
                    addForm(f);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
        }

        private void hopDongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmHopDong();
            addForm(f);
        }

    


        private void bangChamCongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmBangChamCong();
            addForm(f);
        }

        private void tangCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmTangCa();
            addForm(f);
        }

        private void bangLuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmBangLuong();
            addForm(f);
        }


        private void nghiPhepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Nếu là không phải là admin thì không được truy cập quản lý
                if (!_taikhoan.KiemTraAdmin(_nhanvien.MaNhanVien))
                {
                    var f = new frmNopDonNghi(_nhanvien);
                    addForm(f);
                } else
                {
                    var f = new frmDuyetDonNghi();
                    addForm(f);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDoiMatKhau(_nhanvien);
            f.ShowDialog();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lichLamViecToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var f = new frmLichLamViec();
            addForm(f);
        }

        private void KTKLToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            var f = new frmKhenThuongKyLuat();
            addForm(f);
        }

        private void phuCapToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var f = new frmPhuCap();
            addForm(f);
        }

        private void nhanSuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Nếu là không phải là admin thì không được truy cập quản lý
                if (!_taikhoan.KiemTraAdmin(_nhanvien.MaNhanVien))
                {
                    var f = new frmThongTinNhanVien(_nhanvien);
                    addForm(f);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}