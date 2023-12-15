namespace QUANLY_NHANSU
{
    partial class frmKhenThuongKyLuat
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
            this.dgvKhenThuongKyLuat = new System.Windows.Forms.DataGridView();
            this.btnXoaKTKL = new System.Windows.Forms.Button();
            this.btnSuaKTKL = new System.Windows.Forms.Button();
            this.btnThemKTKL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbbNhanVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuongKyLuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhenThuongKyLuat
            // 
            this.dgvKhenThuongKyLuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhenThuongKyLuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhenThuongKyLuat.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvKhenThuongKyLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhenThuongKyLuat.Location = new System.Drawing.Point(12, 209);
            this.dgvKhenThuongKyLuat.Name = "dgvKhenThuongKyLuat";
            this.dgvKhenThuongKyLuat.ReadOnly = true;
            this.dgvKhenThuongKyLuat.RowHeadersWidth = 51;
            this.dgvKhenThuongKyLuat.RowTemplate.Height = 24;
            this.dgvKhenThuongKyLuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhenThuongKyLuat.Size = new System.Drawing.Size(1016, 429);
            this.dgvKhenThuongKyLuat.TabIndex = 0;
            this.dgvKhenThuongKyLuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhenThuongKyLuat_CellClick);
            // 
            // btnXoaKTKL
            // 
            this.btnXoaKTKL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaKTKL.BackColor = System.Drawing.Color.LightBlue;
            this.btnXoaKTKL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaKTKL.Location = new System.Drawing.Point(828, 158);
            this.btnXoaKTKL.Name = "btnXoaKTKL";
            this.btnXoaKTKL.Size = new System.Drawing.Size(200, 45);
            this.btnXoaKTKL.TabIndex = 28;
            this.btnXoaKTKL.Text = "Xóa KTKL";
            this.btnXoaKTKL.UseVisualStyleBackColor = false;
            this.btnXoaKTKL.Click += new System.EventHandler(this.btnXoaKTKL_Click);
            // 
            // btnSuaKTKL
            // 
            this.btnSuaKTKL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaKTKL.BackColor = System.Drawing.Color.LightBlue;
            this.btnSuaKTKL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaKTKL.Location = new System.Drawing.Point(622, 158);
            this.btnSuaKTKL.Name = "btnSuaKTKL";
            this.btnSuaKTKL.Size = new System.Drawing.Size(200, 45);
            this.btnSuaKTKL.TabIndex = 27;
            this.btnSuaKTKL.Text = "Sửa KTKL";
            this.btnSuaKTKL.UseVisualStyleBackColor = false;
            this.btnSuaKTKL.Click += new System.EventHandler(this.btnSuaKTKL_Click);
            // 
            // btnThemKTKL
            // 
            this.btnThemKTKL.BackColor = System.Drawing.Color.LightBlue;
            this.btnThemKTKL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKTKL.ForeColor = System.Drawing.Color.Black;
            this.btnThemKTKL.Location = new System.Drawing.Point(12, 158);
            this.btnThemKTKL.Name = "btnThemKTKL";
            this.btnThemKTKL.Size = new System.Drawing.Size(200, 45);
            this.btnThemKTKL.TabIndex = 26;
            this.btnThemKTKL.Text = "Thêm KTKL";
            this.btnThemKTKL.UseVisualStyleBackColor = false;
            this.btnThemKTKL.Click += new System.EventHandler(this.btnThemKTKL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "QUẢN LÝ KHEN THƯỞNG KỶ LUẬT";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.cbbNhanVien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 91);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.LightBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.Location = new System.Drawing.Point(798, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(200, 45);
            this.btnTimKiem.TabIndex = 34;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Location = new System.Drawing.Point(91, 38);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(230, 26);
            this.cbbNhanVien.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nhân viên";
            // 
            // frmKhenThuongKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1040, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoaKTKL);
            this.Controls.Add(this.btnSuaKTKL);
            this.Controls.Add(this.btnThemKTKL);
            this.Controls.Add(this.dgvKhenThuongKyLuat);
            this.Name = "frmKhenThuongKyLuat";
            this.Text = "Hệ thống quản lý nhân sự";
            this.Load += new System.EventHandler(this.frmKhenThuongKyLuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuongKyLuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhenThuongKyLuat;
        private System.Windows.Forms.Button btnXoaKTKL;
        private System.Windows.Forms.Button btnSuaKTKL;
        private System.Windows.Forms.Button btnThemKTKL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbbNhanVien;
        private System.Windows.Forms.Label label2;
    }
}