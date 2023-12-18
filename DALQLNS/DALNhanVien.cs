using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALQLNS
{
    public class DALNhanVien
    {
        QLNSEntities db = new QLNSEntities();
        public List<DTONhanVien> GetAllNhanVien()
        {
            var kq = from nv in db.NhanViens.Where(x => x.DaThoiViec == 0)
                     join pb in db.PhongBans
                       on nv.MaPhongBan equals pb.MaPhongBan
                     join cv in db.ChucVus
                      on nv.MaChucVu equals cv.MaChucVu
                     select new DTONhanVien
                     {
                         MaNhanVien = nv.MaNhanVien,
                         HoTen = nv.HoTen,
                         HinhAnh = nv.HinhAnh,
                         GioiTinh = nv.GioiTinh,
                         DiaChi = nv.DiaChi,
                         SDT = nv.SDT,
                         Email = nv.Email,
                         CCCD = nv.CCCD,
                         PhongBan = pb.TenPhongBan,
                         ChucVu = cv.TenChucVu
                     };
            return kq.ToList();
        }
        public List<DTONhanVien> TimKiemNhanVien(int maNV, int maPB)
        {
            var kq = from nv in db.NhanViens.Where(x => x.DaThoiViec == 0)
                     join pb in db.PhongBans
                     on nv.MaPhongBan equals pb.MaPhongBan
                     join cv in db.ChucVus
                      on nv.MaChucVu equals cv.MaChucVu
                     where (maNV == -1 || nv.MaNhanVien == maNV)
                        && (maPB == -1 || nv.MaPhongBan == maPB)
                     select new DTONhanVien
                     {
                         MaNhanVien = nv.MaNhanVien,
                         HoTen = nv.HoTen,
                         HinhAnh = nv.HinhAnh,
                         GioiTinh = nv.GioiTinh,
                         DiaChi = nv.DiaChi,
                         SDT = nv.SDT,
                         Email = nv.Email,
                         CCCD = nv.CCCD,
                         PhongBan = pb.TenPhongBan,
                         ChucVu = cv.TenChucVu
                     };
            return kq.ToList();
        }
        public NhanVien GetNhanVien(int id)
        {
            return db.NhanViens.FirstOrDefault(x => x.MaNhanVien == id);


        }
        public NhanVien Add(NhanVien nv)
        {

            db.NhanViens.Add(nv);
            db.SaveChanges();
            return nv;

        }
        public NhanVien Update(NhanVien nv)
        {
            var _nv = db.NhanViens.FirstOrDefault(x => x.MaNhanVien == nv.MaNhanVien);
            _nv.HoTen = nv.HoTen;
            _nv.GioiTinh = nv.GioiTinh;
            _nv.CCCD = nv.CCCD;
            _nv.DiaChi = nv.DiaChi;
            _nv.SDT = nv.SDT;
            _nv.MaPhongBan = nv.MaPhongBan;
            _nv.MaChucVu = nv.MaChucVu;
            _nv.HinhAnh = nv.HinhAnh;
            db.SaveChanges();
            return nv;
        }
        public void Delete(int id)
        {
            var _nv = db.NhanViens.FirstOrDefault(x => x.MaNhanVien == id);
            _nv.DaThoiViec = 1;
            db.SaveChanges();
        }
    }
}
