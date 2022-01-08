
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
    public partial class XemLichLamViec : Form
    {
        private LichLamViecBUS lichlamviecBUS = new LichLamViecBUS();
        

        public LichLamViec lichlamviec;
        public XemLichLamViec()
        {
            InitializeComponent();
        }

        private void XemLichLamViec_Load(object sender, EventArgs e)
        {
            MaLLV.Text = lichlamviec.MaLLV;
            Ngay.Text = Convert.ToString(lichlamviec.Ngay);
            MaNV.Text = lichlamviec.MaNV;
            Ca.Text = Convert.ToString(lichlamviec.Ca);
            
        }

        private void MaLLV_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lichlamviecBUS.Update(MaLLV.Text, Convert.ToDateTime(Ngay.Text),MaNV.Text, Convert.ToInt32(Ca.Text));
            MessageBox.Show("Cập nhật thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lichlamviecBUS.Delete(MaLLV.Text);
            MaLLV.Text = null;
            Ngay.Text = null;
            MaNV.Text = null;
            Ca.Text = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien f = new QuanLyNhanVien();
            f.ShowDialog();
            this.Show();
        }
    }
}
