using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichLamViec
    {
        private string maLLV;
        private DateTime ngay;
        private string maNV;
        private int ca;

        public LichLamViec()
        {

        }

        public DateTime Ngay { get => ngay; set => ngay = value; }
        public int Ca { get => ca; set => ca = value; }
        public string MaLLV { get => maLLV; set => maLLV = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public LichLamViec(string MALLV, DateTime NGAY, string MANV, int CA)
        {
            this.maLLV = MALLV;
            this.ngay = NGAY;
            this.maNV = MANV;
            this.ca = CA;
        }
    }
}
