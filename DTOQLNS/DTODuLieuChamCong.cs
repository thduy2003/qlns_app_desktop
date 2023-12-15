using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOQLNS
{
    public class DTODuLieuChamCong
    {
        private string ca;
        private string tenNhanVien;
        private int maDuLieuChamCong;
        private string thu;
        private DateTime ngay;
        private string gioVao;
        private string gioRa;

        public int MaDuLieuChamCong { get => maDuLieuChamCong; set => maDuLieuChamCong = value; }
        public string Ca { get => ca; set => ca = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string Thu { get => thu; set => thu = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public string GioVao { get => gioVao; set => gioVao = value; }
        public string GioRa { get => gioRa; set => gioRa = value; }
    }

}
