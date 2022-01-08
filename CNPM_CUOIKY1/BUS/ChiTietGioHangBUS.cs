using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BUS
{
    public class ChiTietGioHangBUS
    {
        private static ChiTietGioHangBUS instance;
        public static double SanPhamWidth = 120;
        public static double SanPhamHeight = 120;
        public static ChiTietGioHangBUS Instance
        {
            get { if (instance == null) instance = new ChiTietGioHangBUS(); return ChiTietGioHangBUS.instance; }
            private set { ChiTietGioHangBUS.instance = value; }
        }
        private ChiTietGioHangBUS() { }
        //Load sanh sách sản phẩm
        
        public List<ChiTietGioHang> LoadChiTietGioHang()
        {
            return ChiTietGioHangDAO.Instance.LoadChiTietGioHang();
        }
        //THÊM VÀO GIỎ HÀNG 
        public int themVaoGioHang(string a, int b)
        {           
            return ChiTietGioHangDAO.Instance.themVaoGioHang(a,b);
        }
        // xóa giỏ hàng
        public int xoaGioHang(string a)
        {
            return ChiTietGioHangDAO.Instance.xoaGioHang(a);
        }
        //update giỏ hàng
        public int updateGioHang(string a, string b)
        {
            return ChiTietGioHangDAO.Instance.updateGioHang(a,b);
        }
        //Tổng tiền giỏ hàng
        public string tongTienGioHang()
        {
            return ChiTietGioHangDAO.Instance.tongTienGioHang();
        }
    }
}
