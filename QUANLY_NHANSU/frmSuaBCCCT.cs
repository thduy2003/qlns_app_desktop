using BLLQLNS;
using DALQLNS;
using DTOQLNS;
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
    public partial class frmSuaBCCCT : Form
    {
        BLLBangChamCong _bcc;
        BLLLoaiCa _loaica;
    
        public string thu;
        public DateTime ngay;
        public int maNhanVien;
        public string tenNhanVien;
        public int maBangChamCong;
        private DataGridViewRow r;
        //khởi tạo form sửa bccct với maNV, thu,ngay,tenNhanVien,maBangChamCong để hiển thị thông tin chấm công của người đó
        public frmSuaBCCCT(int maNhanVien, string thu, DateTime ngay, string tenNhanVien, int maBangChamCong)
        {
            this.thu = thu;
            this.maNhanVien = maNhanVien;
            this.ngay = ngay;
            this.tenNhanVien = tenNhanVien;
            this.maBangChamCong = maBangChamCong;
            
            InitializeComponent();
        
        }

        private void frmSuaBCCCT_Load(object sender, EventArgs e)
        {
            _bcc = new BLLBangChamCong();
            _loaica = new BLLLoaiCa();
            lblNhanVien.Text = tenNhanVien;
            lblNgay.Text = ngay.ToString("d/M/yyyy");
            lblThu.Text = thu ;
      
            
            loadData();
            loadCombobox();
        }
        void loadCombobox()
        {

            cbbCa.DataSource = _loaica.GetAllLoaiCa();
            cbbCa.DisplayMember = "TenLoaiCa";
            cbbCa.ValueMember = "MaLoaiCa";
        }
        void loadData()
        {
            //get chitiet cham cong cua nhân viên đó vào ngày đó và thứ đó
            dgvChiTietChamCong.DataSource = _bcc.GetChiTietBCC(maNhanVien, thu, ngay);
        }
        void reset()
        {
            mtbGioRa.Text = String.Empty;
            mtbGioVao.Text = String.Empty;
        }
        private void dgvChiTietChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                r = dgvChiTietChamCong.Rows[e.RowIndex]; // lấy ra dòng đã chọn
              
               
                mtbGioRa.Text = r.Cells["GioRa"].Value.ToString();
               
                mtbGioVao.Text = r.Cells["GioVao"].Value.ToString();
                cbbCa.Text = r.Cells["Ca"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(mtbGioRa.Text) || string.IsNullOrEmpty(mtbGioVao.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ giờ vào và giờ ra", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(cbbCa.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn ca", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Thêm thông tin
            DuLieuChamCong dlcc = new DuLieuChamCong();

            dlcc.MaNhanVien = maNhanVien;
            dlcc.HoTen = tenNhanVien;
            dlcc.MaLoaiCa = int.Parse(cbbCa.SelectedValue.ToString());
            dlcc.GioRa = mtbGioRa.Text;
            dlcc.GioVao = mtbGioVao.Text;
            dlcc.MaBangChamCong = maBangChamCong;
            dlcc.Thu = thu;
            dlcc.Ngay = ngay;


            try
            {
                var addedLichLam = _bcc.AddDuLieu(dlcc);
                MessageBox.Show("Thêm dữ liệu thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                reset();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm dữ liệu thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu chấm công cần sửa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(mtbGioRa.Text) || string.IsNullOrEmpty(mtbGioVao.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ giờ vào và giờ ra", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbbCa.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn ca", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var pc = _bcc.GetDuLieu(int.Parse(r.Cells["MaDuLieuChamCong"].Value.ToString()));
       
            pc.MaLoaiCa = int.Parse(cbbCa.SelectedValue.ToString());
            pc.GioRa = mtbGioRa.Text;
            pc.GioVao = mtbGioVao.Text;
   


            try
            {
                var updatedPC = _bcc.UpdateDuLieu(pc);
                MessageBox.Show("Cập nhật dữ liệu thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu chấm công cần xóa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //nếu người dùng chọn xác nhận thì true tức sẽ xóa , còn không  thì false là không xóa
            if (MessageBox.Show($"Bạn có chắc chắn dữ liệu: {r.Cells["MaDuLieuChamCong"].Value?.ToString()} ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _bcc.DeleteDuLieu(int.Parse(r.Cells["MaDuLieuChamCong"].Value.ToString()));
                    MessageBox.Show("Xóa dữ liệu thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa dữ liệu thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }
    }
}
