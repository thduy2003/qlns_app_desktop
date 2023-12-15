using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALQLNS
{
    public class DALPhuCap
    {
        QLNSEntities db = new QLNSEntities();
        public List<DTOLoaiPhuCap> GetAllLoaiPhuCap()
        {
            var listPhongBan = from pc in db.LoaiPhuCaps
                               select new DTOLoaiPhuCap
                               {
                                   MaLoaiPhuCap = pc.MaLoaiPhuCap,
                                   TenPhuCap = pc.TenPhuCap,
                                   SoTien = (float)pc.SoTien
                               };


            return listPhongBan.ToList();
        }
        public List<DTOPhuCap> GetAllPhuCap()
        {
            var list = from pc in db.PhuCaps
                       join lpc in db.LoaiPhuCaps on pc.MaLoaiPhuCap equals lpc.MaLoaiPhuCap
                       join nv in db.NhanViens on pc.MaNhanVien equals nv.MaNhanVien
                       select new DTOPhuCap
                       {
                           MaPhuCap = pc.MaPhuCap,
                           NoiDung = pc.NoiDung,
                           TenNhanVien = nv.HoTen,
                           TenPhuCap = lpc.TenPhuCap
                       };
            return list.ToList();
        }
        public List<DTOPhuCap> TimKiemPhuCap(int maNV, int maPhuCap)
        {
            var list = from pc in db.PhuCaps
                       join lpc in db.LoaiPhuCaps on pc.MaLoaiPhuCap equals lpc.MaLoaiPhuCap
                       join nv in db.NhanViens on pc.MaNhanVien equals nv.MaNhanVien
                       where (maNV == -1 || pc.MaNhanVien == maNV)
                       && (maPhuCap == -1 || pc.MaLoaiPhuCap == maPhuCap)
                       select new DTOPhuCap
                       {
                           MaPhuCap = pc.MaPhuCap,
                           NoiDung = pc.NoiDung,
                           TenNhanVien = nv.HoTen,
                           TenPhuCap = lpc.TenPhuCap
                       };
            return list.ToList();
        }
        public PhuCap GetPhuCap(int id)
        {
            return db.PhuCaps.FirstOrDefault(x => x.MaPhuCap == id);


        }
        public PhuCap Add(PhuCap pc)
        {

            db.PhuCaps.Add(pc);
            db.SaveChanges();
            return pc;

        }
        public PhuCap Update(PhuCap pc)
        {
            var _pc = db.PhuCaps.FirstOrDefault(x => x.MaPhuCap == pc.MaPhuCap);
            _pc.MaLoaiPhuCap = pc.MaLoaiPhuCap;
            _pc.MaNhanVien = pc.MaNhanVien;
            _pc.NoiDung = pc.NoiDung;
            db.SaveChanges();
            return pc;
        }
        public void Delete(int id)
        {
            var _pc = db.PhuCaps.FirstOrDefault(x => x.MaPhuCap == id);
            db.PhuCaps.Remove(_pc);
            db.SaveChanges();
        }
    }
}
