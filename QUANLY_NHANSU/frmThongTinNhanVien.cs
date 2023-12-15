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
    public partial class frmThongTinNhanVien : Form
    {
        private NhanVien _nhanvien;
        BLLNhanVien bllNhanVien;
        BLLLichLamViec bllLich;
        public frmThongTinNhanVien(NhanVien _nhanvien)
        {
            this._nhanvien = _nhanvien;
            InitializeComponent();
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
        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            bllNhanVien = new BLLNhanVien();
            bllLich = new BLLLichLamViec();
            NhanVien nv = bllNhanVien.GetNhanVien(_nhanvien.MaNhanVien);
            txtCCCD.Text = nv.CCCD;
            txtDiaChi.Text = nv.DiaChi;
            txtEmail.Text = nv.Email;
            txtHoTen.Text = nv.HoTen;
            txtSDT.Text = nv.SDT;
            cbbChucVu.Text = nv.ChucVu.TenChucVu;
            cbbPhongBan.Text = nv.PhongBan.TenPhongBan;
            object hinhAnhValue = nv.HinhAnh;

            if (hinhAnhValue != null && hinhAnhValue != DBNull.Value)
            {
                picHinhAnh.Image = Base64Image((byte[])hinhAnhValue);
            }
            else
            {

                picHinhAnh.Image = picHinhAnh.ErrorImage;
            }
            radNam.Checked = nv.GioiTinh == "Nam" ? true : false;
            radNu.Checked = nv.GioiTinh == "Nữ" ? true : false;
            txtEmail.Enabled = false;
            txtHoTen.Enabled = false;
            cbbChucVu.Enabled = false;
            cbbPhongBan.Enabled = false;
            radNam.Enabled = false;
            radNu.Enabled = false;
            dgvLichLamViec.DataSource = bllLich.GetLichLamViecCuaNV(_nhanvien.MaNhanVien);

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NhanVien nv = bllNhanVien.GetNhanVien(_nhanvien.MaNhanVien);
      
            nv.SDT = txtSDT.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.CCCD = txtCCCD.Text;
            nv.HinhAnh = ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
  

            try
            {
                var updatedNhanVien = bllNhanVien.Update(nv);
                MessageBox.Show("Cập nhật thông tin thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thông tin thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
    }
}
