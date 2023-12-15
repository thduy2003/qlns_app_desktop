using BLLQLNS;
using DALQLNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_NHANSU
{
    public partial class frmDieuChinhNhanSu : Form
    {
        private DataGridViewRow r;
        BLLNhanVien _nhanvien;
        BLLPhongBan _phongban;
        BLLChucVu _chucvu;
        BLLAccount _taikhoan;
        public frmDieuChinhNhanSu()
        {
            InitializeComponent();
        }
        public frmDieuChinhNhanSu(DataGridViewRow r)
        {
            this.r = r;
        
         
            InitializeComponent();
        }
        void loadCombobox()
        {

            cbbPhongBan.DataSource = _phongban.GetAllPhongBan();
            cbbPhongBan.DisplayMember = "TenPhongBan";
            cbbPhongBan.ValueMember = "MaPhongBan";

            cbbChucVu.DataSource = _chucvu.GetAllChucVu();
            cbbChucVu.DisplayMember = "TenChucVu";
            cbbChucVu.ValueMember = "MaChucVu";
        }
        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        //chuyen tu base64 sang anh
        public Image Base64Image(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        private void frmDieuChinhNhanSu_Load(object sender, EventArgs e)
        {
            _nhanvien = new BLLNhanVien();
            _phongban = new BLLPhongBan();
            _chucvu = new BLLChucVu();
            _taikhoan = new BLLAccount();


            loadCombobox();
            if (r != null)
            {
                txtDiaChi.Text = r.Cells["DiaChi"].Value.ToString() ?? string.Empty;
                txtSDT.Text = r.Cells["SDT"].Value.ToString() ?? string.Empty;
                txtHoTen.Text = r.Cells["HoTen"].Value?.ToString() ?? string.Empty;
                txtCCCD.Text = r.Cells["CCCD"].Value?.ToString() ?? string.Empty;
                txtEmail.Text = r.Cells["Email"].Value?.ToString() ?? string.Empty;
                radNam.Checked = r.Cells["GioiTinh"].Value.ToString() == "Nam" ? true : false;
                radNu.Checked = r.Cells["GioiTinh"].Value.ToString() == "Nữ" ? true : false;
                cbbPhongBan.Text = r.Cells["PhongBan"].Value.ToString();
                object hinhAnhValue = r.Cells["HinhAnh"].Value;

                if (hinhAnhValue != null && hinhAnhValue != DBNull.Value)
                {
                    picHinhAnh.Image = Base64Image((byte[])hinhAnhValue);
                }
                else
                {

                    picHinhAnh.Image = picHinhAnh.ErrorImage;
                }
                txtEmail.Enabled = false;
                btnThem.Text = "Sửa";
            }
            else
            {
                reset();
                btnThem.Text = "Thêm";
            }
        }
        void reset()
        {
            txtDiaChi.Text = String.Empty;
            txtCCCD.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtHoTen.Text = String.Empty;
            txtSDT.Text = String.Empty;
            picHinhAnh.Image = null;
            cbbPhongBan.SelectedIndex = 0;
            cbbChucVu.SelectedIndex = 0;
            txtEmail.Enabled = true;
        }
        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg)| *.png; *.jpg ";
            openFile.Title = "Chọn hình ảnh";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(openFile.FileName);
                picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin nhân viên", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Select();
                return;
            }
            if (cbbPhongBan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng ban", "Chú ý", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (cbbChucVu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chức vụ", "Chú ý", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (r != null)
            {
                // Sửa thông tin 
                var nv = _nhanvien.GetNhanVien(int.Parse(r.Cells["MaNhanVien"].Value.ToString()));
                nv.HoTen = txtHoTen.Text;
                nv.GioiTinh = radNam.Checked ? "Nam" : "Nữ";
                nv.SDT = txtSDT.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.CCCD = txtCCCD.Text;
                nv.HinhAnh = ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
                nv.MaChucVu = int.Parse(cbbChucVu.SelectedValue.ToString());
                nv.MaPhongBan = int.Parse(cbbPhongBan.SelectedValue.ToString());

                try
                {
                    var updatedNhanVien = _nhanvien.Update(nv);
                    MessageBox.Show("Cập nhật nhân viên thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } else
            {
                //Thêm thông tin
                if (_taikhoan.CheckEmailTonTai(txtEmail.Text))
                {
                    MessageBox.Show("Email này đã tồn tại trong hệ thống", "Chú ý", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                NhanVien nv = new NhanVien();
                nv.HoTen = txtHoTen.Text;
                nv.GioiTinh = radNam.Checked ? "Nam" : "Nữ";
                nv.SDT = txtSDT.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.CCCD = txtCCCD.Text;
                nv.HinhAnh = ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
                nv.DaThoiViec = 0;
                nv.MaChucVu = int.Parse(cbbChucVu.SelectedValue.ToString());
                nv.MaPhongBan = int.Parse(cbbPhongBan.SelectedValue.ToString());
                nv.Email = txtEmail.Text;
                try
                {
                    var addedNhanVien = _nhanvien.Add(nv);
                    MessageBox.Show("Thêm nhân viên thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //thêm nhân viên mới xong thêm tài khoản vào database
                    _taikhoan.ThemTaiKhoan(txtEmail.Text, addedNhanVien.MaNhanVien);
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm nhân viên thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            }

            private void btnSua_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
