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
    public partial class ChiTietNhanVien : Form
    {
        private NhanVienBUS nhanvienBUS = new NhanVienBUS();
        public NhanVien nhanvien;
        public ChiTietNhanVien()
        {
            InitializeComponent();
            
        }
        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            nhanvienBUS.Delete(MaNV.Text);
            MaNV.Text = null;
            TenNV.Text = null;
            txtNSNV.Text = null;
            txtGioiTinhNV.Text = null;
            txtSDT.Text = null;
            txtLuong.Text = null;
            txtChucVuNV.Text = null;
        }
        private void ChiTietNhanVien_Load(object sender, EventArgs e)
        {
            MaNV.Text = nhanvien.MaNV;
            TenNV.Text = nhanvien.TenNV;
            txtNSNV.Text = Convert.ToString(nhanvien.NgaySinh);
            txtGioiTinhNV.Text = nhanvien.GioiTinh;
            txtSDT.Text = Convert.ToString(nhanvien.Sdt);
            txtLuong.Text = Convert.ToString(nhanvien.Luong);
            txtChucVuNV.Text = nhanvien.PhanQuyen;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            nhanvienBUS.Update(MaNV.Text, TenNV.Text, Convert.ToDateTime(txtNSNV.Text), txtGioiTinhNV.Text, txtSDT.Text, Convert.ToInt32(txtLuong.Text), txtChucVuNV.Text);
            MessageBox.Show("Cập nhật thành công");
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien f = new QuanLyNhanVien();
            f.ShowDialog();
            this.Show();
        }
    }
}
