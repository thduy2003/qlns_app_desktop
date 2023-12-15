using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOQLNS
{
    public class DTOLoaiPhep
    {
        private int maLoaiNghiPhep;
        private string tenLoaiNghiPhep;

        public int MaLoaiNghiPhep { get => maLoaiNghiPhep; set => maLoaiNghiPhep = value; }
        public string TenLoaiNghiPhep { get => tenLoaiNghiPhep; set => tenLoaiNghiPhep = value; }
    }
    public class DTODonNghiPhep
    {
        private int maDonNghiPhep;
        private string tenLoaiNghiPhep;
        private string tenNhanVien;
        private DateTime ngayNopDon;
        private DateTime ngayNghi;
        private string lyDo;
        private int trangThai;

        public int MaDonNghiPhep { get => maDonNghiPhep; set => maDonNghiPhep = value; }
        public string TenLoaiNghiPhep { get => tenLoaiNghiPhep; set => tenLoaiNghiPhep = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public DateTime NgayNopDon { get => ngayNopDon; set => ngayNopDon = value; }
        public DateTime NgayNghi { get => ngayNghi; set => ngayNghi = value; }
        public string LyDo { get => lyDo; set => lyDo = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
