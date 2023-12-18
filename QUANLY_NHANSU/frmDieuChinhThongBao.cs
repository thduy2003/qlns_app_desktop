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
    public partial class frmDieuChinhThongBao : Form
    {
        private DataGridViewRow r;
        BLLBangChamCong _bcc;
        BLLThongBaoNghi _thongbao;
        public frmDieuChinhThongBao()
        {
            InitializeComponent();
        }
        // khởi tạo form nhận vào dòng thông tin để từ dòng lấy ra thông tin để hiển thị lên form
        public frmDieuChinhThongBao(DataGridViewRow r)
        {
            this.r = r;
            InitializeComponent();
        }

        private void frmDieuChinhThongBao_Load(object sender, EventArgs e)
        {
            _bcc = new BLLBangChamCong();
            _thongbao = new BLLThongBaoNghi();
            loadCombobox();

            if (r != null)
            {
                // nếu bật form mà có truyền dòng tức là đang sửa
                //từ mã chấm công lấy ra bảng chấm công cụ thể để lấy ra tháng với năm, bởi vì combobox đang có giá trị hiển thị là BCC Tháng ... / ...
                var bangchamcong = _bcc.GetBangChamCong(int.Parse(r.Cells["MaBangChamCong"].Value.ToString()));

                cbbBCC.Text = $"BCC Tháng {bangchamcong.Thang}/{bangchamcong.Nam}";
                txtNoiDung.Text = r.Cells["NoiDung"].Value.ToString();
                txtTieuDe.Text = r.Cells["TieuDe"].Value.ToString();
                dtpTuNgay.Text = r.Cells["TuNgay"].Value.ToString();
                dtpDenNgay.Text = r.Cells["DenNgay"].Value.ToString();
                btnThem.Text = "Sửa";
            }
            else
            {
                // không truyền dòng thì đang thêm
                cbbBCC.SelectedIndex = -1;
                dtpTuNgay.Value = DateTime.Today;
                dtpDenNgay.Value = DateTime.Today;
                txtNoiDung.Text = String.Empty;
                txtTieuDe.Text = String.Empty;

                btnThem.Text = "Thêm";
            }
        }
        void loadCombobox()
        {

            var listBangChamCong = _bcc.GetAllBangChamCong();
            // tinh chỉnh lại giá trị displayMember và ValueMMember
            // Tạo danh sách mới chứa đối tượng KeyValuePair với Key là MaBangChamCong và Value là chuỗi ghép của Năm và Tháng
            var listDisplayAndValue = listBangChamCong
                .Select(item => new KeyValuePair<int, string>(item.MaBangChamCong, $"BCC Tháng {item.Thang}/{item.Nam}"))
                .ToList();

            cbbBCC.DataSource = listDisplayAndValue;
            cbbBCC.DisplayMember = "Value";
            cbbBCC.ValueMember = "Key";



        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (cbbBCC.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn bảng chấm công", "Chú ý", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtTieuDe.Text) || string.IsNullOrEmpty(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Chú ý", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cbbBCC.SelectedIndex != -1)
            {
                int selectedMaBangChamCong = int.Parse(cbbBCC.SelectedValue.ToString());
                //lấy bảng chấm công theo mã chấm công để lấy tháng và năm , sau đó so sánh coi có chọn ngày trong khoảng đó không vì đang thêm thông báo cho từng bảng chấm công theo tháng và theo năm
                var bcc = _bcc.GetBangChamCong(selectedMaBangChamCong);

                DateTime selectedTuNgay = dtpTuNgay.Value;

                // Kiểm tra xem ngày đã chọn có thuộc vào năm và tháng tương ứng hay không
                if (selectedTuNgay.Year != int.Parse(bcc.Nam) || selectedTuNgay.Month != bcc.Thang)
                {
                    MessageBox.Show("Vui lòng chọn ngày thuộc vào Năm và Tháng của bảng chấm công đã chọn", "Chú ý", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                DateTime selectedDenNgay = dtpTuNgay.Value;
                // Kiểm tra xem ngày đã chọn có thuộc vào năm và tháng tương ứng hay không
                if (selectedDenNgay.Year != int.Parse(bcc.Nam) || selectedDenNgay.Month != bcc.Thang)
                {
                    MessageBox.Show("Vui lòng chọn ngày thuộc vào Năm và Tháng của bảng chấm công đã chọn", "Chú ý", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
            }
            if (dtpDenNgay.Value < dtpTuNgay.Value)
            {
                MessageBox.Show("Ngày kết thúc nghỉ phải sau ngày bắt đầu nghỉ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDenNgay.Value = dtpTuNgay.Value;
                return;
            }
            

            // nếu có chọn dòng và mở frm điều chỉnh tức là đang sửa thông tin, còn không thì là thêm thông tin
            if (r != null)
            {
                // Sửa thông tin
                var hd = _thongbao.GetThongBao(int.Parse(r.Cells["MaThongBao"].Value.ToString()));
                hd.MaBangChamCong = int.Parse(cbbBCC.SelectedValue.ToString());
                hd.TuNgay = dtpTuNgay.Value;
                hd.DenNgay = dtpDenNgay.Value;
                hd.TieuDe = txtTieuDe.Text;
                hd.NoiDung = txtNoiDung.Text;
              

                try
                {
                    var updatedHD = _thongbao.Update(hd);
                    MessageBox.Show("Cập nhật thông báo thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thông báo thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                //Thêm thông tin
                ThongBaoNghi hd = new ThongBaoNghi();

                hd.MaBangChamCong = int.Parse(cbbBCC.SelectedValue.ToString());
                hd.TuNgay = dtpTuNgay.Value;
                hd.DenNgay = dtpDenNgay.Value;
                hd.TieuDe = txtTieuDe.Text;
                hd.NoiDung = txtNoiDung.Text;


                try
                {
                    var addedHD = _thongbao.Add(hd);
                    MessageBox.Show("Thêm thông báo thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thông báo thất bại với lỗi: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
