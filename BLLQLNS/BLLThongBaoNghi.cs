using DALQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLQLNS
{
    public class BLLThongBaoNghi
    {
        readonly DALThongBaoNghi dALThongBaoNghi = new DALThongBaoNghi();
        public List<DTOThongBaoNghi> GetAllThongBaoNghi()
        {

            return dALThongBaoNghi.GetAllThongBaoNghi();
        }
        public ThongBaoNghi GetThongBao(int id)
        {
            return dALThongBaoNghi.GetThongBao(id);


        }
        public List<DTOThongBaoNghi> TimKiemThongBao(int thang, string nam)
        {
            return dALThongBaoNghi.TimKiemThongBao(thang, nam);
        }
        public ThongBaoNghi Add(ThongBaoNghi tc)
        {

            return dALThongBaoNghi.Add(tc);

        }
        public ThongBaoNghi Update(ThongBaoNghi tc)
        {
            return dALThongBaoNghi.Update(tc);
        }
        public void Delete(int id)
        {
            dALThongBaoNghi.Delete(id);
        }
    }
}
