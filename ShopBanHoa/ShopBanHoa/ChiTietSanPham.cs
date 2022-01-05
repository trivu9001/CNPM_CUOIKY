using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopBanHoa.BUS;
using ShopBanHoa.DTO;

namespace ShopBanHoa
{
    
    public partial class ChiTietSanPham : Form
    {
        private ShopBUS shopBUS = new ShopBUS();
        public SanPham sanpham;
        public ChiTietSanPham()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maSP_TextChanged(object sender, EventArgs e)
        {
            maSP.ReadOnly = true;
        }

        private void ChiTietSanPham_Load(object sender, EventArgs e)
        {
            maSP.Text = sanpham.MaSP;
            tenSP.Text = sanpham.TenSP;
            loaiSP.Text = sanpham.LoaiSP;
            giaSP.Text = Convert.ToString(sanpham.GiaBan);
            soLuong.Text = Convert.ToString(sanpham.SoLuong);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            shopBUS.Delete(maSP.Text);
            maSP.Text = null;
            tenSP.Text = null;
            loaiSP.Text = null;
            giaSP.Text = null;
            soLuong.Text = null;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            shopBUS.Update(maSP.Text,tenSP.Text, loaiSP.Text, Convert.ToInt32(giaSP.Text), Convert.ToInt32(soLuong.Text));
            MessageBox.Show("Cập nhật thành công");
            
        }
    }
}
