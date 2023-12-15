using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOQLNS
{
    public class DTOTangCa
    {
        private int maTangCa;
        private string tenNhanVien;
        private DateTime ngay;
        private float soGio;

        public int MaTangCa { get => maTangCa; set => maTangCa = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public float SoGio { get => soGio; set => soGio = value; }
    }
}
