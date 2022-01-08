using DTO;
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

namespace QLBH
{
    public partial class QuanLyNhanVien : Form
    {
        private NhanVien _nhanvien;
        private LichLamViec _lichlamviec;
        public QuanLyNhanVien()
        {
            InitializeComponent();
            LoadNhanVien();
            //dataQLNV.ReadOnly = true;
            LoadLichLamViec();
            //dataLLV.ReadOnly = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemNhanVien f = new ThemNhanVien();
            f.ShowDialog();
            this.Show();

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietNhanVien f = new ChiTietNhanVien();
            f.nhanvien = _nhanvien;
            f.ShowDialog();
            this.Show();
        }

        private void dataQLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;


            DataGridViewRow row = dataQLNV.Rows[index];
            string _maNhanVien = Convert.ToString(row.Cells[0].Value);
            string _tenNhanVien = Convert.ToString(row.Cells[1].Value);
            DateTime _ngaySinh = Convert.ToDateTime(row.Cells[2].Value);
            string _gioiTinh = Convert.ToString(row.Cells[3].Value);
            string _SDT = Convert.ToString(row.Cells[4].Value);
            int _luong = Convert.ToInt32(row.Cells[5].Value);
            string _phanQuyen = Convert.ToString(row.Cells[6].Value);
            _nhanvien = new NhanVien(_maNhanVien, _tenNhanVien, _ngaySinh, _gioiTinh, _SDT, _luong, _phanQuyen);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void LoadNhanVien()
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QUANLYCUAHANGBANHOA;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from NHANVIEN", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            dataQLNV.DataSource = table;

        }
        private void LoadLichLamViec()
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QUANLYCUAHANGBANHOA;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from LICHLAMVIEC", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            dataLLV.DataSource = table;

        }

        private void dataLLV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow row = dataLLV.Rows[index];
            string _mallv = Convert.ToString(row.Cells[0].Value);
            DateTime _ngay = Convert.ToDateTime(row.Cells[1].Value);
            string _manv = Convert.ToString(row.Cells[2].Value);
            int _ca = Convert.ToInt32(row.Cells[3].Value);
            
            _lichlamviec = new LichLamViec(_mallv, _ngay, _manv, _ca);
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            XemLichLamViec f = new XemLichLamViec();
            f.lichlamviec = _lichlamviec;
            f.ShowDialog();
            this.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemLichLamViec f = new ThemLichLamViec();
            f.ShowDialog();
            this.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLichLamViec();
        }
    }
}
