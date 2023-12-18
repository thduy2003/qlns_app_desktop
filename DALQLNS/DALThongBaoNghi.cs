using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALQLNS
{
    public class DALThongBaoNghi
    {
        QLNSEntities db = new QLNSEntities();
        public List<DTOThongBaoNghi> GetAllThongBaoNghi()
        {

            var list = from tbn in db.ThongBaoNghis
                       join bcc in db.BangChamCongs on tbn.MaBangChamCong equals bcc.MaBangChamCong
                       select new DTOThongBaoNghi
                       {
                           MaThongBao = tbn.MaThongBao,
                           TieuDe = tbn.TieuDe,
                           NoiDung = tbn.NoiDung,
                           TuNgay = (DateTime)tbn.TuNgay,
                           DenNgay = (DateTime)tbn.DenNgay,
                           Nam = bcc.Nam,
                           Thang = (int)bcc.Thang,
                           MaBangChamCong = bcc.MaBangChamCong,
                       };

            return list.ToList();
        }
        public List<DTOThongBaoNghi> TimKiemThongBao(int thang, string nam)
        {

            var list = from tbn in db.ThongBaoNghis
                       join bcc in db.BangChamCongs on tbn.MaBangChamCong equals bcc.MaBangChamCong
                       where bcc.Thang == thang && bcc.Nam == nam
                       select new DTOThongBaoNghi
                       {
                           MaThongBao = tbn.MaThongBao,
                           TieuDe = tbn.TieuDe,
                           NoiDung = tbn.NoiDung,
                           TuNgay = (DateTime)tbn.TuNgay,
                           DenNgay = (DateTime)tbn.DenNgay,
                           Nam = bcc.Nam,
                           Thang = (int)bcc.Thang,
                           MaBangChamCong = bcc.MaBangChamCong,
                       };

            return list.ToList();
        }
        public ThongBaoNghi GetThongBao(int id)
        {
            return db.ThongBaoNghis.FirstOrDefault(x => x.MaThongBao == id);


        }
        public ThongBaoNghi Add(ThongBaoNghi tc)
        {

            db.ThongBaoNghis.Add(tc);
            db.SaveChanges();
            return tc;

        }
        public ThongBaoNghi Update(ThongBaoNghi tc)
        {
            var _tc = db.ThongBaoNghis.FirstOrDefault(x => x.MaThongBao == tc.MaThongBao);
            _tc.TieuDe = tc.TieuDe;
            _tc.NoiDung = tc.NoiDung;
            _tc.TuNgay = tc.TuNgay;
            _tc.DenNgay = tc.DenNgay;
            db.SaveChanges();
            return tc;
        }
        public void Delete(int id)
        {
            var _tc = db.ThongBaoNghis.FirstOrDefault(x => x.MaThongBao == id);
            db.ThongBaoNghis.Remove(_tc);
            db.SaveChanges();
        }
    }
}
