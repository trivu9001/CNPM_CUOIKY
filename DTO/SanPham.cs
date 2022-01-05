using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class SanPham
    {
        private string maSanPham;
        private string tenSanPham;
        private string loaiSanPham;
        private int giaBan;
        private int soLuong;
        public SanPham(string maSanPham, string tenSanPham, string loaiSanPham, int giaBan, int soLuong)
        {
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.loaiSanPham = loaiSanPham;
            this.giaBan = giaBan;
            this.soLuong = soLuong;
        }
        public SanPham(DataRow row)
        {
            this.maSanPham = row["MASP"].ToString();
            this.tenSanPham = row["TENSP"].ToString();
            this.loaiSanPham = row["LOAISP"].ToString();
            this.giaBan = (int)row["GIABAN"];
            this.soLuong = (int)row["SL"];
        }

        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public string LoaiSanPham { get => loaiSanPham; set => loaiSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
    }
}

