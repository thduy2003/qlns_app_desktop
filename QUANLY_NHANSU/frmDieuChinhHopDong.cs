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
    public partial class frmDieuChinhHopDong : Form
    {
        private DataGridViewRow r;
        BLLNhanVien _nhanvien;
        BLLHopDong _hopdong;
        public frmDieuChinhHopDong()
        {
            InitializeComponent();
        }
        //khởi tạo form có dòng truyền vào để từ dòng có thông tin hiện lên form
        public frmDieuChinhHopDong(DataGridViewRow r)
        {
            InitializeComponent();
            this.r = r;
        }

       

        private void frmDieuChinhHopDong_Load(object sender, EventArgs e)
        {
            _nhanvien = new BLLNhanVien();
            _hopdong = new BLLHopDong();
            loadCombobox();
            // nếu có dòng tức là đangg sửa còn không thì đang thêm
            if (r != null)
            {
    
                cbbNhanVien.Text = r.Cells["TenNhanVien"].Value.ToString();
                txtHeSoLuong.Text = r.Cells["HeSoLuong"].Value.ToString() ?? string.Empty;
                txtLanKy.Text = r.Cells["LanKy"].Value.ToString() ?? string.Empty;
                txtLuongCoBan.Text = r.Cells["LuongCoBan"].Value.ToString() ?? string.Empty;
                txtNoiDung.Text = r.Cells["NoiDung"].Value.ToString() ?? string.Empty;
                txtTenHopDong.Text = r.Cells["TenHopDong"].Value.ToString() ?? string.Empty;
                txtThoiHan.Text = r.Cells["ThoiHan"].Value.ToString() ?? string.Empty;
                dtpNgayKy.Text = r.Cells["NgayKy"].Value.ToString();
                dtpNgayBatDau.Text = r.Cells["NgayBatDau"].Value.ToString();
                dtpNgayKetThuc.Text = r.Cells["NgayKetThuc"].Value.ToString();
                btnThem.Text = "Sửa";
            }
            else
            {
                cbbNhanVien.SelectedIndex = -1;
                dtpNgayKy.Value = DateTime.Today;
                dtpNgayBatDau.Value = DateTime.Today;
                dtpNgayKetThuc.Value = DateTime.Today;
                txtLanKy.Text = string.Empty;
                txtNoiDung.Text = string.Empty;
                txtHeSoLuong.Text = string.Empty;
                txtLuongCoBan.Text = string.Empty;
                txtTenHopDong.Text = string.Empty;
                txtThoiHan.Text = string.Empty;
                 
                btnThem.Text = "Thêm";
            }
        }
        void loadCombobox()
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
      
            if (string.IsNullOrEmpty(txtTenHopDong.Text) || string.IsNullOrEmpty(txtLuongCoBan.Text) || string.IsNullOrEmpty(txtHeSoLuong.Text) || string.IsNullOrEmpty(txtThoiHan.Text) || string.IsNullOrEmpty(txtLanKy.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Chú ý", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if(dtpNgayKetThuc.Value < dtpNgayBatDau.Value)
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayKetThuc.Value = dtpNgayBatDau.Value;
                return;
            }
            if (dtpNgayKy.Value <= dtpNgayBatDau.Value)
            {
                MessageBox.Show("Ngày ký phải trước hoặc bằng ngày bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayKy.Value = dtpNgayBatDau.Value;
                return;
            }
            if (r != null)
            {
                // Sửa thông tin
                var hd = _hopdong.GetHopDong(int.Parse(r.Cells["MaHopDong"].Value.ToString()));
                hd.MaNhanVien = int.Parse(cbbNhanVien.SelectedValue.ToString());
                hd.NgayBatDau = dtpNgayBatDau.Value;
                hd.NgayKetThuc = dtpNgayKetThuc.Value;
                hd.NgayKy = dtpNgayKy.Value;
                hd.HeSoLuong = float.Parse(txtHeSoLuong.Text);
                hd.LuongCoBan = float.Parse(txtLuongCoBan.Text);
                hd.ThoiHan = txtThoiHan.Text;
                hd.TenHopDong = txtTenHopDong.Text;
                hd.NoiDung = txtNoiDung.Text;
                hd.LanKy = int.Parse(txtLanKy.Text);
              
                try
                {
                    var updatedHD = _hopdong.Update(hd);
                    MessageBox.Show("Cập nhật hợp đồng thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật hợp đồng thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                //Thêm thông tin
                HopDong hd = new HopDong();

                hd.MaNhanVien = int.Parse(cbbNhanVien.SelectedValue.ToString());
                hd.NgayBatDau = dtpNgayBatDau.Value;
                hd.NgayKetThuc = dtpNgayKetThuc.Value;
                hd.NgayKy = dtpNgayKy.Value;
                hd.HeSoLuong = float.Parse(txtHeSoLuong.Text);
                hd.LuongCoBan = float.Parse(txtLuongCoBan.Text);
                hd.ThoiHan = txtThoiHan.Text;
                hd.TenHopDong = txtTenHopDong.Text;
                hd.NoiDung = txtNoiDung.Text;
                hd.LanKy = int.Parse(txtLanKy.Text);


                try
                {
                    var addedHD = _hopdong.Add(hd);
                    MessageBox.Show("Thêm hợp đồng thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm hợp đồng thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //ràng buộc phải nhập số và giới hạn kí tự nhập vào
        private void txtLanKy_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.HandleNumberKeyPress(sender as TextBox, e, "Vui lòng chỉ nhập số.",2);
        }

        private void txtLuongCoBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.HandleNumberKeyPress(sender as TextBox, e, "Vui lòng chỉ nhập số.");
        }

        private void txtHeSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.HandleDemicalNumberKeyPress(sender as TextBox, e, "Vui lòng chỉ nhập số hoặc số thập phân.");
        }
    }
}
