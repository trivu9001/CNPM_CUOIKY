using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    class ChiTietGioHangDAO
    {
        private static ChiTietGioHangDAO instance;
        public static double SanPhamWidth = 120;
        public static double SanPhamHeight = 120;
        // hàm khởi tạo singleton
        public static ChiTietGioHangDAO Instance
        {
            get { if (instance == null) instance = new ChiTietGioHangDAO(); return ChiTietGioHangDAO.instance; }
            private set { ChiTietGioHangDAO.instance = value; }
        }
        private ChiTietGioHangDAO() { }
        //Load sanh sách sản phẩm
        public List<ChiTietGioHang> LoadChiTietGioHang()
        {
            List<ChiTietGioHang> GioHangList = new List<ChiTietGioHang>();
            DataTable data = DataProvider.Instance.ExecuteQuery("GetChiTietGioHang");
            foreach (DataRow item in data.Rows)
            {
                ChiTietGioHang chiTietGioHang = new ChiTietGioHang(item);
                GioHangList.Add(chiTietGioHang);

            }
            return GioHangList;
        }
        //THÊM VÀO GIỎ HÀNG 
        public int themVaoGioHang(string a,int b)
        {
            
            string query = "Exec Insert_GioHang 'KH001'," + "'" + a + "'" + "," + b;
            int f=DataProvider.Instance.ExecuteNonQuery(query);
            
            return f;


        }
        // xóa giỏ hàng
        public int xoaGioHang(string a)
        {

            string query = "Exec DeleteGioHangByID '" + a + "'";
            int f=DataProvider.Instance.ExecuteNonQuery(query);

            return f;

        }
        //update giỏ hàng
        public int updateGioHang(string a,string b)
        {
            string query = "exec Update_GioHang 'KH001','" + a + "'," + b;
            
            int f =DataProvider.Instance.ExecuteNonQuery(query);
            return f;
        }
        //Tổng tiền giỏ hàng
        public string tongTienGioHang()
        {
            string query = " EXEC Tong_Tien ";
            string f = DataProvider.Instance.ExecuteScala(query).ToString();
            return f;
        }
    }
}
