using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string maNV;
        private string tenNV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string sdt;
        private int luong;
        private string phanQuyen;
        //private bool hasAccount;

        

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string PhanQuyen { get => phanQuyen; set => phanQuyen = value; }
        //public bool HasAccount { get => hasAccount; set => hasAccount = value; }
        public int Luong { get => luong; set => luong = value; }

        public NhanVien(string MANV, string TEN, DateTime NGAYSINH, string GIOITINH, string SDT, int LUONG, string PHANQUYEN)
        {
            this.maNV = MANV;
            this.tenNV = TEN;
            this.ngaySinh = NGAYSINH;
            this.gioiTinh = GIOITINH;
            this.sdt = SDT;
            this.luong = LUONG;
            this.phanQuyen = PHANQUYEN;

        }
    }
}
