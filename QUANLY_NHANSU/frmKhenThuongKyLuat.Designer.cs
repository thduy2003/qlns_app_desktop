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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKhenThuongKyLuat = new System.Windows.Forms.DataGridView();
            this.btnXoaKTKL = new System.Windows.Forms.Button();
            this.btnSuaKTKL = new System.Windows.Forms.Button();
            this.btnThemKTKL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbbNhanVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MaKhenThuongKyLuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuongKyLuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhenThuongKyLuat
            // 
            this.dgvKhenThuongKyLuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhenThuongKyLuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhenThuongKyLuat.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvKhenThuongKyLuat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhenThuongKyLuat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhenThuongKyLuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvKhenThuongKyLuat.ColumnHeadersHeight = 30;
            this.dgvKhenThuongKyLuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhenThuongKyLuat,
            this.TenNhanVien,
            this.LyDo,
            this.NoiDung,
            this.Ngay});
            this.dgvKhenThuongKyLuat.EnableHeadersVisualStyles = false;
            this.dgvKhenThuongKyLuat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvKhenThuongKyLuat.Location = new System.Drawing.Point(12, 209);
            this.dgvKhenThuongKyLuat.MultiSelect = false;
            this.dgvKhenThuongKyLuat.Name = "dgvKhenThuongKyLuat";
            this.dgvKhenThuongKyLuat.ReadOnly = true;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhenThuongKyLuat.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvKhenThuongKyLuat.RowHeadersVisible = false;
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
            this.btnSuaKTKL.Location = new System.Drawing.Point(617, 158);
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
            this.groupBox1.Controls.Add(this.pictureBox1);
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::QUANLY_NHANSU.Properties.Resources.refresh_2;
            this.pictureBox1.Location = new System.Drawing.Point(728, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // MaKhenThuongKyLuat
            // 
            this.MaKhenThuongKyLuat.DataPropertyName = "MaKhenThuongKyLuat";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKhenThuongKyLuat.DefaultCellStyle = dataGridViewCellStyle23;
            this.MaKhenThuongKyLuat.HeaderText = "Mã KTKL";
            this.MaKhenThuongKyLuat.MinimumWidth = 6;
            this.MaKhenThuongKyLuat.Name = "MaKhenThuongKyLuat";
            this.MaKhenThuongKyLuat.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNhanVien.DefaultCellStyle = dataGridViewCellStyle24;
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LyDo.DefaultCellStyle = dataGridViewCellStyle25;
            this.LyDo.HeaderText = "Lý Do";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            this.LyDo.ReadOnly = true;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoiDung.DefaultCellStyle = dataGridViewCellStyle26;
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.ReadOnly = true;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ngay.DefaultCellStyle = dataGridViewCellStyle27;
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhenThuongKyLuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
    }
}