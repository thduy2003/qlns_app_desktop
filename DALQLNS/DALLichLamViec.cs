using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALQLNS
{
    public class DALLichLamViec
    {
        QLNSEntities db = new QLNSEntities();
        public List<DTOLichLamViec> GetAllLichLamViec()
        {
            var kq = from llv in db.LichLamViecs
                     join nv in db.NhanViens on llv.MaNhanVien equals nv.MaNhanVien
                     join ca in db.LoaiCas on llv.MaLoaiCa equals ca.MaLoaiCa
                     select new DTOLichLamViec
                     {
                         MaLichLamViec = llv.MaLichLamViec,
                         Thu = llv.Thu,
                         Ca = ca.TenLoaiCa,
                         HoTenNV = nv.HoTen
                     };
            return kq.ToList();
        }
        public List<DTOLichLamViec> GetLichLamViecCuaNV(int maNV)
        {
            var kq = from llv in db.LichLamViecs
                     join nv in db.NhanViens on llv.MaNhanVien equals nv.MaNhanVien
                     join ca in db.LoaiCas on llv.MaLoaiCa equals ca.MaLoaiCa
                     where llv.MaNhanVien == maNV
                     select new DTOLichLamViec
                     {
                         MaLichLamViec = llv.MaLichLamViec,
                         Thu = llv.Thu,
                         Ca = ca.TenLoaiCa,
                         HoTenNV = nv.HoTen
                     };
            return kq.ToList();
        }
        public List<DTOLichLamViec> TimKiemLichLamViec(int maNV, int maLoaiCa)
        {
            var kq = from llv in db.LichLamViecs
                     join nv in db.NhanViens on llv.MaNhanVien equals nv.MaNhanVien
                     join ca in db.LoaiCas on llv.MaLoaiCa equals ca.MaLoaiCa
                     where (maNV == -1 || llv.MaNhanVien == maNV)
                       && (maLoaiCa == -1 || llv.MaLoaiCa == maLoaiCa)
                     select new DTOLichLamViec
                     {
                         MaLichLamViec = llv.MaLichLamViec,
                         Thu = llv.Thu,
                         Ca = ca.TenLoaiCa,
                         HoTenNV = nv.HoTen
                     };
            return kq.ToList();
        }
        public LichLamViec GetLichLamViec(int id)
        {
            return db.LichLamViecs.FirstOrDefault(x => x.MaLichLamViec == id);


        }
        public LichLamViec Add(LichLamViec llv)
        {

            db.LichLamViecs.Add(llv);
            db.SaveChanges();
            return llv;

        }
        public LichLamViec Update(LichLamViec llv)
        {
            var _llv = db.LichLamViecs.FirstOrDefault(x => x.MaLichLamViec == llv.MaLichLamViec);
            _llv.MaNhanVien = llv.MaNhanVien;
            _llv.MaLoaiCa = llv.MaLoaiCa;
            _llv.Thu = llv.Thu;
            db.SaveChanges();
            return llv;
        }
        public void Delete(int id)
        {
            var _llv = db.LichLamViecs.FirstOrDefault(x => x.MaLichLamViec == id);
            db.LichLamViecs.Remove(_llv);
            db.SaveChanges();
        }
    }
}
