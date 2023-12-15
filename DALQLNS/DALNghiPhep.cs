using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALQLNS
{
    public class DALNghiPhep
    {
        QLNSEntities db = new QLNSEntities();
        public List<DTOLoaiPhep> GetAllLoaiPhep()
        {

            var list = from lp in db.LoaiPheps
                             select new DTOLoaiPhep
                             {
                                MaLoaiNghiPhep = lp.MaLoaiNghiPhep,
                                TenLoaiNghiPhep = lp.TenLoaiNghiPhep

                             };
            return list.ToList();
        }
        public List<DTODonNghiPhep> GetAllDonNghiPhepOfNV (int idNV)
        {
            var list = from dnp in db.DonNghiPheps.Where(x => x.MaNhanVien == idNV)
                       join lp in db.LoaiPheps on dnp.MaLoaiNghiPhep equals lp.MaLoaiNghiPhep
                       join nv in db.NhanViens on dnp.MaNhanVien equals nv.MaNhanVien
                       select new DTODonNghiPhep
                       {
                           MaDonNghiPhep = dnp.MaDonNghiPhep,
                           TenLoaiNghiPhep = lp.TenLoaiNghiPhep,
                           TenNhanVien = nv.HoTen,
                           NgayNopDon = (DateTime)dnp.NgayNopDon,
                           NgayNghi = (DateTime)dnp.NgayNghi,
                           LyDo = dnp.LyDo,
                           TrangThai = (int)dnp.TrangThai   //0: chờ duyệt, 1: từ chối, 2: đã duyệt
                       };
            return list.ToList();
        }
        public DonNghiPhep GetDonNghi(int id)
        {
            return db.DonNghiPheps.FirstOrDefault(x => x.MaDonNghiPhep == id);
        }
        public List<DTODonNghiPhep> GetAllDonNghiPhep()
        {
            var list = from dnp in db.DonNghiPheps
                       join lp in db.LoaiPheps on dnp.MaLoaiNghiPhep equals lp.MaLoaiNghiPhep
                       join nv in db.NhanViens on dnp.MaNhanVien equals nv.MaNhanVien
                       select new DTODonNghiPhep
                       {
                           MaDonNghiPhep = dnp.MaDonNghiPhep,
                           TenLoaiNghiPhep = lp.TenLoaiNghiPhep,
                           TenNhanVien = nv.HoTen,
                           NgayNopDon = (DateTime)dnp.NgayNopDon,
                           NgayNghi = (DateTime)dnp.NgayNghi,
                           LyDo = dnp.LyDo,
                           TrangThai = (int)dnp.TrangThai   //0: chờ duyệt, 1: từ chối, 2: đã duyệt
                       };
            return list.ToList();
        }
        public List<DTODonNghiPhep> TimKiemNghiPhep(int maNV, int trangThai)
        {
            var list = from dnp in db.DonNghiPheps
                       join lp in db.LoaiPheps on dnp.MaLoaiNghiPhep equals lp.MaLoaiNghiPhep
                       join nv in db.NhanViens on dnp.MaNhanVien equals nv.MaNhanVien
                       where (maNV == -1 || dnp.MaNhanVien == maNV)
                        && (trangThai == -1 || dnp.TrangThai == trangThai)
                       select new DTODonNghiPhep
                       {
                           MaDonNghiPhep = dnp.MaDonNghiPhep,
                           TenLoaiNghiPhep = lp.TenLoaiNghiPhep,
                           TenNhanVien = nv.HoTen,
                           NgayNopDon = (DateTime)dnp.NgayNopDon,
                           NgayNghi = (DateTime)dnp.NgayNghi,
                           LyDo = dnp.LyDo,
                           TrangThai = (int)dnp.TrangThai   //0: chờ duyệt, 1: từ chối, 2: đã duyệt
                       };
            return list.ToList();
        }
        public DonNghiPhep AddDon(DonNghiPhep dnp)
        {
            db.DonNghiPheps.Add(dnp);
            db.SaveChanges();
            return dnp;
        }
        public DonNghiPhep UpdateDon (DonNghiPhep dnp)
        {
            var _dnp = db.DonNghiPheps.FirstOrDefault(x => x.MaDonNghiPhep == dnp.MaDonNghiPhep);
            _dnp.MaLoaiNghiPhep = dnp.MaLoaiNghiPhep;
            _dnp.NgayNopDon = dnp.NgayNopDon;
            _dnp.NgayNghi = dnp.NgayNghi;
            _dnp.LyDo = dnp.LyDo;
            db.SaveChanges();
            return dnp;
        }
        public void DeleteDon(int id)
        {
            var _dnp = db.DonNghiPheps.FirstOrDefault(x => x.MaDonNghiPhep == id);
            db.DonNghiPheps.Remove(_dnp);
            db.SaveChanges();
        }
        public void DuyetDonNghiPhep(int idDon)
        {
            var _dnp = db.DonNghiPheps.FirstOrDefault(x => x.MaDonNghiPhep == idDon);
            _dnp.TrangThai = 2;
            db.SaveChanges();
        }
        public void TuChoiDonNghiPhep(int idDon)
        {
            var _dnp = db.DonNghiPheps.FirstOrDefault(x => x.MaDonNghiPhep == idDon);
            _dnp.TrangThai = 1;
            db.SaveChanges();
        }
    }
}
