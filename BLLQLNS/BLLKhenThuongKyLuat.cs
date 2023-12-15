using DALQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLQLNS
{
    public class BLLKhenThuongKyLuat
    {
        readonly DALKhenThuongKyLuat dALKhenThuongKyLuat = new DALKhenThuongKyLuat();
        public List<DTOKhenThuongKyLuat> GetAllKhenThuongKyLuat()
        {
            return dALKhenThuongKyLuat.GetAllKhenThuongKyLuat();
        }
        public List<DTOKhenThuongKyLuat> TimKiemKhenThuongKyLuat(int maNV)
        {
            return dALKhenThuongKyLuat.TimKiemKhenThuongKyLuat(maNV);
        }
        public KhenThuongKyLuat GetKhenThuongKyLuat(int id)
        {
            return dALKhenThuongKyLuat.GetKhenThuongKyLuat(id);


        }
        public KhenThuongKyLuat Add(KhenThuongKyLuat ktkl)
        {

            return dALKhenThuongKyLuat.Add(ktkl);

        }
        public KhenThuongKyLuat Update(KhenThuongKyLuat ktkl)
        {
            return dALKhenThuongKyLuat.Update(ktkl);
        }
        public void Delete(int id)
        {
            dALKhenThuongKyLuat.Delete(id);
        }
    }
}
