using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOQLNS
{
    public class DTONhanVien
    {
        public int MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public byte[] HinhAnh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string CCCD { get; set; }
        public string PhongBan { get; set; }
    }
}
