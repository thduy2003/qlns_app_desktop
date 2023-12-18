using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DALQLNS
{
    public class DALHopDong
    {
        QLNSEntities db = new QLNSEntities();
        public List<DTOHopDong> GetAllHopDong()
        {
            var kq = from hd in db.HopDongs
                     join nv in db.NhanViens on hd.MaNhanVien equals nv.MaNhanVien
                   
                     select new DTOHopDong
                     {
                         MaHopDong = hd.MaHopDong,
                         TenNhanVien = nv.HoTen,
                         TenHopDong = hd.TenHopDong,
                         NgayBatDau = (DateTime)hd.NgayBatDau,
                         NgayKetThuc = (DateTime)hd.NgayKetThuc,
                         NgayKy = (DateTime)hd.NgayKy,
                         LanKy = (int)hd.LanKy,
                         HeSoLuong = (float)hd.HeSoLuong,
                         LuongCoBan = (float)hd.LuongCoBan,
                         NoiDung = hd.NoiDung,
                         ThoiHan = hd.ThoiHan
                     };
            return kq.ToList();
        }
        public List<DTOHopDong> TimKiemHopDong(int maNV, string tenHopDong)
        {
            var kq = from hd in db.HopDongs
                     join nv in db.NhanViens on hd.MaNhanVien equals nv.MaNhanVien
                     // nếu truyền lên -1 tức là true luôn bỏ qua lọc theo maNV để có thể tìm kiếm 1 trong 2 hoặc cả 2
                     where (maNV == -1 || hd.MaNhanVien == maNV)
                        && (string.IsNullOrEmpty(tenHopDong) || hd.TenHopDong.Contains(tenHopDong))
                     select new DTOHopDong
                     {
                         MaHopDong = hd.MaHopDong,
                         TenNhanVien = nv.HoTen,
                         TenHopDong = hd.TenHopDong,
                         NgayBatDau = (DateTime)hd.NgayBatDau,
                         NgayKetThuc = (DateTime)hd.NgayKetThuc,
                         NgayKy = (DateTime)hd.NgayKy,
                         LanKy = (int)hd.LanKy,
                         HeSoLuong = (float)hd.HeSoLuong,
                         LuongCoBan = (float)hd.LuongCoBan,
                         NoiDung = hd.NoiDung,
                         ThoiHan = hd.ThoiHan
                     };
            return kq.ToList();
        }
        public HopDong GetHopDong(int id)
        {
            return db.HopDongs.FirstOrDefault(x => x.MaHopDong == id);
        }
        public HopDong Add(HopDong hd)
        {

            db.HopDongs.Add(hd);
            db.SaveChanges();
            return hd;

        }
        public HopDong Update(HopDong hd)
        {
            var _hd = db.HopDongs.FirstOrDefault(x => x.MaHopDong == hd.MaHopDong);
            _hd.TenHopDong = hd.TenHopDong;
            _hd.NgayBatDau = hd.NgayBatDau;
            _hd.NgayKetThuc = hd.NgayKetThuc;
            _hd.MaNhanVien = hd.MaNhanVien;
            _hd.NgayKy = hd.NgayKy;
            _hd.LanKy = hd.LanKy;
            _hd.HeSoLuong = hd.HeSoLuong;
            _hd.LuongCoBan = hd.LuongCoBan;
            _hd.ThoiHan = hd.ThoiHan;
            _hd.NoiDung = hd.NoiDung;
            db.SaveChanges();
            return hd;
        }
        public void Delete(int id)
        {
            var _hd = db.HopDongs.FirstOrDefault(x => x.MaHopDong == id);
            db.HopDongs.Remove(_hd);
            db.SaveChanges();
        }
    }
}
