using DALQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLQLNS
{
    public class BLLLoaiCa
    {
        readonly DALLoaiCa dALLoaiCa = new DALLoaiCa();
        public List<DTOLoaiCa> GetAllLoaiCa()
        {

            return dALLoaiCa.GetAllLoaiCa();
        }
    }
}
