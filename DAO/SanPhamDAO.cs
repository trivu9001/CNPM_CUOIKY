using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    class SanPhamDAO
    {
        private static SanPhamDAO instance;
        public static double SanPhamWidth = 120;
        public static double SanPhamHeight = 120;
        public static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO();return SanPhamDAO.instance; }
            private set { SanPhamDAO.instance = value; }
        }
        private SanPhamDAO() { }
        //Load sanh sách sản phẩm
        public List<SanPham> LoadSanPham()
        {
            List < SanPham > SanPhamList = new List<SanPham>();
            DataTable data = DataProvider.Instance.ExecuteQuery("GetSanPhamList");
            foreach(DataRow item in data.Rows){
                SanPham sanpham = new SanPham(item);
                SanPhamList.Add(sanpham);

            }
            return SanPhamList;
        }

        //Load sanh sách sản phẩm tìm kiếm
        public List<SanPham> loadTimKiem(string a,string b,string c)
        {
 
            if (a != null)
            {
                a = "'" + a + "'";
            }
            if (b != null)
            {
                b = "'" + b + "'";
            }
            if (c != null)
            {
                c = "'" + c + "'";
            }
            string query = "Exec  SearchLike " + a + "," + b + "," + c;
            List<SanPham> SanPhamList = new List<SanPham>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SanPham sanpham = new SanPham(item);
                SanPhamList.Add(sanpham);
            }
            return SanPhamList;


        }
        public DataTable getChiTietSanPham(string a)
        {

            string query = "Exec GetSanPhamByID @MASP";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new Object[] { a });
            return data;
        }





    }
   



}
