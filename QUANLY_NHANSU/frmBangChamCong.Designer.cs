namespace QUANLY_NHANSU
{
    partial class frmBangChamCong
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
            this.dgvBangChamCong = new System.Windows.Forms.DataGridView();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnThemBCC = new System.Windows.Forms.Button();
            this.btnSuaBCC = new System.Windows.Forms.Button();
            this.btnXoaBCC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangChamCong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBangChamCong
            // 
            this.dgvBangChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBangChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangChamCong.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvBangChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangChamCong.Location = new System.Drawing.Point(12, 191);
            this.dgvBangChamCong.Name = "dgvBangChamCong";
            this.dgvBangChamCong.ReadOnly = true;
            this.dgvBangChamCong.RowHeadersWidth = 51;
            this.dgvBangChamCong.RowTemplate.Height = 24;
            this.dgvBangChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangChamCong.Size = new System.Drawing.Size(815, 322);
            this.dgvBangChamCong.TabIndex = 0;
            this.dgvBangChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangChamCong_CellClick);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemChiTiet.BackColor = System.Drawing.Color.LightBlue;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnXemChiTiet.Location = new System.Drawing.Point(627, 519);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(200, 45);
            this.btnXemChiTiet.TabIndex = 1;
            this.btnXemChiTiet.Text = "Xem chi tiết BCC";
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnThemBCC
            // 
            this.btnThemBCC.BackColor = System.Drawing.Color.LightBlue;
            this.btnThemBCC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemBCC.Location = new System.Drawing.Point(12, 140);
            this.btnThemBCC.Name = "btnThemBCC";
            this.btnThemBCC.Size = new System.Drawing.Size(200, 45);
            this.btnThemBCC.TabIndex = 11;
            this.btnThemBCC.Text = "Thêm BCC";
            this.btnThemBCC.UseVisualStyleBackColor = false;
            this.btnThemBCC.Click += new System.EventHandler(this.btnThemBCC_Click);
            // 
            // btnSuaBCC
            // 
            this.btnSuaBCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaBCC.BackColor = System.Drawing.Color.LightBlue;
            this.btnSuaBCC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaBCC.Location = new System.Drawing.Point(424, 140);
            this.btnSuaBCC.Name = "btnSuaBCC";
            this.btnSuaBCC.Size = new System.Drawing.Size(200, 45);
            this.btnSuaBCC.TabIndex = 12;
            this.btnSuaBCC.Text = "Sửa BCC";
            this.btnSuaBCC.UseVisualStyleBackColor = false;
            this.btnSuaBCC.Click += new System.EventHandler(this.btnSuaBCC_Click);
            // 
            // btnXoaBCC
            // 
            this.btnXoaBCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaBCC.BackColor = System.Drawing.Color.LightBlue;
            this.btnXoaBCC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaBCC.Location = new System.Drawing.Point(627, 140);
            this.btnXoaBCC.Name = "btnXoaBCC";
            this.btnXoaBCC.Size = new System.Drawing.Size(200, 45);
            this.btnXoaBCC.TabIndex = 13;
            this.btnXoaBCC.Text = "Xóa BCC";
            this.btnXoaBCC.UseVisualStyleBackColor = false;
            this.btnXoaBCC.Click += new System.EventHandler(this.btnXoaBCC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "QUẢN LÝ BẢNG CHẤM CÔNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.cbbNam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbThang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 94);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.LightBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.Location = new System.Drawing.Point(597, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(200, 45);
            this.btnTimKiem.TabIndex = 34;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbbNam
            // 
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cbbNam.Location = new System.Drawing.Point(325, 38);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(186, 26);
            this.cbbNam.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Năm";
            // 
            // cbbThang
            // 
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbThang.Location = new System.Drawing.Point(66, 38);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(186, 26);
            this.cbbThang.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tháng";
            // 
            // frmBangChamCong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(839, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoaBCC);
            this.Controls.Add(this.btnSuaBCC);
            this.Controls.Add(this.btnThemBCC);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.dgvBangChamCong);
            this.Name = "frmBangChamCong";
            this.Text = "Hệ thống quản lý nhân sự";
            this.Load += new System.EventHandler(this.frmBangChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangChamCong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBangChamCong;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnThemBCC;
        private System.Windows.Forms.Button btnSuaBCC;
        private System.Windows.Forms.Button btnXoaBCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label label2;
    }
}