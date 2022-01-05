
namespace ShopBanHoa
{
    partial class QuanLySanPham
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
            this.dataQLSP = new System.Windows.Forms.DataGridView();
            this.viewButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sản phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataQLSP
            // 
            this.dataQLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataQLSP.Location = new System.Drawing.Point(25, 87);
            this.dataQLSP.Name = "dataQLSP";
            this.dataQLSP.RowHeadersWidth = 51;
            this.dataQLSP.RowTemplate.Height = 24;
            this.dataQLSP.Size = new System.Drawing.Size(747, 292);
            this.dataQLSP.TabIndex = 1;
            this.dataQLSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataQLSP_CellClick_1);
            this.dataQLSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataQLSP_CellContentClick);
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.viewButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.viewButton.Location = new System.Drawing.Point(472, 395);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(125, 43);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "Xem Sản Phẩm";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addButton.Location = new System.Drawing.Point(630, 395);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 43);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Thêm sản phẩm";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.refreshButton.Location = new System.Drawing.Point(311, 395);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(125, 43);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Làm mới";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.dataQLSP);
            this.Controls.Add(this.label1);
            this.Name = "QuanLySanPham";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QuanLySanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataQLSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataQLSP;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button refreshButton;
    }
}