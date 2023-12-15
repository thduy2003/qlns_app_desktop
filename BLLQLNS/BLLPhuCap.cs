using DALQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLQLNS
{
    public class BLLPhuCap
    {
        readonly DALPhuCap dALPhuCap = new DALPhuCap();
        public List<DTOLoaiPhuCap> GetAllLoaiPhuCap()
        {
            return dALPhuCap.GetAllLoaiPhuCap();
        }
        public List<DTOPhuCap> GetAllPhuCap()
        {
            return dALPhuCap.GetAllPhuCap();
        }
        public List<DTOPhuCap> TimKiemPhuCap(int maNV, int maPhuCap)
        {
            return dALPhuCap.TimKiemPhuCap(maNV, maPhuCap);
        }
        public PhuCap GetPhuCap(int id)
        {
            return dALPhuCap.GetPhuCap(id);


        }
        public PhuCap Add(PhuCap pc)
        {

            return dALPhuCap.Add(pc);

        }
        public PhuCap Update(PhuCap pc)
        {
            return dALPhuCap.Update(pc);
        }
        public void Delete(int id)
        {
            dALPhuCap.Delete(id);
        }
    }
}
