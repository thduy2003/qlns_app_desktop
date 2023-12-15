using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALQLNS
{
    public class DALChucVu
    {
        QLNSEntities db = new QLNSEntities();
        public List<DTOChucVu> GetAllChucVu()
        {

            var listChucVu = from pb in db.ChucVus
                             select new DTOChucVu
                             {
                                 MaChucVu = pb.MaChucVu,
                                 TenChucVu = pb.TenChucVu
                             };


            return listChucVu.ToList();
        }
    }
}
