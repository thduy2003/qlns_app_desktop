namespace QUANLY_NHANSU
{
    partial class frmLichLamViec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLichLamViec = new System.Windows.Forms.DataGridView();
            this.MaLichLamViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemLich = new System.Windows.Forms.Button();
            this.btnXoaLich = new System.Windows.Forms.Button();
            this.btnSuaLich = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbCa = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbNhanVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichLamViec
            // 
            this.dgvLichLamViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLichLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichLamViec.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvLichLamViec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichLamViec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichLamViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvLichLamViec.ColumnHeadersHeight = 30;
            this.dgvLichLamViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLichLamViec,
            this.Ca,
            this.Thu,
            this.HoTenNV});
            this.dgvLichLamViec.EnableHeadersVisualStyles = false;
            this.dgvLichLamViec.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvLichLamViec.Location = new System.Drawing.Point(13, 209);
            this.dgvLichLamViec.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLichLamViec.MultiSelect = false;
            this.dgvLichLamViec.Name = "dgvLichLamViec";
            this.dgvLichLamViec.ReadOnly = true;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichLamViec.RowHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.dgvLichLamViec.RowHeadersVisible = false;
            this.dgvLichLamViec.RowHeadersWidth = 51;
            this.dgvLichLamViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichLamViec.Size = new System.Drawing.Size(1041, 428);
            this.dgvLichLamViec.TabIndex = 0;
            this.dgvLichLamViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichLamViec_CellClick);
            // 
            // MaLichLamViec
            // 
            this.MaLichLamViec.DataPropertyName = "MaLichLamViec";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLichLamViec.DefaultCellStyle = dataGridViewCellStyle38;
            this.MaLichLamViec.HeaderText = "Mã Lịch";
            this.MaLichLamViec.MinimumWidth = 6;
            this.MaLichLamViec.Name = "MaLichLamViec";
            this.MaLichLamViec.ReadOnly = true;
            // 
            // Ca
            // 
            this.Ca.DataPropertyName = "Ca";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ca.DefaultCellStyle = dataGridViewCellStyle39;
            this.Ca.HeaderText = "Ca";
            this.Ca.MinimumWidth = 6;
            this.Ca.Name = "Ca";
            this.Ca.ReadOnly = true;
            // 
            // Thu
            // 
            this.Thu.DataPropertyName = "Thu";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thu.DefaultCellStyle = dataGridViewCellStyle40;
            this.Thu.HeaderText = "Thứ";
            this.Thu.MinimumWidth = 6;
            this.Thu.Name = "Thu";
            this.Thu.ReadOnly = true;
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTenNV.DefaultCellStyle = dataGridViewCellStyle41;
            this.HoTenNV.HeaderText = "Họ Tên NV";
            this.HoTenNV.MinimumWidth = 6;
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.ReadOnly = true;
            // 
            // btnThemLich
            // 
            this.btnThemLich.BackColor = System.Drawing.Color.LightBlue;
            this.btnThemLich.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemLich.Location = new System.Drawing.Point(12, 157);
            this.btnThemLich.Name = "btnThemLich";
            this.btnThemLich.Size = new System.Drawing.Size(200, 45);
            this.btnThemLich.TabIndex = 10;
            this.btnThemLich.Text = "Thêm lịch";
            this.btnThemLich.UseVisualStyleBackColor = false;
            this.btnThemLich.Click += new System.EventHandler(this.btnThemLich_Click);
            // 
            // btnXoaLich
            // 
            this.btnXoaLich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaLich.BackColor = System.Drawing.Color.LightBlue;
            this.btnXoaLich.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaLich.ForeColor = System.Drawing.Color.Black;
            this.btnXoaLich.Location = new System.Drawing.Point(854, 157);
            this.btnXoaLich.Name = "btnXoaLich";
            this.btnXoaLich.Size = new System.Drawing.Size(200, 45);
            this.btnXoaLich.TabIndex = 11;
            this.btnXoaLich.Text = "Xóa lịch";
            this.btnXoaLich.UseVisualStyleBackColor = false;
            this.btnXoaLich.Click += new System.EventHandler(this.btnXoaLich_Click);
            // 
            // btnSuaLich
            // 
            this.btnSuaLich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaLich.BackColor = System.Drawing.Color.LightBlue;
            this.btnSuaLich.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaLich.Location = new System.Drawing.Point(640, 157);
            this.btnSuaLich.Name = "btnSuaLich";
            this.btnSuaLich.Size = new System.Drawing.Size(200, 45);
            this.btnSuaLich.TabIndex = 12;
            this.btnSuaLich.Text = "Sửa lịch";
            this.btnSuaLich.UseVisualStyleBackColor = false;
            this.btnSuaLich.Click += new System.EventHandler(this.btnSuaLich_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "QUẢN LÝ LỊCH LÀM VIỆC";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cbbCa);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbNhanVien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 98);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // cbbCa
            // 
            this.cbbCa.FormattingEnabled = true;
            this.cbbCa.Location = new System.Drawing.Point(423, 38);
            this.cbbCa.Name = "cbbCa";
            this.cbbCa.Size = new System.Drawing.Size(230, 26);
            this.cbbCa.TabIndex = 35;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.LightBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.Location = new System.Drawing.Point(823, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(200, 45);
            this.btnTimKiem.TabIndex = 34;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ca làm";
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
            this.pictureBox1.Location = new System.Drawing.Point(756, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // frmLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1067, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSuaLich);
            this.Controls.Add(this.btnXoaLich);
            this.Controls.Add(this.btnThemLich);
            this.Controls.Add(this.dgvLichLamViec);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLichLamViec";
            this.Text = "Hệ thống quản lý nhân sự";
            this.Load += new System.EventHandler(this.frmLichLamViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichLamViec;
        private System.Windows.Forms.Button btnThemLich;
        private System.Windows.Forms.Button btnXoaLich;
        private System.Windows.Forms.Button btnSuaLich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbCa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichLamViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}