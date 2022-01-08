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
    public partial class ThemLichLamViec : Form
    {
        private LichLamViecBUS lichlamviecBUS = new LichLamViecBUS();
        public ThemLichLamViec()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien f = new QuanLyNhanVien();
            f.ShowDialog();
            this.Show();
        }

        private void ThemLichLamViec_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maLLV.Text) || string.IsNullOrEmpty(ngay.Text) || string.IsNullOrEmpty(maNV.Text) || string.IsNullOrEmpty(ca.Text))
            {
                MessageBox.Show("Cần điền đầy đủ thông tin");
            }
            else
            {
                String MaLichLamViec = maLLV.Text;
                DateTime Ngay = DateTime.Parse(ngay.Text);
                String MaNhanVien = maNV.Text;
                int Ca = int.Parse(this.ca.Text);
                

                LichLamViec llv = new LichLamViec(MaLichLamViec, Ngay, MaNhanVien, Ca);
                lichlamviecBUS.Insert(llv);
                maLLV.Text = null;
                ngay.Text = null; 
                maNV.Text = null;
                ca.Text = null;
               

                MessageBox.Show("Thêm Thành Công");
            }


            Close();
        }
    }
}
