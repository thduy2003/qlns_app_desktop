using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALQLNS
{
    public class DALKhenThuongKyLuat
    {
        QLNSEntities db = new QLNSEntities();
        public List<DTOKhenThuongKyLuat> GetAllKhenThuongKyLuat()
        {
            var kq = from ktkl in db.KhenThuongKyLuats
                     join nv in db.NhanViens on ktkl.MaNhanVien equals nv.MaNhanVien

                     select new DTOKhenThuongKyLuat
                     {
                         MaKhenThuongKyLuat = ktkl.MaKhenThuongKyLuat,
                         TenNhanVien = nv.HoTen,
                         LyDo = ktkl.LyDo,
                         NoiDung = ktkl.NoiDung,
                         Ngay = (DateTime)ktkl.Ngay
                     };
            return kq.ToList();
        }
        public List<DTOKhenThuongKyLuat> TimKiemKhenThuongKyLuat(int maNV)
        {
            var kq = from ktkl in db.KhenThuongKyLuats
                     join nv in db.NhanViens on ktkl.MaNhanVien equals nv.MaNhanVien
                     where ktkl.MaNhanVien == maNV

                     select new DTOKhenThuongKyLuat
                     {
                         MaKhenThuongKyLuat = ktkl.MaKhenThuongKyLuat,
                         TenNhanVien = nv.HoTen,
                         LyDo = ktkl.LyDo,
                         NoiDung = ktkl.NoiDung,
                         Ngay = (DateTime)ktkl.Ngay
                     };
            return kq.ToList();
        }
        public KhenThuongKyLuat GetKhenThuongKyLuat(int id)
        {
            return db.KhenThuongKyLuats.FirstOrDefault(x => x.MaKhenThuongKyLuat == id);


        }
        public KhenThuongKyLuat Add(KhenThuongKyLuat ktkl)
        {

            db.KhenThuongKyLuats.Add(ktkl);
            db.SaveChanges();
            return ktkl;

        }
        public KhenThuongKyLuat Update(KhenThuongKyLuat ktkl)
        {
            var _ktkl = db.KhenThuongKyLuats.FirstOrDefault(x => x.MaKhenThuongKyLuat == ktkl.MaKhenThuongKyLuat);
            _ktkl.MaNhanVien = ktkl.MaNhanVien;
            _ktkl.LyDo = ktkl.LyDo;
            _ktkl.NoiDung = ktkl.NoiDung;
            _ktkl.Ngay = ktkl.Ngay;
            db.SaveChanges();
            return ktkl;
        }
        public void Delete(int id)
        {
            var _ktkl = db.KhenThuongKyLuats.FirstOrDefault(x => x.MaKhenThuongKyLuat == id);
            db.KhenThuongKyLuats.Remove(_ktkl);
            db.SaveChanges();
        }
    }
}
