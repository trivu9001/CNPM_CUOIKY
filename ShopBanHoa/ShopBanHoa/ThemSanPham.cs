using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopBanHoa.BUS;
using ShopBanHoa.DAO;
using ShopBanHoa.DTO;

namespace ShopBanHoa
{   
    public partial class ThemSanPham : Form
    {
        private ShopBUS shopBUS = new ShopBUS();
        public ThemSanPham()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maSP.Text == "" || tenSP.Text == "" || loaiSP.Text == "" || giaSP.Text == "" || soLuong.Text == "")
            {
                MessageBox.Show("Cần điền đầy đủ thông tin");
            }
            else
            {
                String MaSanPham = maSP.Text;
                String TenSanPham = tenSP.Text;
                String LoaiSanPham = loaiSP.Text;
                int GiaBan = int.Parse(giaSP.Text);
                int SoLuong = int.Parse(soLuong.Text);
             
                SanPham sp = new SanPham(MaSanPham, TenSanPham, LoaiSanPham, GiaBan, SoLuong);
                shopBUS.Insert(sp);
                maSP.Text = null;
                tenSP.Text = null;
                loaiSP.Text = null;
                giaSP.Text = null;
                soLuong.Text = null;
                MessageBox.Show("Thêm thành công");
            }    
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ThemSanPham_Load(object sender, EventArgs e)
        {
            
        }
    }
}
