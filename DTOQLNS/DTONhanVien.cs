using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOQLNS
{
    public class DTONhanVien
    {
        private int maNhanVien;
        private string hoTen;
        private byte[] hinhAnh;
        private string gioiTinh;
        private string diaChi;
        private string sDT;
        private string email;
        private string cCCD;
        private string phongBan;
        private string chucVu;

        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Email { get => email; set => email = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
    }
}
