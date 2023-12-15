using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALQLNS
{
    public class DALPhongBan
    {
        QLNSEntities db = new QLNSEntities();
        public List<DTOPhongBan> GetAllPhongBan()
        {

            var listPhongBan = from pb in db.PhongBans
                               select new DTOPhongBan
                               {
                                   MaPhongBan = pb.MaPhongBan,
                                   TenPhongBan = pb.TenPhongBan
                               };


            return listPhongBan.ToList();
        }
    }
}
