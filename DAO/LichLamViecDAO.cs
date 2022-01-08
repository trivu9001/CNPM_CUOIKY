using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LichLamViecDAO
    {
        private DataProvider provider;
        public LichLamViecDAO()
        {
            provider = new DataProvider();
        }

        public bool Insert(LichLamViec llv)
        {
            provider.Connect();
            string sql = "INSERT INTO LICHLAMVIEC(MALLV, NGAY, MANV,CA)" + "VALUES(N'" + llv.MaLLV + "','" + llv.Ngay + "','" + llv.MaNV + "','" + llv.Ca + "')";
            provider.ExecuteQuery(sql);
            provider.Disconnect();
            return true;
        }

        public bool Delete(string maLLV)
        {
            if (maLLV == "")
            {
                return false;
            }
            provider.Connect();
            string sql = "DELETE FROM LICHLAMVIEC WHERE MALLV=\'" + maLLV + "\'";
            provider.ExecuteQuery(sql);
            provider.Disconnect();
            return true;
        }
        public bool Update(string maLLV, DateTime ngay, string maNV, int ca)
        {

            provider.Connect();
            string sql = "UPDATE LICHLAMVIEC SET MALLV='" + maLLV + "',NGAY='" + ngay + "',CA='" + ca + "' Where MANV='" + maNV + "'";
            provider.ExecuteQuery(sql);
            provider.Disconnect();
            return true;
        }
    }
}
