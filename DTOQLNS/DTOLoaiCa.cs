using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOQLNS
{
    public class DTOLoaiCa
    {
        private int maLoaiCa;
        private string tenLoaiCa;
        private string gioBatDau;
        private string gioKetThuc;

        public int MaLoaiCa { get => maLoaiCa; set => maLoaiCa = value; }
        public string TenLoaiCa { get => tenLoaiCa; set => tenLoaiCa = value; }
        public string GioBatDau { get => gioBatDau; set => gioBatDau = value; }
        public string GioKetThuc { get => gioKetThuc; set => gioKetThuc = value; }
    }
}
