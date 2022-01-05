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
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class fKhachHang : Form
    {

        public fKhachHang()
        {
            InitializeComponent();
            //LoadList();
            LoadSanPham();
            LoadChiTietGioHang();
        }
        //load các sản phẩm vào trong datagridview
        void LoadList()
        { 
           

            //string query = "SELECT * FROM TAIKHOAN";
            //DataTable data = DataProvider.Instance.ExecuteQuery(query);
            //dataGridView1.DataSource = data;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fThanhToanTrucTiep f = new fThanhToanTrucTiep();
            this.Hide();
            f.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("THANH TOÁN THÀNH CÔNG");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadTimKiem();

        }
        private void loadTimKiem() {
            string c = textLoai_Search.Text.ToString();
            string b = textTenSP_Search.Text.ToString();
            string a = textMaSP_search.Text.ToString();
  
            List<SanPham> SanPhamList = SanPhamBUS.Instance.loadTimKiem(a, b, c);
               
            foreach (SanPham item in SanPhamList)
            {
                //CHUYỂN DỮ LIỆU THÀNH CÁC NÚT
                Button btn = new Button() { Width = (int)SanPhamBUS.SanPhamWidth, Height = (int)SanPhamBUS.SanPhamHeight };
                //SET CÁC THUỘC TÍNH CÁC BUTTON ĐỂ HIỂN THỊ HOA
                btn.Text = item.MaSanPham + Environment.NewLine + item.TenSanPham + Environment.NewLine + item.LoaiSanPham + Environment.NewLine + item.GiaBan + Environment.NewLine + item.SoLuong;
                btn.BackColor = Color.DeepSkyBlue;
                btn.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
                btn.ForeColor = Color.White;
                btn.Click += Btn_Click;
                btn.Tag = item;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fThanhToanOnline f = new fThanhToanOnline();
            this.Hide();
            f.Show();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
        #region Method
        void LoadSanPham()
        {
            List<SanPham> SanPhamList = SanPhamBUS.Instance.LoadSanPham();
            foreach (SanPham item in SanPhamList)
            {
                //CHUYỂN DỮ LIỆU THÀNH CÁC NÚT
                Button btn = new Button() { Width = (int)SanPhamBUS.SanPhamWidth, Height = (int)SanPhamBUS.SanPhamHeight };
                //SET CÁC THUỘC TÍNH CÁC BUTTON ĐỂ HIỂN THỊ HOA
                btn.Text = item.MaSanPham + Environment.NewLine + item.TenSanPham + Environment.NewLine + item.LoaiSanPham + Environment.NewLine + item.GiaBan + Environment.NewLine+ item.SoLuong;
                btn.BackColor = Color.DeepSkyBlue;
                btn.Font= new Font("Bahnschrift", 10, FontStyle.Bold);
                btn.ForeColor = Color.White;
                btn.Click += Btn_Click;
                btn.Tag = item;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //Button btn = sender as Button;

            Button b = sender as Button;
            if (b != null)
            {
                textMaSP_themGioHang.Text = (b.Tag as SanPham).MaSanPham;
                textMaSP_themGioHang.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
                textTenSP.Text = ((sender as Button).Tag as SanPham).TenSanPham.ToString();
                textTenSP.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
                textGia.Text = ((sender as Button).Tag as SanPham).GiaBan.ToString();
                textGia.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
                textLoai.Text= ((sender as Button).Tag as SanPham).LoaiSanPham.ToString();
                textLoai.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
            }
            //textMaSP_themGioHang.Text = a; ;
            //textTenSP.Text = ((sender as Button).Tag as SanPham).TenSanPham.ToString();
            //textGia.Text = ((sender as Button).Tag as SanPham).GiaBan.ToString();
            //textLoai.Text= ((sender as Button).Tag as SanPham).LoaiSanPham.ToString();


        }

        void LoadChiTietGioHang()
        {
            List<ChiTietGioHang> GioHangList = ChiTietGioHangBUS.Instance.LoadChiTietGioHang();
            foreach (ChiTietGioHang item in GioHangList)
            {
                //CHUYỂN DỮ LIỆU THÀNH CÁC NÚT
                Button btn = new Button() { Width = (int)SanPhamBUS.SanPhamWidth, Height = (int)SanPhamBUS.SanPhamHeight };
                //SET CÁC THUỘC TÍNH CÁC BUTTON ĐỂ HIỂN THỊ HOA
                btn.Text = item.MaSP + Environment.NewLine + item.SL1;
                btn.BackColor = Color.DeepSkyBlue;
                btn.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
                btn.ForeColor = Color.White;
                btn.Click += Btn_Click1;
                btn.Tag = item;
                flowLayoutPanel2.Controls.Add(btn);
            }
        }
        void ReloadChiTietGioHang()
        {
            flowLayoutPanel2.Controls.Clear();
            LoadChiTietGioHang();
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {
                string a = (b.Tag as ChiTietGioHang).MaSP;
                textMaSP_themGioHang.Text = a;
                textMaSP_themGioHang.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
                textSoLuong_GioHang.Text = ((sender as Button).Tag as ChiTietGioHang).SL1.ToString();
                textSoLuong_GioHang.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
                string query = "Exec GetSanPhamByID @MASP";
                DataTable TTSP = DataProvider.Instance.ExecuteQuery(query, new Object[] { a });
                
                foreach (DataRow row in TTSP.Rows)
                {
                    String TenSanPham = row["TENSP"].ToString();
                    String LoaiSanPham = row["LOAISP"].ToString();
                    String Gia = row["GIABAN"].ToString();
                    textTenSanPham_GioHang.Text = TenSanPham;
                    textTenSanPham_GioHang.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
                    textLoaiSanPham_GioHang.Text = LoaiSanPham;
                    textLoaiSanPham_GioHang.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
                    textGiaTien_GioHang.Text = Gia;
                    textGiaTien_GioHang.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
                }
            }
        }
        #endregion

        private void button6_Click(object sender, EventArgs e)
        {
            string a = textMaSP_themGioHang.Text;
            int b =(int)numericUpDown1.Value;
            int f = ChiTietGioHangBUS.Instance.themVaoGioHang(a,b);
            if (f > 0)
            {
                MessageBox.Show(" THÊM THÀNH CÔNG");
            }



        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = textMaSP_themGioHang.Text;
            int f = ChiTietGioHangBUS.Instance.xoaGioHang(a);
            if (f > 0)
            {
                MessageBox.Show(" XÓA THÀNH CÔNG");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ReloadChiTietGioHang();
            flowLayoutPanel2.Controls.Clear();
            LoadChiTietGioHang();
            HienThiTongTien();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String b = textSoLuong_Update.Text;
            //textSoLuong_Update.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
            String a = textMaSP_themGioHang.Text;
            //textMaSP_themGioHang.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
            int f = ChiTietGioHangBUS.Instance.updateGioHang(a, b);
            if (f > 0)
            {
                MessageBox.Show("CHỈNH SỬA THÀNH CÔNG");
            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            ReloadChiTietGioHang();
            HienThiTongTien();

        }
        private void HienThiTongTien()
        {

            string a = ChiTietGioHangBUS.Instance.tongTienGioHang();
            textTongTien.Text = a;
            textTongTien.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            reloadSP();
        }

        private void btnLamMoi_SanPham_Click(object sender, EventArgs e)
        {
            reloadSP();
        }
        private void reloadSP()
        {
            flowLayoutPanel1.Controls.Clear();
            LoadSanPham();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textLoai_Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
