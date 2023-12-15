using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOQLNS
{
    public class DTOLuong
    {
        private int maLuong;
        private string nam;
        private int thang;
        private string trangThai;

        public int MaLuong { get => maLuong; set => maLuong = value; }
        public string Nam { get => nam; set => nam = value; }
        public int Thang { get => thang; set => thang = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
    public class DTOChiTietLuong
    {
        private int maChiTietLuong;
        private int maLuong;
        private string tenNhanVien;
        private int maNhanVien;
        private float phuCap;
        private float soGioCong;
        private float thucLanh;

        public int MaChiTietLuong { get => maChiTietLuong; set => maChiTietLuong = value; }
        public int MaLuong { get => maLuong; set => maLuong = value; }
        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public float PhuCap { get => phuCap; set => phuCap = value; }
        public float SoGioCong { get => soGioCong; set => soGioCong = value; }
        public float ThucLanh { get => thucLanh; set => thucLanh = value; }
    }
}
