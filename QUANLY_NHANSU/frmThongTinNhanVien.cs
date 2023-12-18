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
        // khởi tạo lấy đối tượng nhân viên đăng nhập
        public frmThongTinNhanVien(NhanVien _nhanvien)
        {
            this._nhanvien = _nhanvien;
            InitializeComponent();
        }
        //Chuyển hình sang base64
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
            
            //lấy thông tin nhân viên đang đăng nhập
            NhanVien nv = bllNhanVien.GetNhanVien(_nhanvien.MaNhanVien);
            txtCCCD.Text = nv.CCCD;
            txtDiaChi.Text = nv.DiaChi;
            txtEmail.Text = nv.Email;
            txtHoTen.Text = nv.HoTen;
            txtSDT.Text = nv.SDT;
            cbbChucVu.Text = nv.ChucVu.TenChucVu;
            cbbPhongBan.Text = nv.PhongBan.TenPhongBan;
            object hinhAnhValue = nv.HinhAnh;
            //nếu có ảnh base64 trong db thì hiện nó còn không thì hiện ảnh error
            if (hinhAnhValue != null && hinhAnhValue != DBNull.Value)
            {
                //chuyển base64 từ db ra dạng ảnh
                picHinhAnh.Image = Base64Image((byte[])hinhAnhValue);
            }
            else
            {

                picHinhAnh.Image = picHinhAnh.ErrorImage;
            }
            radNam.Checked = nv.GioiTinh == "Nam" ? true : false;
            radNu.Checked = nv.GioiTinh == "Nữ" ? true : false;
            //không cho chỉnh sửa các trường
            txtEmail.Enabled = false;
            txtHoTen.Enabled = false;
            cbbChucVu.Enabled = false;
            cbbPhongBan.Enabled = false;
            radNam.Enabled = false;
            radNu.Enabled = false;
            //lấy ra lịch làm việc của nhân viên đăng nhập
            dgvLichLamViec.DataSource = bllLich.GetLichLamViecCuaNV(_nhanvien.MaNhanVien);

        }

        //cập nhật lại thông tin
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
        //hàm chọn hình ảnh , mở file
        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg)| *.png; *.jpg ";
            openFile.Title = "Chọn hình ảnh";
            // chọn file thì set hình ảnh đó vô picHinhAnh
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(openFile.FileName);
                picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        //ràng buộc các kí tự nhập vào trường điện thoại
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.HandleNumberKeyPress(sender as TextBox, e, "Vui lòng chỉ nhập số cho SDT.", 10);

        }
        //ràng buộc các kí tự nhập vào trường CCCD
        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.HandleNumberKeyPress(sender as TextBox, e, "Vui lòng chỉ nhập số cho CCCD.", 12);

        }
    }
}
