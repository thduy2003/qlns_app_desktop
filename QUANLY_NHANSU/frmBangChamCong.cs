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
    public partial class frmBangChamCong : Form
    {
        BLLBangChamCong _bangchamcong;
        private DataGridViewRow r;
        public frmBangChamCong()
        {
            InitializeComponent();
            
        }

        private void frmBangChamCong_Load(object sender, EventArgs e)
        {
            _bangchamcong = new BLLBangChamCong();
            loadData();
        }
        void loadData()
        {
            BLLBangChamCong bcc = new BLLBangChamCong();
            dgvBangChamCong.DataSource = bcc.GetAllBangChamCong();
        }
        private void dgvBangChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                r = dgvBangChamCong.Rows[e.RowIndex]; // xác định được 1 hàng vừa click
         
            }
        }
       
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn bảng chấm công cần xem", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            new frmBCCT(int.Parse(r.Cells["Thang"].Value.ToString()), r.Cells["Nam"].Value.ToString(), int.Parse(r.Cells["MaBangChamCong"].Value.ToString())).ShowDialog();
        }

       
        private void btnThemBCC_Click(object sender, EventArgs e)
        {
            new frmDieuChinhBCC().ShowDialog();
            loadData();
        }

        private void btnSuaBCC_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn bảng chấm công cần sửa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            new frmDieuChinhBCC(r).ShowDialog();

            loadData();
        }

        private void btnXoaBCC_Click(object sender, EventArgs e)
        {
            if (r == null || r.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn bảng chấm công cần xóa", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show($"Bạn có chắc chắn xóa bảng chấm công: {r.Cells["MaBangChamCong"].Value?.ToString()} ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _bangchamcong.Delete(int.Parse(r.Cells["MaBangChamCong"].Value.ToString()));
                    MessageBox.Show("Xóa bảng chấm công thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa bảng chấm công thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbThang.SelectedIndex < 0 || cbbNam.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ tháng và năm cần tìm kiếm", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvBangChamCong.DataSource = _bangchamcong.TimKiemBangChamCong(int.Parse(cbbThang.SelectedItem.ToString()), cbbNam.SelectedItem.ToString());
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    DALBangChamCong bcc = new DALBangChamCong();
        //    var kq = bcc.TinhTongGioTest();
        //    MessageBox.Show(kq.ToString());
        //}
    }
}
