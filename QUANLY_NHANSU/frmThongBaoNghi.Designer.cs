﻿namespace QUANLY_NHANSU
{
    partial class frmThongBaoNghi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvThongBao = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MaThongBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBangChamCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DenNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.cbbNam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbThang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(11, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 87);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.LightBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.Location = new System.Drawing.Point(766, 28);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 35);
            this.label1.TabIndex = 34;
            this.label1.Text = "QUẢN LÝ THÔNG BÁO NGHỈ";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.BackColor = System.Drawing.Color.LightBlue;
            this.btnCapNhat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.Location = new System.Drawing.Point(589, 144);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(194, 42);
            this.btnCapNhat.TabIndex = 33;
            this.btnCapNhat.Text = "Cập nhật thông báo";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.LightBlue;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(808, 144);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(187, 42);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa thông báo";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightBlue;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(11, 144);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(200, 42);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm thông báo";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvThongBao
            // 
            this.dgvThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongBao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongBao.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvThongBao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongBao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongBao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongBao.ColumnHeadersHeight = 30;
            this.dgvThongBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThongBao,
            this.MaBangChamCong,
            this.TieuDe,
            this.NoiDung,
            this.TuNgay,
            this.DenNgay,
            this.Nam,
            this.Thang});
            this.dgvThongBao.EnableHeadersVisualStyles = false;
            this.dgvThongBao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvThongBao.Location = new System.Drawing.Point(12, 198);
            this.dgvThongBao.MultiSelect = false;
            this.dgvThongBao.Name = "dgvThongBao";
            this.dgvThongBao.ReadOnly = true;
            this.dgvThongBao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongBao.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvThongBao.RowHeadersVisible = false;
            this.dgvThongBao.RowHeadersWidth = 51;
            this.dgvThongBao.RowTemplate.Height = 24;
            this.dgvThongBao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongBao.Size = new System.Drawing.Size(986, 355);
            this.dgvThongBao.TabIndex = 30;
            this.dgvThongBao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongBao_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::QUANLY_NHANSU.Properties.Resources.refresh_2;
            this.pictureBox1.Location = new System.Drawing.Point(711, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // MaThongBao
            // 
            this.MaThongBao.DataPropertyName = "MaThongBao";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaThongBao.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaThongBao.HeaderText = "Mã TB";
            this.MaThongBao.MinimumWidth = 6;
            this.MaThongBao.Name = "MaThongBao";
            this.MaThongBao.ReadOnly = true;
            // 
            // MaBangChamCong
            // 
            this.MaBangChamCong.DataPropertyName = "MaBangChamCong";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaBangChamCong.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaBangChamCong.HeaderText = "Mã CC";
            this.MaBangChamCong.MinimumWidth = 6;
            this.MaBangChamCong.Name = "MaBangChamCong";
            this.MaBangChamCong.ReadOnly = true;
            this.MaBangChamCong.Visible = false;
            // 
            // TieuDe
            // 
            this.TieuDe.DataPropertyName = "TieuDe";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieuDe.DefaultCellStyle = dataGridViewCellStyle4;
            this.TieuDe.HeaderText = "Tiêu Đề";
            this.TieuDe.MinimumWidth = 6;
            this.TieuDe.Name = "TieuDe";
            this.TieuDe.ReadOnly = true;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoiDung.DefaultCellStyle = dataGridViewCellStyle5;
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.ReadOnly = true;
            // 
            // TuNgay
            // 
            this.TuNgay.DataPropertyName = "TuNgay";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuNgay.DefaultCellStyle = dataGridViewCellStyle6;
            this.TuNgay.HeaderText = "Từ Ngày";
            this.TuNgay.MinimumWidth = 6;
            this.TuNgay.Name = "TuNgay";
            this.TuNgay.ReadOnly = true;
            // 
            // DenNgay
            // 
            this.DenNgay.DataPropertyName = "DenNgay";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DenNgay.DefaultCellStyle = dataGridViewCellStyle7;
            this.DenNgay.HeaderText = "Đến Ngày";
            this.DenNgay.MinimumWidth = 6;
            this.DenNgay.Name = "DenNgay";
            this.DenNgay.ReadOnly = true;
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "Nam";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nam.DefaultCellStyle = dataGridViewCellStyle8;
            this.Nam.HeaderText = "Năm";
            this.Nam.MinimumWidth = 6;
            this.Nam.Name = "Nam";
            this.Nam.ReadOnly = true;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thang.DefaultCellStyle = dataGridViewCellStyle9;
            this.Thang.HeaderText = "Tháng";
            this.Thang.MinimumWidth = 6;
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            // 
            // frmThongBaoNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1010, 565);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvThongBao);
            this.Name = "frmThongBaoNghi";
            this.Text = "Hệ thống quản lý nhân sự";
            this.Load += new System.EventHandler(this.frmThongBaoNghi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvThongBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThongBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBangChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DenNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
    }
}