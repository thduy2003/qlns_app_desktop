using DALQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BLLQLNS
{
    public class BLLBangChamCong
    {
        readonly DALBangChamCong dALBangChamCong = new DALBangChamCong();
        public List<DTOBangChamCong> GetAllBangChamCong()
        {
            return dALBangChamCong.GetAllBangChamCong();
        }
        public BangChamCong GetBangChamCong(int id)
        {
            return dALBangChamCong.GetBangChamCong(id);


        }
        public List<DTOBangChamCong> TimKiemBangChamCong(int thang, string nam)
        {
            return dALBangChamCong.TimKiemBangChamCong(thang, nam);
        }
        public string GetThuFromNgay(DateTime ngay)
        {
            return dALBangChamCong.GetThuFromNgay(ngay);
        }
        public List<DTODuLieuChamCong> GetChiTietBCC(int idNV, string thu, DateTime ngay)
        {
            return dALBangChamCong.GetChiTietBCC(idNV, thu, ngay);
        }
        public DuLieuChamCong AddDuLieu(DuLieuChamCong dlcc)
        {
            return dALBangChamCong.AddDuLieu(dlcc);
        }
        public DuLieuChamCong GetDuLieu(int id)
        {
            return dALBangChamCong.GetDuLieu(id);

        }
        public DuLieuChamCong UpdateDuLieu(DuLieuChamCong dlcc)
        {
            return dALBangChamCong.UpdateDuLieu(dlcc);
        }
        public void DeleteDuLieu(int id)
        {
            dALBangChamCong.DeleteDuLieu(id);
        }
        public BangChamCong Add(BangChamCong bcc)
        {

            return dALBangChamCong.Add(bcc);

        }
        public BangChamCong Update(BangChamCong bcc)
        {
            return dALBangChamCong.Update(bcc);
        }
        public void Delete(int id)
        {
            dALBangChamCong.Delete(id);
        }


       
        public List<DTOBangChamCongChiTiet> TaoBangChamCongChiTiet(int maBangChamCong)
        {
            return dALBangChamCong.TaoBangChamCongChiTiet(maBangChamCong);
        }

        
    }
}
