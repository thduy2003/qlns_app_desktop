using DALQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLQLNS
{
    public class BLLLichLamViec
    {
        readonly DALLichLamViec dALLichLamViec = new DALLichLamViec();
        public List<DTOLichLamViec> GetAllLichLamViec()
        {
            return dALLichLamViec.GetAllLichLamViec();
        }
        public List<DTOLichLamViec> GetLichLamViecCuaNV(int maNV)
        {
            return dALLichLamViec.GetLichLamViecCuaNV(maNV);
        }
        public List<DTOLichLamViec> TimKiemLichLamViec(int maNV, int maLoaiCa)
        {
            return dALLichLamViec.TimKiemLichLamViec(maNV, maLoaiCa);
        }
        public LichLamViec GetLichLamViec(int id)
        {
            return dALLichLamViec.GetLichLamViec(id);


        }
        public LichLamViec Add(LichLamViec llv)
        {

            return dALLichLamViec.Add(llv);

        }
        public LichLamViec Update(LichLamViec llv)
        {
            return dALLichLamViec.Update(llv);
        }
        public void Delete(int id)
        {
            dALLichLamViec.Delete(id);
        }
    }
}
