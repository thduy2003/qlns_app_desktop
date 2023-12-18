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
        //khởi tạo form với dòng truyền vào để từ dòng lấy thông tin hiển thị ra form
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
        // hàm chuyển đổi ảnh sang base64
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
            //không cho điều chỉnh phòng ban
            cbbPhongBan.Enabled = false;

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
                cbbChucVu.Text = r.Cells["ChucVu"].Value.ToString();
                object hinhAnhValue = r.Cells["HinhAnh"].Value;
                // nếu có hinhAnh là base64 thì chuyển từ base64 sang ảnh để hiển thị còn không thì hiển thị error Image
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
        // hàm mở file chọn ảnh
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

          
        // khi chọn chức vụ thì nó sẽ tự động chọn phòng ban để đồng bộ dữ liệu
        private void cbbChucVu_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (cbbChucVu.SelectedValue.ToString() != null)
            {
                string selectedChucVu = cbbChucVu.SelectedValue.ToString();
        
               
                switch (selectedChucVu)
                {
                    case "1":
                        cbbPhongBan.SelectedIndex = 0;
                        break;
                    case "2":
                        cbbPhongBan.SelectedIndex = 1;
                        break;
                    case "3":
                        cbbPhongBan.SelectedIndex = 2;
                        break;
                    case "4":
                        cbbPhongBan.SelectedIndex = 3;
                        break;
                    default:
                       
                        break;
                }
           
            }
        }

        
        //ràng buộc phải nhập số và giới hạn số lượng kí tự
        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.HandleNumberKeyPress(sender as TextBox, e, "Vui lòng chỉ nhập số cho CCCD.",12);
       
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.HandleNumberKeyPress(sender as TextBox, e, "Vui lòng chỉ nhập số cho SDT.", 10);
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
