using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOQLNS
{
    public class DTOLichLamViec
    {
       
        private int maLichLamViec;
        private string ca;
        private string thu;
        private string hoTenNV;

        public int MaLichLamViec { get => maLichLamViec; set => maLichLamViec = value; }
        public string Ca { get => ca; set => ca = value; }
        public string Thu { get => thu; set => thu = value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
    }
}
