namespace QUANLY_NHANSU
{
    partial class frmNopDonNghi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDonNghi = new System.Windows.Forms.DataGridView();
            this.btnThemDon = new System.Windows.Forms.Button();
            this.btnXoaDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaDonNghiPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiNghiPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNopDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonNghi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonNghi
            // 
            this.dgvDonNghi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDonNghi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonNghi.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDonNghi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDonNghi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonNghi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonNghi.ColumnHeadersHeight = 30;
            this.dgvDonNghi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDonNghiPhep,
            this.TenLoaiNghiPhep,
            this.TenNhanVien,
            this.NgayNopDon,
            this.NgayNghi,
            this.LyDo,
            this.TrangThai});
            this.dgvDonNghi.EnableHeadersVisualStyles = false;
            this.dgvDonNghi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDonNghi.Location = new System.Drawing.Point(12, 113);
            this.dgvDonNghi.MultiSelect = false;
            this.dgvDonNghi.Name = "dgvDonNghi";
            this.dgvDonNghi.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonNghi.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDonNghi.RowHeadersVisible = false;
            this.dgvDonNghi.RowHeadersWidth = 51;
            this.dgvDonNghi.RowTemplate.Height = 24;
            this.dgvDonNghi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonNghi.Size = new System.Drawing.Size(1034, 441);
            this.dgvDonNghi.TabIndex = 0;
            this.dgvDonNghi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonNghi_CellClick);
            this.dgvDonNghi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDonNghi_CellFormatting);
            // 
            // btnThemDon
            // 
            this.btnThemDon.BackColor = System.Drawing.Color.LightBlue;
            this.btnThemDon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemDon.Location = new System.Drawing.Point(12, 62);
            this.btnThemDon.Name = "btnThemDon";
            this.btnThemDon.Size = new System.Drawing.Size(200, 45);
            this.btnThemDon.TabIndex = 1;
            this.btnThemDon.Text = "Thêm đơn";
            this.btnThemDon.UseVisualStyleBackColor = false;
            this.btnThemDon.Click += new System.EventHandler(this.btnThemDon_Click);
            // 
            // btnXoaDon
            // 
            this.btnXoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaDon.BackColor = System.Drawing.Color.LightBlue;
            this.btnXoaDon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaDon.Location = new System.Drawing.Point(845, 62);
            this.btnXoaDon.Name = "btnXoaDon";
            this.btnXoaDon.Size = new System.Drawing.Size(201, 45);
            this.btnXoaDon.TabIndex = 3;
            this.btnXoaDon.Text = "Xóa đơn";
            this.btnXoaDon.UseVisualStyleBackColor = false;
            this.btnXoaDon.Click += new System.EventHandler(this.btnXoaDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "YÊU CẦU NGHỈ PHÉP";
            // 
            // MaDonNghiPhep
            // 
            this.MaDonNghiPhep.DataPropertyName = "MaDonNghiPhep";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaDonNghiPhep.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaDonNghiPhep.HeaderText = "Mã ĐNP";
            this.MaDonNghiPhep.MinimumWidth = 6;
            this.MaDonNghiPhep.Name = "MaDonNghiPhep";
            this.MaDonNghiPhep.ReadOnly = true;
            // 
            // TenLoaiNghiPhep
            // 
            this.TenLoaiNghiPhep.DataPropertyName = "TenLoaiNghiPhep";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TenLoaiNghiPhep.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenLoaiNghiPhep.HeaderText = "Tên Loại";
            this.TenLoaiNghiPhep.MinimumWidth = 6;
            this.TenLoaiNghiPhep.Name = "TenLoaiNghiPhep";
            this.TenLoaiNghiPhep.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            // 
            // NgayNopDon
            // 
            this.NgayNopDon.DataPropertyName = "NgayNopDon";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NgayNopDon.DefaultCellStyle = dataGridViewCellStyle4;
            this.NgayNopDon.HeaderText = "Ngày Nộp Đơn";
            this.NgayNopDon.MinimumWidth = 6;
            this.NgayNopDon.Name = "NgayNopDon";
            this.NgayNopDon.ReadOnly = true;
            // 
            // NgayNghi
            // 
            this.NgayNghi.DataPropertyName = "NgayNghi";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NgayNghi.DefaultCellStyle = dataGridViewCellStyle5;
            this.NgayNghi.HeaderText = "Ngày Nghỉ";
            this.NgayNghi.MinimumWidth = 6;
            this.NgayNghi.Name = "NgayNghi";
            this.NgayNghi.ReadOnly = true;
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý Do";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            this.LyDo.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TrangThai.DefaultCellStyle = dataGridViewCellStyle6;
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // frmNopDonNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1058, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoaDon);
            this.Controls.Add(this.btnThemDon);
            this.Controls.Add(this.dgvDonNghi);
            this.Name = "frmNopDonNghi";
            this.Text = "frmNopDonNghi";
            this.Load += new System.EventHandler(this.frmNopDonNghi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonNghi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonNghi;
        private System.Windows.Forms.Button btnThemDon;
        private System.Windows.Forms.Button btnXoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonNghiPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiNghiPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNopDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}