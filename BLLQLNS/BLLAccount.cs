using DALQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLQLNS
{
    public class BLLAccount
    {
        readonly DALAccount dALAccount = new DALAccount();
        public NhanVien ValidateAccount(string email, string password)
        {
           return dALAccount.ValidateAccount(email, password);
        }
        public void DoiMatKhau(string email, string newPass)
        {
            dALAccount.DoiMatKhau(email, newPass);
        }
        public bool KiemTraAdmin(int maNhanVien)
        {
            return dALAccount.KiemTraAdmin(maNhanVien);
        }
        public bool CheckEmailTonTai(string email)
        {
            return dALAccount.CheckEmailTonTai(email);
        }
        public TaiKhoan ThemTaiKhoan(string email, int maNV)
        {
            return dALAccount.ThemTaiKhoan(email , maNV);   
        }
    }
}
