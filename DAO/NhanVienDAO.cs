using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        private DataProvider provider;
        public NhanVienDAO()
        {
            provider = new DataProvider();
        }

        public bool Insert( NhanVien nv)
        {
            provider.Connect();
            string sql = "INSERT INTO NHANVIEN(MANV,TEN,NGAYSINH,GIOITINH,SDT, LUONG, PHANQUYEN)" + "VALUES(N'" + nv.MaNV + "','" + nv.TenNV + "','" + nv.NgaySinh + "','" + nv.GioiTinh + "','" + nv.Sdt + "','" + nv.Luong + "','" + nv.PhanQuyen + "')";
            provider.ExecuteQuery(sql);
            provider.Disconnect();
            return true;

        }


        public bool Delete(string maNV)
        {

            if (maNV == "")
            {
                return false;
            }
            provider.Connect();
            //string sql = "DELETE FROM NHANVIEN WHERE MANV=\'" + maNV + "\'";
            string sql1 = "DELETE FROM LICHLAMVIEC WHERE MANV='" + maNV + "' DELETE FROM NHANVIEN WHERE MANV = '" + maNV + "'";
            provider.ExecuteQuery(sql1);
            
            provider.Disconnect();
            return true;
        }
        public bool Update(string maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string SDT, int luong, string phanQuyen)
        {
            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(gioiTinh) || string.IsNullOrEmpty(SDT) || string.IsNullOrEmpty(phanQuyen))
            {
                return false;
            }
            provider.Connect();
            string sql = "UPDATE NHANVIEN SET TEN='" + tenNV + "',NGAYSINH='" + ngaySinh + "',GIOITINH='" + gioiTinh + "',SDT='" + SDT + "',LUONG='" + luong + "',PHANQUYEN='" + phanQuyen + "' Where MANV='" + maNV + "'";
            provider.ExecuteQuery(sql);
            provider.Disconnect();
            return true;
        }
    }
}
