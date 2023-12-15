using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALQLNS
{
    public class DALAccount
    {
        QLNSEntities db = new QLNSEntities();
        public NhanVien ValidateAccount(string email, string password)
        {
            var query = from tk in db.TaiKhoans
                        join nv in db.NhanViens on tk.MaNhanVien equals nv.MaNhanVien
                        where tk.Email == email && tk.Password == password
                        select nv;

            var nhanVien = query.SingleOrDefault();
            return nhanVien;
        }
        public bool KiemTraAdmin(int maNhanVien)
        {
            // Kiểm tra xem có bản ghi nào trong bảng TaiKhoan có LaAdmin = 1 và MaNhanVien trùng khớp không
            var ketQua = from tk in db.TaiKhoans
                         where tk.MaNhanVien == maNhanVien && tk.LaAdmin == 1
                         select tk;

            // Nếu có ít nhất một bản ghi thỏa mãn điều kiện, coi nhân viên là admin
            return ketQua.Any();
        }
        public bool CheckEmailTonTai(string email)
        {
            return db.TaiKhoans.Any(x => x.Email == email);
        }
        public void DoiMatKhau(string email, string newPass)
        {
            var tk = db.TaiKhoans.SingleOrDefault(x => x.Email == email);
            tk.Password = newPass;
            db.SaveChanges();
        }
        public TaiKhoan ThemTaiKhoan(string email, int maNV)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.Email = email;
            tk.Password = "123123";
            tk.LaAdmin = 0;
            tk.MaNhanVien = maNV;
            db.TaiKhoans.Add(tk);
            db.SaveChanges();
            return tk;
        }
    }
}
