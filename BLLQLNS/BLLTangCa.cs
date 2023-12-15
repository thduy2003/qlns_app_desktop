using DALQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLQLNS
{
    public class BLLTangCa
    {
        readonly DALTangCa dALTangCa = new DALTangCa();
        public List<DTOTangCa> GetAllTangCa()
        {

            return dALTangCa.GetAllTangCa();
        }
        public List<DTOTangCa> TimKiemTangCa(int maNV)
        {
            return dALTangCa.TimKiemTangCa(maNV);
        }
        public TangCa GetTangCa(int id)
        {
            return dALTangCa.GetTangCa(id);


        }
        public TangCa Add(TangCa tc)
        {

           return dALTangCa.Add(tc);

        }
        public TangCa Update(TangCa tc)
        {
            return dALTangCa.Update(tc);
        }
        public void Delete(int id)
        {
            dALTangCa.Delete(id);
        }
    }
}
