using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALQLNS
{
    public class DALBangChamCong
    {
        QLNSEntities db = new QLNSEntities();
        public List<DTOBangChamCong> GetAllBangChamCong()
        {
            var result = db.BangChamCongs.Select(bc => new DTOBangChamCong
            {
                MaBangChamCong = bc.MaBangChamCong,
                Nam = bc.Nam,
                Thang = bc.Thang,
                TrangThai = bc.TrangThai
          
            }).ToList();

            return result;
        }
        public List<DTOBangChamCong> TimKiemBangChamCong(int thang, string nam)
        {
            var result = db.BangChamCongs.Where(x => x.Thang == thang && x.Nam == nam).Select(bc => new DTOBangChamCong
            {
                MaBangChamCong = bc.MaBangChamCong,
                Nam = bc.Nam,
                Thang = bc.Thang,
                TrangThai = bc.TrangThai

            }).ToList();

            return result;
        }
        public BangChamCong GetBangChamCong(int id)
        {
            return db.BangChamCongs.FirstOrDefault(x => x.MaBangChamCong == id);


        }
        public string GetThuFromNgay(DateTime ngay)
        {
            var kq = (from dlcc in db.DuLieuChamCongs
                      where dlcc.Ngay == ngay
                      select dlcc.Thu).FirstOrDefault();
            return kq.ToString();
        }
        public List<DTODuLieuChamCong> GetChiTietBCC(int idNV, string thu, DateTime ngay)
        {
            var result = from dlcc in db.DuLieuChamCongs.Where(x => x.MaNhanVien == idNV && x.Thu == thu && x.Ngay == ngay)
                         join nv in db.NhanViens on dlcc.MaNhanVien equals nv.MaNhanVien
                         join lc in db.LoaiCas on dlcc.MaLoaiCa equals lc.MaLoaiCa
                         select new DTODuLieuChamCong
                         {
                             MaDuLieuChamCong = dlcc.MaDuLieuChamCong,
                             TenNhanVien = nv.HoTen,
                             Ca = lc.TenLoaiCa,
                             GioVao = dlcc.GioVao,
                             GioRa = dlcc.GioRa,
                             Thu = dlcc.Thu,
                             Ngay = (DateTime)dlcc.Ngay
                         };
            return result.ToList();
        }
        public BangChamCong Add(BangChamCong bcc)
        {

            db.BangChamCongs.Add(bcc);
            db.SaveChanges();
            return bcc;

        }
        public DuLieuChamCong AddDuLieu(DuLieuChamCong dlcc)
        {
            db.DuLieuChamCongs.Add(dlcc);
            db.SaveChanges();
            return dlcc;
        }
        public DuLieuChamCong GetDuLieu(int id)
        {
            return db.DuLieuChamCongs.FirstOrDefault(x => x.MaDuLieuChamCong == id);

        }
        public DuLieuChamCong UpdateDuLieu(DuLieuChamCong dlcc)
        {
            var _dlcc = db.DuLieuChamCongs.FirstOrDefault(x => x.MaDuLieuChamCong == dlcc.MaDuLieuChamCong);
            _dlcc.GioRa = dlcc.GioRa;
            _dlcc.GioVao = dlcc.GioVao;
            _dlcc.Thu = dlcc.Thu;
            _dlcc.MaNhanVien = dlcc.MaNhanVien;
            _dlcc.HoTen = dlcc.HoTen;
            _dlcc.Ngay = dlcc.Ngay;
            _dlcc.MaBangChamCong = dlcc.MaBangChamCong;
            _dlcc.MaLoaiCa = dlcc.MaLoaiCa;
            db.SaveChanges();
            return dlcc;
        }
        public void DeleteDuLieu(int id)
        {
            var _bcc = db.DuLieuChamCongs.FirstOrDefault(x => x.MaDuLieuChamCong == id);
            db.DuLieuChamCongs.Remove(_bcc);
            db.SaveChanges();
        }
        public BangChamCong Update(BangChamCong bcc)
        {
            var _bcc = db.BangChamCongs.FirstOrDefault(x => x.MaBangChamCong == bcc.MaBangChamCong);
            _bcc.Thang = bcc.Thang;
            _bcc.Nam = bcc.Nam;
            _bcc.TrangThai = bcc.TrangThai;
            db.SaveChanges();
            return bcc;
        }
        public void Delete(int id)
        {
            var _bcc = db.BangChamCongs.FirstOrDefault(x => x.MaBangChamCong == id);
            db.BangChamCongs.Remove(_bcc);
            db.SaveChanges();
        }


        public double TinhTongGioLam(DateTime gioVao, DateTime gioRa, DateTime gioBatDau, DateTime gioKetThuc)
        {
            // Xác định thời gian vào và ra trong ngày làm việc
            DateTime thoiGianVao = gioVao < gioBatDau ? gioBatDau : gioVao;
            DateTime thoiGianRa = gioRa > gioKetThuc ? gioKetThuc : gioRa;

            // Xác định thời gian làm việc trong khoảng thời gian vào và ra
            TimeSpan thoiGianLamViec = thoiGianRa - thoiGianVao;

            // Nếu thời gian vào lớn hơn hoặc bằng thời gian ra, hoặc làm việc ngoài giờ
            if (thoiGianVao >= thoiGianRa || thoiGianLamViec.TotalHours <= 0)
            {
                return 0; // Trả về 0 giờ nếu thời gian vào lớn hơn hoặc bằng thời gian ra hoặc làm việc ngoài giờ
            }
            // Trả về tổng số giờ làm việc
            return thoiGianLamViec.TotalHours;
        }
        public List<DTOBangChamCongChiTiet> TaoBangChamCongChiTiet(int maBangChamCong)
        {
            List<DTOBangChamCongChiTiet> danhSachChamCong = new List<DTOBangChamCongChiTiet>();



            var duLieuChamCong = from dlcc in db.DuLieuChamCongs
                                 join llv in db.LichLamViecs on dlcc.MaNhanVien equals llv.MaNhanVien
                                 join lc in db.LoaiCas on llv.MaLoaiCa equals lc.MaLoaiCa
                                 where llv.Thu == dlcc.Thu && dlcc.MaLoaiCa == llv.MaLoaiCa && dlcc.MaBangChamCong == maBangChamCong
                                 select new
                                 {
                                     dlcc.MaNhanVien,
                                     dlcc.HoTen,
                                     dlcc.Ngay,
                                     dlcc.Thu,
                                     dlcc.GioVao,
                                     dlcc.GioRa,
                                     lc.GioBatDau,
                                     lc.GioKetThuc
                                 };
          
                               
            // Xử lý dữ liệu và tạo danh sách DTO
            foreach (var chamCong in duLieuChamCong)
            {
                var nhanVienDTO = danhSachChamCong.FirstOrDefault(x => x.MaNV == chamCong.MaNhanVien);

                if (nhanVienDTO == null)
                {
                    // Nếu nhân viên chưa tồn tại trong danh sách, thêm mới
                    nhanVienDTO = new DTOBangChamCongChiTiet
                    {
                        MaNV = chamCong.MaNhanVien,
                        HoTen = chamCong.HoTen,
                    };

                    // Set default values for Ngay properties
                    for (int i = 1; i <= 31; i++)
                    {
                        nhanVienDTO.GetType().GetProperty($"Ngay{i}")?.SetValue(nhanVienDTO, 0);
                    }

                    danhSachChamCong.Add(nhanVienDTO);
                }

                // Lấy ngày trong tháng từ DateTime
                int ngayTrongThang = chamCong.Ngay != null ? chamCong.Ngay.Value.Day : -1;

                string[] ngayProperties = new string[]
                    {
                        "Ngay1", "Ngay2", "Ngay3", "Ngay4", "Ngay5",
                        "Ngay6", "Ngay7", "Ngay8", "Ngay9", "Ngay10",
                        "Ngay11", "Ngay12", "Ngay13", "Ngay14", "Ngay15",
                        "Ngay16", "Ngay17", "Ngay18", "Ngay19", "Ngay20",
                        "Ngay21", "Ngay22", "Ngay23", "Ngay24", "Ngay25",
                        "Ngay26", "Ngay27", "Ngay28", "Ngay29", "Ngay30", "Ngay31"
                    };

                // Parse the strings to DateTime objects with a fixed date
                DateTime gioRa = DateTime.ParseExact(chamCong.GioRa, "HH:mm", CultureInfo.InvariantCulture);
                DateTime gioVao = DateTime.ParseExact(chamCong.GioVao, "HH:mm", CultureInfo.InvariantCulture);

                DateTime gioBatDau = DateTime.ParseExact(chamCong.GioBatDau, "HH:mm", CultureInfo.InvariantCulture);
                DateTime gioKetThuc = DateTime.ParseExact(chamCong.GioKetThuc, "HH:mm", CultureInfo.InvariantCulture);
                // Tính số giờ làm việc trong khoảng thời gian giữa gioVao và gioRa
                double tongGioLam = TinhTongGioLam(gioVao, gioRa, gioBatDau, gioKetThuc);

                // Cộng số giờ làm việc vào thuộc tính NgayX tương ứng với ngày trong tháng
                if (ngayTrongThang > 0 && ngayTrongThang <= 31)
                {
                    double tongGioLamTruocDo = Convert.ToDouble(nhanVienDTO.GetType().GetProperty(ngayProperties[ngayTrongThang - 1])?.GetValue(nhanVienDTO));

                    // Cộng giá trị cũ và giá trị mới
                    nhanVienDTO.GetType().GetProperty(ngayProperties[ngayTrongThang - 1])?.SetValue(nhanVienDTO, tongGioLam + tongGioLamTruocDo);
                }
               


            }
           
            if(danhSachChamCong.FirstOrDefault() != null)
            {
                // cập nhật tăng ca vô chấm công

                /// lấy tăng ca của đúng tháng với năm đó thôi nha
                var tangCaData = from tc in db.TangCas.Where(x => x.Ngay.Value.Month == duLieuChamCong.FirstOrDefault().Ngay.Value.Month && x.Ngay.Value.Year == duLieuChamCong.FirstOrDefault().Ngay.Value.Year)
                                 select new
                                 {
                                     tc.MaNhanVien,
                                     tc.Ngay,
                                     tc.SoGio
                                 };
                
                foreach (var tangCa in tangCaData)
                {
                    var nv = danhSachChamCong.FirstOrDefault(x => x.MaNV == tangCa.MaNhanVien);

                    if (nv != null)
                    {
                        // Lấy ngày trong tháng từ DateTime
                        int ngayTangCa = tangCa.Ngay != null ? tangCa.Ngay.Value.Day : -1;

                        if (ngayTangCa > 0 && ngayTangCa <= 31)
                        {
                            double tongGioLamTruocDo = Convert.ToDouble(nv.GetType().GetProperty($"Ngay{ngayTangCa}")?.GetValue(nv));

                            // Cộng thêm số giờ tăng ca vào ngày tương ứng trong tháng
                            nv.GetType().GetProperty($"Ngay{ngayTangCa}")?.SetValue(nv, tangCa.SoGio + tongGioLamTruocDo);

                        }
                    }
                }
                //cập nhập công ngày nghỉ vô chấm công
                var ngayNghiData = from nn in db.DonNghiPheps.Where(x => x.NgayNghi.Value.Month == duLieuChamCong.FirstOrDefault().Ngay.Value.Month && x.NgayNghi.Value.Year == duLieuChamCong.FirstOrDefault().Ngay.Value.Year)
                                   join llv in db.LichLamViecs on nn.Thu equals llv.Thu
                                   join lc in db.LoaiCas on llv.MaLoaiCa equals lc.MaLoaiCa
                                   where nn.MaNhanVien == llv.MaNhanVien
                                   select new
                                   {
                                       nn.NgayNghi,
                                       nn.MaNhanVien,
                                       lc.GioBatDau,
                                       lc.GioKetThuc
                                   };
                foreach (var data in ngayNghiData)
                {
                    var nv = danhSachChamCong.FirstOrDefault(x => x.MaNV == data.MaNhanVien);

                    if (nv != null)
                    {
                        // Lấy ngày trong tháng từ DateTime
                        int ngayNghi = data.NgayNghi != null ? data.NgayNghi.Value.Day : -1;

                        if (ngayNghi > 0 && ngayNghi <= 31)
                        {
                            DateTime gioBatDau = DateTime.ParseExact(data.GioBatDau, "HH:mm", CultureInfo.InvariantCulture);
                            DateTime gioKetThuc = DateTime.ParseExact(data.GioKetThuc, "HH:mm", CultureInfo.InvariantCulture);
                            double tongGioLamTruocDo = Convert.ToDouble(nv.GetType().GetProperty($"Ngay{ngayNghi}")?.GetValue(nv));
                            // Cộng thêm số giờ tăng ca vào ngày tương ứng trong tháng
                            nv.GetType().GetProperty($"Ngay{ngayNghi}")?.SetValue(nv, (gioKetThuc - gioBatDau).TotalHours + tongGioLamTruocDo);
                        }
                    }
                }
               
            }
            return danhSachChamCong;
        }

 
        public float TinhTongGioCong(DTOBangChamCongChiTiet bc)
        {
            var gioCongProperties = typeof(DTOBangChamCongChiTiet).GetProperties()
               .Where(p => p.Name.StartsWith("Ngay"))
               .Select(p => Convert.ToSingle(p.GetValue(bc, null)));

            return gioCongProperties.Sum();
        }


    }
}
