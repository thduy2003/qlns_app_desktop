using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOQLNS
{
    public class DTOThongBaoNghi
    {
        private int maThongBao;
        private string tieuDe;
        private string noiDung;
        private DateTime tuNgay;
        private DateTime denNgay;
        private int thang;
        private string nam;
        private int maBangChamCong;

        public int MaThongBao { get => maThongBao; set => maThongBao = value; }
        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public DateTime TuNgay { get => tuNgay; set => tuNgay = value; }
        public DateTime DenNgay { get => denNgay; set => denNgay = value; }
        public int Thang { get => thang; set => thang = value; }
        public string Nam { get => nam; set => nam = value; }

        public int MaBangChamCong { get => maBangChamCong; set => maBangChamCong = value; }
    }
}
