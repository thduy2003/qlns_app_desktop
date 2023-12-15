using DALQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLQLNS
{
    public class BLLChucVu
    {

        readonly DALChucVu dALChucVu = new DALChucVu();
        public List<DTOChucVu> GetAllChucVu()
        {

            return dALChucVu.GetAllChucVu();
        }
    }
}
