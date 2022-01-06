using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class ChiTietGioHang
    {
        private string maKH;
        private int SL;
        private string maSP;

        public ChiTietGioHang(string maKH,string maSP,int SL)
        {
            this.maKH = maKH;
            this.maSP = maSP;
            this.SL = SL;
        }

        public ChiTietGioHang(DataRow row)
        {
            this.maSP = row["MASP"].ToString();
            this.maKH = row["MAKH"].ToString();
            this.SL = (int)row["SL"];
        }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SL1 { get => SL; set => SL = value; }
    }
}
