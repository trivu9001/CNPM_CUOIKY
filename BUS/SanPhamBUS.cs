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
    public class SanPhamBUS
    {
        private static SanPhamBUS instance;
        public static double SanPhamWidth = 120;
        public static double SanPhamHeight = 120;
        public static SanPhamBUS Instance
        {
            get { if (instance == null) instance = new SanPhamBUS(); return SanPhamBUS.instance; }
            private set { SanPhamBUS.instance = value; }
        }
        private SanPhamBUS() { }
        //Load sanh sách sản phẩm
        public List<SanPham> LoadSanPham()
        {
            return SanPhamDAO.Instance.LoadSanPham();
        }

        //Load sanh sách sản phẩm tìm kiếm
        public List<SanPham> loadTimKiem(string a, string b, string c)
        {
             return SanPhamDAO.Instance.loadTimKiem(a,b,c);
        }

        public DataTable getChiTietSanPham(string a)
        {
            return SanPhamDAO.Instance.getChiTietSanPham(a);
        }

    }
}
