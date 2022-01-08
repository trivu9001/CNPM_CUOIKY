using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LichLamViecBUS
    {
        private LichLamViecDAO lichlamviecDAO;
        public LichLamViecBUS()
        {
            lichlamviecDAO = new LichLamViecDAO();
        }
        public void Insert(LichLamViec llv)
        {
            lichlamviecDAO.Insert(llv);
        }
        public void Delete(string maSP)
        {
            lichlamviecDAO.Delete(maSP);
        }
        public void Update(string maLLV, DateTime ngay, string maNV, int ca)
        {
            lichlamviecDAO.Update(maLLV, ngay, maNV, ca);
        }
    }
}
