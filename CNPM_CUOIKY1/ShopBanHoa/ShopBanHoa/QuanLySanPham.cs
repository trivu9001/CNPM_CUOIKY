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
using ShopBanHoa.DTO;

namespace ShopBanHoa
{
    public partial class QuanLySanPham : Form
    {
        public SanPham _sanpham;
        public QuanLySanPham()
        {
            InitializeComponent();
            LoadData();
            dataQLSP.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                this.Hide();
                ChiTietSanPham f = new ChiTietSanPham();
                f.sanpham = _sanpham;
                f.ShowDialog();
                this.Show();
          
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemSanPham f = new ThemSanPham();
            f.ShowDialog();
            this.Show();
        }

        private void LoadData()
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QUANLYCUAHANGBANHOA;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from SANPHAM", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
             
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            dataQLSP.DataSource = table;
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
       
        }

        private void dataQLSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
        
        private void dataQLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataQLSP_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;


            DataGridViewRow row = dataQLSP.Rows[index];
            string _masp = Convert.ToString(row.Cells[0].Value);
            string _tensp = Convert.ToString(row.Cells[1].Value);
            string _loaisp = Convert.ToString(row.Cells[2].Value);
            int _giaban = Convert.ToInt32(row.Cells[3].Value);
            int _soluong = Convert.ToInt32(row.Cells[4].Value);
            _sanpham = new SanPham(_masp, _tensp, _loaisp, _giaban, _soluong);
        }
    }
}
