
namespace ShopBanHoa
{
    partial class ThemSanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maSP = new System.Windows.Forms.TextBox();
            this.tenSP = new System.Windows.Forms.TextBox();
            this.giaSP = new System.Windows.Forms.TextBox();
            this.soLuong = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.loaiSP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm sản phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sản phẩm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // maSP
            // 
            this.maSP.Location = new System.Drawing.Point(162, 108);
            this.maSP.Multiline = true;
            this.maSP.Name = "maSP";
            this.maSP.Size = new System.Drawing.Size(268, 32);
            this.maSP.TabIndex = 6;
            // 
            // tenSP
            // 
            this.tenSP.Location = new System.Drawing.Point(162, 184);
            this.tenSP.Multiline = true;
            this.tenSP.Name = "tenSP";
            this.tenSP.Size = new System.Drawing.Size(268, 32);
            this.tenSP.TabIndex = 7;
            // 
            // giaSP
            // 
            this.giaSP.Location = new System.Drawing.Point(162, 319);
            this.giaSP.Multiline = true;
            this.giaSP.Name = "giaSP";
            this.giaSP.Size = new System.Drawing.Size(268, 32);
            this.giaSP.TabIndex = 9;
            this.giaSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.giaSP_KeyPress);
            // 
            // soLuong
            // 
            this.soLuong.Location = new System.Drawing.Point(162, 387);
            this.soLuong.Multiline = true;
            this.soLuong.Name = "soLuong";
            this.soLuong.Size = new System.Drawing.Size(268, 32);
            this.soLuong.TabIndex = 10;
            this.soLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soLuong_KeyPress);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.confirmButton.Location = new System.Drawing.Point(303, 474);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(127, 45);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "Xác nhận";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // loaiSP
            // 
            this.loaiSP.Location = new System.Drawing.Point(162, 250);
            this.loaiSP.Multiline = true;
            this.loaiSP.Name = "loaiSP";
            this.loaiSP.Size = new System.Drawing.Size(268, 32);
            this.loaiSP.TabIndex = 18;
            // 
            // ThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(471, 547);
            this.Controls.Add(this.loaiSP);
            this.Controls.Add(this.confirmButton);
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
            this.Name = "ThemSanPham";
            this.Text = "Thêm sản phẩm";
            this.Load += new System.EventHandler(this.ThemSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maSP;
        private System.Windows.Forms.TextBox tenSP;
        private System.Windows.Forms.TextBox giaSP;
        private System.Windows.Forms.TextBox soLuong;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox loaiSP;
    }
}