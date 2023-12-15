using DALQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLQLNS
{
    public class BLLPhongBan
    {
       readonly DALPhongBan dALPhongBan = new DALPhongBan(); 
        public List<DTOPhongBan> GetAllPhongBan()
        {
            return dALPhongBan.GetAllPhongBan();
        }
    }
}
