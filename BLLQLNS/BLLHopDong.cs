using DALQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLQLNS
{
    public class BLLHopDong
    {
        readonly DALHopDong dALHopDong = new DALHopDong();
        public List<DTOHopDong> GetAllHopDong()
        {
            return dALHopDong.GetAllHopDong();
        }
        public List<DTOHopDong> TimKiemHopDong(int maNV, string tenHopDong)
        {
            return dALHopDong.TimKiemHopDong(maNV, tenHopDong);
        }
        public HopDong GetHopDong(int id)
        {
            return dALHopDong.GetHopDong(id);
        }
        public HopDong Add(HopDong hd)
        {

            return dALHopDong.Add(hd);

        }
        public HopDong Update(HopDong hd)
        {
            return dALHopDong.Update(hd);
        }
        public void Delete(int id)
        {
            dALHopDong.Delete(id);
        }
    }
}
