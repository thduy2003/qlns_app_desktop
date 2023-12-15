using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALQLNS
{
    public class DALLoaiCa
    {
        QLNSEntities db = new QLNSEntities();
        public List<DTOLoaiCa> GetAllLoaiCa()
        {

            var listLoaiCa = from pb in db.LoaiCas
                             select new DTOLoaiCa
                             {
                                 MaLoaiCa = pb.MaLoaiCa,
                                 TenLoaiCa = pb.TenLoaiCa,
                             };


            return listLoaiCa.ToList();
        }
    }
}
