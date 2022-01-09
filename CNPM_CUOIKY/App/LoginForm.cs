using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH;
using ShopBanHoa;
using WindowsFormsApp1.App;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string b = txtPassword.Text;
            string a = txtUserName.Text;
            int day = login(a,b);

            if (day==1)
            {
                this.Hide();
                fKhachHang f = new fKhachHang();
                f.ShowDialog();
                this.Show();
            }
            if (day == 2)
            {
                this.Hide();
                QuanLyNhanVien f = new QuanLyNhanVien();
                f.ShowDialog();
                this.Show();
            }
            if (day == 3)
            {
                this.Hide();
                QuanLySanPham f = new QuanLySanPham();
                f.ShowDialog();
                this.Show();
            }
            if (day == 4)
            {
                this.Hide();
                fNhanVienBanHang f = new fNhanVienBanHang();
                f.ShowDialog();
                this.Show();
            }

        }
            

        
        int login(string a,string b)
        {
            int num = 0;
            if (a == "KH" && b == "123456")
            {
                num = 1;
            }
            else if (a == "QuanLy" && b == "123456")
            {
                num = 2;
            }
            else if (a == "NVSP" && b == "123456")
            {
                num = 3;
            }
            else if (a == "NVBH" && b == "123456")
            {
                num = 4;
            }
            else
            {
                MessageBox.Show("Sai tài khoản");
            }

            return num; 
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
