
namespace ShopBanHoa
{
    partial class ChiTietSanPham
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
            this.loaiSP = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.soLuong = new System.Windows.Forms.TextBox();
            this.giaSP = new System.Windows.Forms.TextBox();
            this.tenSP = new System.Windows.Forms.TextBox();
            this.maSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loaiSP
            // 
            this.loaiSP.Location = new System.Drawing.Point(178, 235);
            this.loaiSP.Multiline = true;
            this.loaiSP.Name = "loaiSP";
            this.loaiSP.Size = new System.Drawing.Size(268, 32);
            this.loaiSP.TabIndex = 31;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateButton.Location = new System.Drawing.Point(319, 459);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(127, 45);
            this.updateButton.TabIndex = 30;
            this.updateButton.Text = "Cập nhật";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteButton.Location = new System.Drawing.Point(178, 459);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(127, 45);
            this.deleteButton.TabIndex = 29;
            this.deleteButton.Text = "Xóa sản phẩm";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // soLuong
            // 
            this.soLuong.Location = new System.Drawing.Point(178, 372);
            this.soLuong.Multiline = true;
            this.soLuong.Name = "soLuong";
            this.soLuong.Size = new System.Drawing.Size(268, 32);
            this.soLuong.TabIndex = 28;
            // 
            // giaSP
            // 
            this.giaSP.Location = new System.Drawing.Point(178, 304);
            this.giaSP.Multiline = true;
            this.giaSP.Name = "giaSP";
            this.giaSP.Size = new System.Drawing.Size(268, 32);
            this.giaSP.TabIndex = 27;
            // 
            // tenSP
            // 
            this.tenSP.Location = new System.Drawing.Point(178, 169);
            this.tenSP.Multiline = true;
            this.tenSP.Name = "tenSP";
            this.tenSP.Size = new System.Drawing.Size(268, 32);
            this.tenSP.TabIndex = 26;
            // 
            // maSP
            // 
            this.maSP.Location = new System.Drawing.Point(178, 93);
            this.maSP.Multiline = true;
            this.maSP.Name = "maSP";
            this.maSP.Size = new System.Drawing.Size(268, 32);
            this.maSP.TabIndex = 25;
            this.maSP.TextChanged += new System.EventHandler(this.maSP_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Giá bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Loại sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Thông tin sản phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(478, 543);
            this.Controls.Add(this.loaiSP);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.soLuong);
            this.Controls.Add(this.giaSP);
            this.Controls.Add(this.tenSP);
            this.Controls.Add(this.maSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietSanPham";
            this.Text = "ChiTietSanPham";
            this.Load += new System.EventHandler(this.ChiTietSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loaiSP;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox soLuong;
        private System.Windows.Forms.TextBox giaSP;
        private System.Windows.Forms.TextBox tenSP;
        private System.Windows.Forms.TextBox maSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}