using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHoa.DTO
{
    public class SanPham
    {
        private string maSP;
        private string tenSP;
        private string loaiSP;
        private int giaBan;
        private int soLuong;

        public string MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }
        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        public string LoaiSP
        {
            get { return loaiSP; }
            set { loaiSP = value; }
        }

        public int GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public SanPham(string MASP,string TENSP, string LOAISP, int GIABAN, int SOLUONG)
        {
            this.maSP = MASP;
            this.tenSP = TENSP;
            this.loaiSP = LOAISP;
            this.giaBan = GIABAN;
            this.soLuong = SOLUONG;
        }
    }
}
