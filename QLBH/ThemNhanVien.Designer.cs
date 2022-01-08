using System;

namespace QLBH
{
    partial class ThemNhanVien
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.phanQuyen = new System.Windows.Forms.ComboBox();
            this.luong = new System.Windows.Forms.TextBox();
            this.gioiTinh = new System.Windows.Forms.ComboBox();
            this.ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.tenNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maNV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sdt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 489);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Chức Vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 416);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Lương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Mã nhân viên";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(480, 548);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 43);
            this.btnThem.TabIndex = 41;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // phanQuyen
            // 
            this.phanQuyen.FormattingEnabled = true;
            this.phanQuyen.Items.AddRange(new object[] {
            "Nhân viên bán hàng",
            "Nhân viên sản phẩm"});
            this.phanQuyen.Location = new System.Drawing.Point(287, 489);
            this.phanQuyen.Margin = new System.Windows.Forms.Padding(4);
            this.phanQuyen.Name = "phanQuyen";
            this.phanQuyen.Size = new System.Drawing.Size(363, 24);
            this.phanQuyen.TabIndex = 40;
            // 
            // luong
            // 
            this.luong.Location = new System.Drawing.Point(287, 411);
            this.luong.Margin = new System.Windows.Forms.Padding(4);
            this.luong.Name = "luong";
            this.luong.Size = new System.Drawing.Size(363, 22);
            this.luong.TabIndex = 39;
            // 
            // gioiTinh
            // 
            this.gioiTinh.FormattingEnabled = true;
            this.gioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.gioiTinh.Location = new System.Drawing.Point(287, 272);
            this.gioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Size = new System.Drawing.Size(363, 24);
            this.gioiTinh.TabIndex = 37;
            // 
            // ngaySinh
            // 
            this.ngaySinh.Location = new System.Drawing.Point(287, 199);
            this.ngaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Size = new System.Drawing.Size(363, 22);
            this.ngaySinh.TabIndex = 36;
            // 
            // tenNV
            // 
            this.tenNV.Location = new System.Drawing.Point(287, 135);
            this.tenNV.Margin = new System.Windows.Forms.Padding(4);
            this.tenNV.Name = "tenNV";
            this.tenNV.Size = new System.Drawing.Size(363, 22);
            this.tenNV.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "THÊM NHÂN VIÊN";
            // 
            // maNV
            // 
            this.maNV.Location = new System.Drawing.Point(287, 68);
            this.maNV.Margin = new System.Windows.Forms.Padding(4);
            this.maNV.Name = "maNV";
            this.maNV.Size = new System.Drawing.Size(363, 22);
            this.maNV.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 548);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 43);
            this.button1.TabIndex = 49;
            this.button1.Text = "Quay Lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(287, 332);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(363, 22);
            this.sdt.TabIndex = 50;
            // 
            // ThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(776, 604);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.phanQuyen);
            this.Controls.Add(this.luong);
            this.Controls.Add(this.gioiTinh);
            this.Controls.Add(this.ngaySinh);
            this.Controls.Add(this.tenNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maNV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThemNhanVien";
            this.Text = "ThemNhanVien";
            this.Load += new System.EventHandler(this.ThemNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void sdt_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox phanQuyen;
        private System.Windows.Forms.TextBox luong;
        private System.Windows.Forms.ComboBox gioiTinh;
        private System.Windows.Forms.DateTimePicker ngaySinh;
        private System.Windows.Forms.TextBox tenNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maNV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sdt;
    }
}