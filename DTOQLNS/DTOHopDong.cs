using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOQLNS
{
    public class DTOHopDong
    {
        private int maHopDong;
        private string tenNhanVien;
        private string tenHopDong;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private DateTime ngayKy;
        private string noiDung;
        private int lanKy;
        private string thoiHan;
        private float heSoLuong;
        private float luongCoBan;

        public int MaHopDong { get => maHopDong; set => maHopDong = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string TenHopDong { get => tenHopDong; set => tenHopDong = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public DateTime NgayKy { get => ngayKy; set => ngayKy = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public int LanKy { get => lanKy; set => lanKy = value; }
        public string ThoiHan { get => thoiHan; set => thoiHan = value; }
        public float HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public float LuongCoBan { get => luongCoBan; set => luongCoBan = value; }
    }
}
