using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALQLNS
{
    public class DALLuong
    {
        QLNSEntities db = new QLNSEntities();
        public List<DTOLuong> GetAllBangLuong()
        {
            var result = db.Luongs.Select(bc => new DTOLuong
            {
                MaLuong = bc.MaLuong,
                Nam = bc.Nam,
                Thang = (int)bc.Thang,
                TrangThai = bc.TrangThai
            }).ToList();

            return result;
        }
        public Luong GetBangLuong(int id)
        {
            return db.Luongs.FirstOrDefault(x => x.MaLuong == id);
        }
        public Luong Add(Luong l)
        {

            db.Luongs.Add(l);
            db.SaveChanges();
            return l;

        }
        public Luong Update(Luong l)
        {
            var _l = db.Luongs.FirstOrDefault(x => x.MaLuong == l.MaLuong);
            _l.Thang = l.Thang;
            _l.Nam = l.Nam;
            _l.TrangThai = l.TrangThai;
            db.SaveChanges();
            return l;
        }
        public void Delete(int id)
        {
            var _l = db.Luongs.FirstOrDefault(x => x.MaLuong == id);
            db.Luongs.Remove(_l);
            db.SaveChanges();
        }
        public List<DTOLuong> TimKiemBangLuong(int thang, string nam)
        {
            var result = db.Luongs.Where(x => x.Thang == thang && x.Nam == nam).Select(bc => new DTOLuong
            {
                MaLuong = bc.MaLuong,
                Nam = bc.Nam,
                Thang = (int)bc.Thang,
                TrangThai = bc.TrangThai
            }).ToList();

            return result;
        }

        public ChiTietLuong AddChiTietLuong(ChiTietLuong l)
        {

            db.ChiTietLuongs.Add(l);
            db.SaveChanges();
            return l;

        }
        public ChiTietLuong UpdateChiTietLuong(ChiTietLuong l)
        {
            var _l = db.ChiTietLuongs.FirstOrDefault(x => x.MaChiTietLuong == l.MaChiTietLuong);
            _l.ThucLanh = l.ThucLanh;
            db.SaveChanges();
            return l;
        }

        public List<DTOChiTietLuong> GetChiTietLuong(string nam, int thang, int maLuong)
        {
            DALBangChamCong bcc = new DALBangChamCong();
            var maChamCong = (from cc in db.BangChamCongs
                              where cc.Nam == nam && cc.Thang == thang
                              select cc.MaBangChamCong)
                 .FirstOrDefault();
            var bangChamCongChiTiet = bcc.TaoBangChamCongChiTiet(maChamCong);

            List<DTOChiTietLuong> bangChiTietLuong = new List<DTOChiTietLuong>(); // Khởi tạo một danh sách mới

            // Thêm tất cả nhân viên từ bangChamCongChiTiet vào bangChiTietLuong
            foreach (var chamCong in bangChamCongChiTiet)
            {
                bangChiTietLuong.Add(new DTOChiTietLuong
                {
                    MaNhanVien = chamCong.MaNV,
                    TenNhanVien = chamCong.HoTen,
                    MaLuong = maLuong,
                    ThucLanh = 0,
                    PhuCap = 0,
                    SoGioCong = 0,

                }); 
            }
            var phuCapGrouped = from bp in db.PhuCaps
                                join lp in db.LoaiPhuCaps on bp.MaLoaiPhuCap equals lp.MaLoaiPhuCap
                                group new { bp, lp } by bp.MaNhanVien into groupedPhuCap
                                select new
                                {
                                    MaNhanVien = groupedPhuCap.Key,
                                    TongPhuCap = groupedPhuCap.Sum(x => x.lp != null ? x.lp.SoTien : 0)
                                };
            // Thực hiện join và tính toán
            var result = from bctl in bangChiTietLuong
                         join hd in db.HopDongs on bctl.MaNhanVien equals hd.MaNhanVien into hdGroup
                         from hd in hdGroup.DefaultIfEmpty()
                         join bc in bangChamCongChiTiet on bctl.MaNhanVien equals bc.MaNV into bcGroup
                         from bc in bcGroup.DefaultIfEmpty()
                         join pc in phuCapGrouped on bctl.MaNhanVien equals pc.MaNhanVien into pcGroup
                         from pc in pcGroup.DefaultIfEmpty()
                         select new DTOChiTietLuong
                         {
                             MaNhanVien = bctl.MaNhanVien,
                             SoGioCong = bc != null ? bcc.TinhTongGioCong(bc) : 0,
                             ThucLanh = hd != null ? (float)(hd.HeSoLuong * hd.LuongCoBan * (bc != null ? bcc.TinhTongGioCong(bc) : 0)) + (pc != null ? (float)pc.TongPhuCap : 0) : 0,
                             PhuCap = pc != null ? (float)pc.TongPhuCap : 0
                         };

            foreach (var item in result)
            {
                var existingRecord = bangChiTietLuong.FirstOrDefault(x => x.MaNhanVien == item.MaNhanVien && x.MaLuong == maLuong);
                if (existingRecord != null)
                {
                    existingRecord.SoGioCong = item.SoGioCong;
                    existingRecord.ThucLanh = item.ThucLanh;
                    existingRecord.PhuCap = item.PhuCap;
                }
                var existInDb = db.ChiTietLuongs.FirstOrDefault(x => x.MaNhanVien == item.MaNhanVien && x.MaLuong == maLuong);
                if(existInDb != null)
                {
                      existInDb.ThucLanh = item.ThucLanh;
                    try
                    {
                        var updated = UpdateChiTietLuong(existInDb);
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err);
                    }
                } else
                {
                        ChiTietLuong ctl = new ChiTietLuong();
                        ctl.MaLuong = maLuong;
                        ctl.MaNhanVien = item.MaNhanVien;
                        ctl.ThucLanh = item.ThucLanh;
                    try {
                        var added = AddChiTietLuong(ctl);
                    }
                    catch (Exception err) {
                        Console.WriteLine(err);  
                    }
                }


            }
            return bangChiTietLuong.ToList();
        }
    }
}
