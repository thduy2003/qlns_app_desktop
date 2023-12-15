using DALQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLQLNS
{
    public class BLLLuong
    {
        readonly DALLuong dALLuong = new DALLuong();
        public List<DTOLuong> GetAllBangLuong()
        {
            return dALLuong.GetAllBangLuong();
        }
        public Luong GetBangLuong(int id)
        {
            return dALLuong.GetBangLuong(id);


        }
        public List<DTOChiTietLuong> GetChiTietLuong(string nam, int thang, int maLuong)
        {

            return dALLuong.GetChiTietLuong(nam, thang, maLuong);
        }
        public List<DTOLuong> TimKiemBangLuong(int thang, string nam)
        {
            return dALLuong.TimKiemBangLuong(thang, nam);
        }
        public Luong Add(Luong l)
        {

            return dALLuong.Add(l);

        }
        public Luong Update(Luong l)
        {
            return dALLuong.Update(l);
        }
        public void Delete(int id)
        {
            dALLuong.Delete(id);
        }
    }
}
