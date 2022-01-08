using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class ThemNhanVien : Form
    {
        private NhanVienBUS nhanvienBUS = new NhanVienBUS();
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maNV.Text) || string.IsNullOrEmpty(tenNV.Text) || string.IsNullOrEmpty(ngaySinh.Text) || string.IsNullOrEmpty(gioiTinh.Text) || string.IsNullOrEmpty(sdt.Text) || string.IsNullOrEmpty(luong.Text) || string.IsNullOrEmpty(phanQuyen.Text))
            {
                MessageBox.Show("Cần điền đầy đủ thông tin");
            }
            else
            {
                String MaNhanVien = maNV.Text;
                String TenNhanVien = tenNV.Text;
                DateTime NgaySinh = DateTime.Parse(ngaySinh.Text);
                String GioiTinh = gioiTinh.Text;
                String SDT = sdt.Text;
                int Luong = int.Parse(this.luong.Text);
                String PhanQuyen = phanQuyen.Text;

                NhanVien nv = new NhanVien(MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, SDT, Luong, PhanQuyen);
                nhanvienBUS.Insert(nv);
                maNV.Text = null;
                tenNV.Text = null;
                this.ngaySinh.Text = null;
                this.gioiTinh.Text = null;
                this.sdt.Text = null;
                this.luong.Text = null;
                this.phanQuyen.Text = null;

                MessageBox.Show("Thêm Thành Công");
            }


            Close();
        }

        //Quay lai trang Quan Ly Nhan Vien
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien f = new QuanLyNhanVien();
            f.ShowDialog();
            this.Show();
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {

        }
        private void Sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        
    }
}
