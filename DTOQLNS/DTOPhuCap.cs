using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOQLNS
{
    public class DTOPhuCap
    {
        private int maPhuCap;
        private string tenNhanVien;
        private string tenPhuCap;
        private string noiDung;

        public int MaPhuCap { get => maPhuCap; set => maPhuCap = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string TenPhuCap { get => tenPhuCap; set => tenPhuCap = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
    }
    public class DTOLoaiPhuCap
    {
        private int maLoaiPhuCap;
        private string tenPhuCap;
        private float soTien;

        public int MaLoaiPhuCap { get => maLoaiPhuCap; set => maLoaiPhuCap = value; }
        public string TenPhuCap { get => tenPhuCap; set => tenPhuCap = value; }
        public float SoTien { get => soTien; set => soTien = value; }
    }
}
