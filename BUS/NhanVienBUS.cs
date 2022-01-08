using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAO nhanvienDAO;
        public NhanVienBUS()
        {
            nhanvienDAO = new NhanVienDAO();
        }
        public void Insert(NhanVien nv)
        {
            nhanvienDAO.Insert(nv);
        }
        public void Delete(string maNV)
        {
            nhanvienDAO.Delete(maNV);
        }
        public void Update(string maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string SDT, int luong, string phanQuyen)
        {
            nhanvienDAO.Update(maNV, tenNV, ngaySinh, gioiTinh, SDT, luong, phanQuyen);
        }

        internal void Update(string text1, string text2, DateTime dateTime, string text3, string text4)
        {
            throw new NotImplementedException();
        }
    }
}
