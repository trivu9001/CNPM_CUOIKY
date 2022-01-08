
namespace WindowsFormsApp1
{
    partial class fKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fKhachHang));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLamMoi_SanPham = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textLoai_Search = new System.Windows.Forms.TextBox();
            this.textTenSP_Search = new System.Windows.Forms.TextBox();
            this.textMaSP_search = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textGia = new System.Windows.Forms.TextBox();
            this.textLoai = new System.Windows.Forms.TextBox();
            this.textTenSP = new System.Windows.Forms.TextBox();
            this.textMaSP_themGioHang = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.textSoLuong_Update = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textGiaTien_GioHang = new System.Windows.Forms.TextBox();
            this.textSoLuong_GioHang = new System.Windows.Forms.TextBox();
            this.textTenSanPham_GioHang = new System.Windows.Forms.TextBox();
            this.textLoaiSanPham_GioHang = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1096, 692);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1088, 665);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sản Phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1082, 659);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.btnLamMoi_SanPham);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.textLoai_Search);
            this.panel5.Controls.Add(this.textTenSP_Search);
            this.panel5.Controls.Add(this.textMaSP_search);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(710, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(352, 268);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btnLamMoi_SanPham
            // 
            this.btnLamMoi_SanPham.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLamMoi_SanPham.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi_SanPham.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi_SanPham.Location = new System.Drawing.Point(205, 214);
            this.btnLamMoi_SanPham.Name = "btnLamMoi_SanPham";
            this.btnLamMoi_SanPham.Size = new System.Drawing.Size(127, 42);
            this.btnLamMoi_SanPham.TabIndex = 18;
            this.btnLamMoi_SanPham.Text = "Làm Mới";
            this.btnLamMoi_SanPham.UseVisualStyleBackColor = false;
            this.btnLamMoi_SanPham.Click += new System.EventHandler(this.btnLamMoi_SanPham_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(26, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 42);
            this.button5.TabIndex = 17;
            this.button5.Text = "Tìm Sản Phẩm";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textLoai_Search
            // 
            this.textLoai_Search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textLoai_Search.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLoai_Search.Location = new System.Drawing.Point(26, 169);
            this.textLoai_Search.Multiline = true;
            this.textLoai_Search.Name = "textLoai_Search";
            this.textLoai_Search.Size = new System.Drawing.Size(306, 29);
            this.textLoai_Search.TabIndex = 16;
            this.textLoai_Search.TextChanged += new System.EventHandler(this.textLoai_Search_TextChanged);
            // 
            // textTenSP_Search
            // 
            this.textTenSP_Search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textTenSP_Search.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenSP_Search.Location = new System.Drawing.Point(26, 90);
            this.textTenSP_Search.Multiline = true;
            this.textTenSP_Search.Name = "textTenSP_Search";
            this.textTenSP_Search.Size = new System.Drawing.Size(306, 29);
            this.textTenSP_Search.TabIndex = 15;
            // 
            // textMaSP_search
            // 
            this.textMaSP_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textMaSP_search.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaSP_search.Location = new System.Drawing.Point(23, 28);
            this.textMaSP_search.Multiline = true;
            this.textMaSP_search.Name = "textMaSP_search";
            this.textMaSP_search.Size = new System.Drawing.Size(309, 28);
            this.textMaSP_search.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Loại Sản Phẩm";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tên Sản Phẩm";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã Sản Phẩm";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(685, 654);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.numericUpDown1);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.textGia);
            this.panel6.Controls.Add(this.textLoai);
            this.panel6.Controls.Add(this.textTenSP);
            this.panel6.Controls.Add(this.textMaSP_themGioHang);
            this.panel6.Location = new System.Drawing.Point(710, 277);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(352, 377);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(228, 265);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(33, 20);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Giá";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Loại Sản Phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tên Sản Phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mã Sản Phẩm";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(23, 305);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(309, 49);
            this.button6.TabIndex = 18;
            this.button6.Text = "Thêm Vào Giỏ  Hàng";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textGia
            // 
            this.textGia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textGia.Location = new System.Drawing.Point(23, 256);
            this.textGia.Multiline = true;
            this.textGia.Name = "textGia";
            this.textGia.ReadOnly = true;
            this.textGia.Size = new System.Drawing.Size(165, 29);
            this.textGia.TabIndex = 10;
            this.textGia.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textLoai
            // 
            this.textLoai.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textLoai.Location = new System.Drawing.Point(26, 188);
            this.textLoai.Multiline = true;
            this.textLoai.Name = "textLoai";
            this.textLoai.ReadOnly = true;
            this.textLoai.Size = new System.Drawing.Size(306, 29);
            this.textLoai.TabIndex = 9;
            // 
            // textTenSP
            // 
            this.textTenSP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textTenSP.Location = new System.Drawing.Point(26, 123);
            this.textTenSP.Multiline = true;
            this.textTenSP.Name = "textTenSP";
            this.textTenSP.ReadOnly = true;
            this.textTenSP.Size = new System.Drawing.Size(306, 29);
            this.textTenSP.TabIndex = 8;
            // 
            // textMaSP_themGioHang
            // 
            this.textMaSP_themGioHang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textMaSP_themGioHang.Location = new System.Drawing.Point(26, 46);
            this.textMaSP_themGioHang.Multiline = true;
            this.textMaSP_themGioHang.Name = "textMaSP_themGioHang";
            this.textMaSP_themGioHang.ReadOnly = true;
            this.textMaSP_themGioHang.Size = new System.Drawing.Size(306, 29);
            this.textMaSP_themGioHang.TabIndex = 7;
            this.textMaSP_themGioHang.TextChanged += new System.EventHandler(this.Btn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1088, 665);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Giỏ Hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.textSoLuong_Update);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textGiaTien_GioHang);
            this.panel1.Controls.Add(this.textSoLuong_GioHang);
            this.panel1.Controls.Add(this.textTenSanPham_GioHang);
            this.panel1.Controls.Add(this.textLoaiSanPham_GioHang);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textTongTien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(740, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 659);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(167, 278);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 54);
            this.button7.TabIndex = 15;
            this.button7.Text = "Làm Mới";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textSoLuong_Update
            // 
            this.textSoLuong_Update.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textSoLuong_Update.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSoLuong_Update.Location = new System.Drawing.Point(184, 382);
            this.textSoLuong_Update.Multiline = true;
            this.textSoLuong_Update.Name = "textSoLuong_Update";
            this.textSoLuong_Update.Size = new System.Drawing.Size(126, 42);
            this.textSoLuong_Update.TabIndex = 14;
            this.textSoLuong_Update.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(14, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 54);
            this.button4.TabIndex = 13;
            this.button4.Text = "Chỉnh số lượng";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Loại Sản Phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên Sản Phẩm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Giá Tiền";
            // 
            // textGiaTien_GioHang
            // 
            this.textGiaTien_GioHang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textGiaTien_GioHang.Location = new System.Drawing.Point(146, 191);
            this.textGiaTien_GioHang.Multiline = true;
            this.textGiaTien_GioHang.Name = "textGiaTien_GioHang";
            this.textGiaTien_GioHang.ReadOnly = true;
            this.textGiaTien_GioHang.Size = new System.Drawing.Size(168, 40);
            this.textGiaTien_GioHang.TabIndex = 8;
            // 
            // textSoLuong_GioHang
            // 
            this.textSoLuong_GioHang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textSoLuong_GioHang.Location = new System.Drawing.Point(20, 191);
            this.textSoLuong_GioHang.Multiline = true;
            this.textSoLuong_GioHang.Name = "textSoLuong_GioHang";
            this.textSoLuong_GioHang.ReadOnly = true;
            this.textSoLuong_GioHang.Size = new System.Drawing.Size(106, 40);
            this.textSoLuong_GioHang.TabIndex = 7;
            // 
            // textTenSanPham_GioHang
            // 
            this.textTenSanPham_GioHang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textTenSanPham_GioHang.Location = new System.Drawing.Point(14, 31);
            this.textTenSanPham_GioHang.Multiline = true;
            this.textTenSanPham_GioHang.Name = "textTenSanPham_GioHang";
            this.textTenSanPham_GioHang.ReadOnly = true;
            this.textTenSanPham_GioHang.Size = new System.Drawing.Size(293, 40);
            this.textTenSanPham_GioHang.TabIndex = 6;
            // 
            // textLoaiSanPham_GioHang
            // 
            this.textLoaiSanPham_GioHang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textLoaiSanPham_GioHang.Location = new System.Drawing.Point(17, 106);
            this.textLoaiSanPham_GioHang.Multiline = true;
            this.textLoaiSanPham_GioHang.Name = "textLoaiSanPham_GioHang";
            this.textLoaiSanPham_GioHang.ReadOnly = true;
            this.textLoaiSanPham_GioHang.Size = new System.Drawing.Size(293, 40);
            this.textLoaiSanPham_GioHang.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(14, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 57);
            this.button3.TabIndex = 4;
            this.button3.Text = "Xóa Sản Phẩm";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textTongTien
            // 
            this.textTongTien.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textTongTien.Location = new System.Drawing.Point(17, 480);
            this.textTongTien.Multiline = true;
            this.textTongTien.Name = "textTongTien";
            this.textTongTien.ReadOnly = true;
            this.textTongTien.Size = new System.Drawing.Size(296, 39);
            this.textTongTien.TabIndex = 3;
            this.textTongTien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng Tiền";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(14, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thanh Toán Trực Tiếp";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(178, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thanh Toán Online";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 659);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(720, 659);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "rating.png");
            this.imageList1.Images.SetKeyName(1, "shopping-cart.png");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(225, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Số Lượng";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // fKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1096, 692);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "fKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.fKhachHang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textGiaTien_GioHang;
        private System.Windows.Forms.TextBox textSoLuong_GioHang;
        private System.Windows.Forms.TextBox textTenSanPham_GioHang;
        private System.Windows.Forms.TextBox textLoaiSanPham_GioHang;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textGia;
        private System.Windows.Forms.TextBox textLoai;
        private System.Windows.Forms.TextBox textTenSP;
        private System.Windows.Forms.TextBox textMaSP_themGioHang;
        private System.Windows.Forms.TextBox textLoai_Search;
        private System.Windows.Forms.TextBox textTenSP_Search;
        private System.Windows.Forms.TextBox textMaSP_search;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textSoLuong_Update;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnLamMoi_SanPham;
        private System.Windows.Forms.Label label13;
    }
}