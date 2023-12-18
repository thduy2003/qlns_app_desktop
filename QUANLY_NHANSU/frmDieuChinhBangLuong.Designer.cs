namespace QUANLY_NHANSU
{
    partial class frmDieuChinhBangLuong
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightBlue;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Location = new System.Drawing.Point(362, 75);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(143, 43);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightBlue;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(202, 75);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 43);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTrangThai.Location = new System.Drawing.Point(554, 28);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(170, 26);
            this.txtTrangThai.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(472, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Trạng thái";
            // 
            // txtThang
            // 
            this.txtThang.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtThang.Location = new System.Drawing.Point(288, 28);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(180, 26);
            this.txtThang.TabIndex = 23;
            this.txtThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThang_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(235, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tháng";
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNam.Location = new System.Drawing.Point(44, 28);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(185, 26);
            this.txtNam.TabIndex = 21;
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNam_KeyPress);
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblNam.Location = new System.Drawing.Point(5, 31);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(39, 18);
            this.lblNam.TabIndex = 20;
            this.lblNam.Text = "Năm";
            // 
            // frmDieuChinhBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(743, 138);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.lblNam);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmDieuChinhBangLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điều chỉnh bảng lương";
            this.Load += new System.EventHandler(this.frmDieuChinhBangLuong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label lblNam;
    }
}