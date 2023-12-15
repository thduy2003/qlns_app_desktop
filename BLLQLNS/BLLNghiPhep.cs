using DALQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLQLNS
{
    public class BLLNghiPhep
    {
        readonly DALNghiPhep dALNghiPhep = new DALNghiPhep();
        public List<DTOLoaiPhep> GetAllLoaiPhep()
        {
            return dALNghiPhep.GetAllLoaiPhep();
        }
        public List<DTODonNghiPhep> GetAllDonNghiPhepOfNV(int idNV)
        {
            return dALNghiPhep.GetAllDonNghiPhepOfNV(idNV);
        }
        public DonNghiPhep GetDonNghi(int id)
        {
            return dALNghiPhep.GetDonNghi(id);
        }
        public List<DTODonNghiPhep> GetAllDonNghiPhep()
        {
            return dALNghiPhep.GetAllDonNghiPhep();
        }
        public List<DTODonNghiPhep> TimKiemNghiPhep(int maNV, int trangThai)
        {
            return dALNghiPhep.TimKiemNghiPhep(maNV, trangThai);
        }
        public DonNghiPhep AddDon(DonNghiPhep dnp)
        {
            return dALNghiPhep.AddDon(dnp);
        }
        public DonNghiPhep UpdateDon(DonNghiPhep dnp)
        {
            return dALNghiPhep.UpdateDon(dnp);
        }
        public void DeleteDon(int id)
        {
            dALNghiPhep.DeleteDon(id);   
        }
        public void DuyetDonNghiPhep(int idDon)
        {
            dALNghiPhep.DuyetDonNghiPhep(idDon);
        }
        public void TuChoiDonNghiPhep(int idDon)
        {
            dALNghiPhep.TuChoiDonNghiPhep(idDon);
        }
    }
}
