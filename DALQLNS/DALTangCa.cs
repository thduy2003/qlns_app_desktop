using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALQLNS
{
    public class DALTangCa
    {
        QLNSEntities db = new QLNSEntities();
        public List<DTOTangCa> GetAllTangCa()
        {

            var list = from pb in db.TangCas
                       join nv in db.NhanViens on pb.MaNhanVien equals nv.MaNhanVien
                             select new DTOTangCa
                             {
                                 MaTangCa = pb.MaTangCa,
                                 TenNhanVien = nv.HoTen,
                                 Ngay = (DateTime)pb.Ngay,
                                 SoGio = (float)pb.SoGio
                             };

            return list.ToList();
        }
        public List<DTOTangCa> TimKiemTangCa(int maNV)
        {

            var list = from pb in db.TangCas
                       join nv in db.NhanViens on pb.MaNhanVien equals nv.MaNhanVien
                       where pb.MaNhanVien == maNV
                       select new DTOTangCa
                       {
                           MaTangCa = pb.MaTangCa,
                           TenNhanVien = nv.HoTen,
                           Ngay = (DateTime)pb.Ngay,
                           SoGio = (float)pb.SoGio
                       };

            return list.ToList();
        }
        public TangCa GetTangCa(int id)
        {
            return db.TangCas.FirstOrDefault(x => x.MaTangCa == id);


        }
        public TangCa Add(TangCa tc)
        {

            db.TangCas.Add(tc);
            db.SaveChanges();
            return tc;

        }
        public TangCa Update(TangCa tc)
        {
            var _tc = db.TangCas.FirstOrDefault(x => x.MaTangCa == tc.MaTangCa);
            _tc.MaNhanVien = tc.MaNhanVien;
            _tc.Ngay = tc.Ngay;
            _tc.SoGio = tc.SoGio;
            db.SaveChanges();
            return tc;
        }
        public void Delete(int id)
        {
            var _tc = db.TangCas.FirstOrDefault(x => x.MaTangCa == id);
            db.TangCas.Remove(_tc);
            db.SaveChanges();
        }
    }
}
