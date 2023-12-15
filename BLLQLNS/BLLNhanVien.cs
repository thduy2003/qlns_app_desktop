using DALQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLQLNS
{
    public class BLLNhanVien
    {

        readonly DALNhanVien dALNhanVien = new DALNhanVien();
        public List<DTONhanVien> GetAllNhanVien()
        {
            return dALNhanVien.GetAllNhanVien();
        }
        public List<DTONhanVien> TimKiemNhanVien(int maNV, int maPB)
        {
            return dALNhanVien.TimKiemNhanVien(maNV, maPB);
        }
        public NhanVien GetNhanVien(int id)
        {
            return dALNhanVien.GetNhanVien(id);


        }
        public NhanVien Add(NhanVien nv)
        {

            return dALNhanVien.Add(nv);

        }
        public NhanVien Update(NhanVien nv)
        {
            return dALNhanVien.Update(nv);
        }
        public void Delete(int id)
        {
            dALNhanVien.Delete(id);
        }
    }
}
