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
    public partial class frmDieuChinhLLV : Form
    {
        public frmDieuChinhLLV()
        {
            InitializeComponent();
        }
        BLLLichLamViec _lichlamviec;
        BLLNhanVien _nhanvien;
        BLLLoaiCa _loaica;
        private DataGridViewRow r;
        // khởi tạo form có dòng truyền vào để lấy thông tin hiển thị lên form
        public frmDieuChinhLLV(DataGridViewRow r)
        {
            this.r = r;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbbThu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmThemLichLamViec_Load(object sender, EventArgs e)
        {
            _lichlamviec = new BLLLichLamViec();
            _nhanvien = new BLLNhanVien();
            _loaica = new BLLLoaiCa();
          
            loadCombobox();
            // có dòng truyền vào tức là đang sửa và ngược lại là đang thêm
            if(r != null)
            {
                cbbNhanVien.Text = r.Cells["HoTenNV"].Value.ToString();
                cbbCa.Text = r.Cells["Ca"].Value.ToString();
                cbbThu.Text = r.Cells["Thu"].Value.ToString();
                btnThem.Text = "Sửa";
            } else
            {
                cbbNhanVien.SelectedIndex = -1;
                cbbCa.SelectedIndex = -1;
                cbbThu.SelectedIndex = -1;
                btnThem.Text = "Thêm";
            }
           
          
        }
        void reset()
        {
            cbbNhanVien.SelectedIndex = -1;
            cbbCa.SelectedIndex = -1;
            cbbThu.SelectedIndex = -1;
        }
        void loadCombobox()
        {

            cbbNhanVien.DataSource = _nhanvien.GetAllNhanVien();
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "MaNhanVien";

            cbbCa.DataSource = _loaica.GetAllLoaiCa();
            cbbCa.DisplayMember = "TenLoaiCa";
            cbbCa.ValueMember = "MaLoaiCa";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Chú ý", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (cbbCa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn ca làm việc", "Chú ý", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (cbbThu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn thứ làm việc", "Chú ý", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            
            if( r != null)
            {
                // Sửa thông tin
                var llv = _lichlamviec.GetLichLamViec(int.Parse(r.Cells["MaLichLamViec"].Value.ToString()));
                llv.MaNhanVien = int.Parse(cbbNhanVien.SelectedValue.ToString());
                llv.MaLoaiCa = int.Parse(cbbCa.SelectedValue.ToString());
                llv.Thu = cbbThu.SelectedItem.ToString();

                try
                {
                    var updatedLLV = _lichlamviec.Update(llv);
                    MessageBox.Show("Cập nhật lịch làm việc thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
            
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật lịch làm việc thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } else
            {
                //Thêm thông tin
                LichLamViec llv = new LichLamViec();

                llv.MaNhanVien = int.Parse(cbbNhanVien.SelectedValue.ToString());
                llv.MaLoaiCa = int.Parse(cbbCa.SelectedValue.ToString());
                llv.Thu = cbbThu.SelectedItem.ToString();


                try
                {
                    var addedLichLam = _lichlamviec.Add(llv);
                    MessageBox.Show("Thêm lịch làm việc thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm lịch làm việc thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
