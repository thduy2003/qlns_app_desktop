using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOQLNS
{
    public class DTOKhenThuongKyLuat
    {
        private int maKhenThuongKyLuat;
        private string tenNhanVien;
        private string lyDo;
        private string noiDung;
        private DateTime ngay;

        public int MaKhenThuongKyLuat { get => maKhenThuongKyLuat; set => maKhenThuongKyLuat = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string LyDo { get => lyDo; set => lyDo = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
    }
}
