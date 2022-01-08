using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopBanHoa.DAO;
using ShopBanHoa.DTO;

namespace ShopBanHoa.DAO
{
    public class ShopDAO
    {
        private DataProvider provider;
        public ShopDAO()
        {
            provider = new DataProvider();
        }

        public bool Insert(SanPham sp)
        {

            provider.Connect();
            string sql = "INSERT INTO SANPHAM(MASP,TENSP,LOAISP,GIABAN,SL)" + "VALUES(N'" + sp.MaSP + "','" + sp.TenSP + "','" + sp.LoaiSP + "','" + sp.GiaBan + "','" + sp.SoLuong + "')";
            provider.ExecuteQuery(sql);
            provider.Disconnect();
            return true;
        }

        public bool Delete(string maSP)
        {
            if (maSP == "")
            {
                return false;
            }
            provider.Connect();
            string sql = "DELETE FROM SANPHAM WHERE MASP=\'" + maSP + "\'";
            provider.ExecuteQuery(sql);
            provider.Disconnect();
            return true;
        }
        public bool Update(string maSP, string tenSP, string loaiSP, string giaBan, string soLuong)
        {
            if (maSP == "" || tenSP == "" || loaiSP == "" || giaBan == "" || soLuong == "")
            {
                return false;
            }
            provider.Connect();
            string sql = "UPDATE SANPHAM SET TENSP='" + tenSP + "',LOAISP='" + loaiSP + "',GIABAN='" + Convert.ToInt32(giaBan) + "',SL='" + Convert.ToInt32(soLuong) + "' Where MASP='" + maSP + "'";
            provider.ExecuteQuery(sql);
            provider.Disconnect();
            return true;
        }
    }
}