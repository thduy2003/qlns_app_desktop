namespace QUANLY_NHANSU
{
    partial class frmChiTietLuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvChiTietLuong = new System.Windows.Forms.DataGridView();
            this.btnIn = new System.Windows.Forms.Button();
            this.MaChiTietLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGioCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThucLanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiTietLuong
            // 
            this.dgvChiTietLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietLuong.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvChiTietLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTietLuong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTietLuong.ColumnHeadersHeight = 30;
            this.dgvChiTietLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiTietLuong,
            this.Column,
            this.MaNhanVien,
            this.TenNhanVien,
            this.PhuCap,
            this.SoGioCong,
            this.ThucLanh});
            this.dgvChiTietLuong.EnableHeadersVisualStyles = false;
            this.dgvChiTietLuong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvChiTietLuong.Location = new System.Drawing.Point(12, 73);
            this.dgvChiTietLuong.MultiSelect = false;
            this.dgvChiTietLuong.Name = "dgvChiTietLuong";
            this.dgvChiTietLuong.ReadOnly = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietLuong.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvChiTietLuong.RowHeadersVisible = false;
            this.dgvChiTietLuong.RowHeadersWidth = 51;
            this.dgvChiTietLuong.RowTemplate.Height = 24;
            this.dgvChiTietLuong.Size = new System.Drawing.Size(794, 384);
            this.dgvChiTietLuong.TabIndex = 0;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.BackColor = System.Drawing.Color.LightBlue;
            this.btnIn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnIn.Location = new System.Drawing.Point(655, 29);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(151, 38);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "In Bảng Lương";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // MaChiTietLuong
            // 
            this.MaChiTietLuong.DataPropertyName = "MaChiTietLuong";
            this.MaChiTietLuong.HeaderText = "MaChiTietLuong";
            this.MaChiTietLuong.MinimumWidth = 6;
            this.MaChiTietLuong.Name = "MaChiTietLuong";
            this.MaChiTietLuong.ReadOnly = true;
            this.MaChiTietLuong.Visible = false;
            // 
            // Column
            // 
            this.Column.DataPropertyName = "MaLuong";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column.HeaderText = "Mã Lương";
            this.Column.MinimumWidth = 6;
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaNhanVien.HeaderText = "Mã NV";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNhanVien.DefaultCellStyle = dataGridViewCellStyle4;
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            // 
            // PhuCap
            // 
            this.PhuCap.DataPropertyName = "PhuCap";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhuCap.DefaultCellStyle = dataGridViewCellStyle5;
            this.PhuCap.HeaderText = "Phụ Cấp";
            this.PhuCap.MinimumWidth = 6;
            this.PhuCap.Name = "PhuCap";
            this.PhuCap.ReadOnly = true;
            // 
            // SoGioCong
            // 
            this.SoGioCong.DataPropertyName = "SoGioCong";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoGioCong.DefaultCellStyle = dataGridViewCellStyle6;
            this.SoGioCong.HeaderText = "Số Giờ Công";
            this.SoGioCong.MinimumWidth = 6;
            this.SoGioCong.Name = "SoGioCong";
            this.SoGioCong.ReadOnly = true;
            // 
            // ThucLanh
            // 
            this.ThucLanh.DataPropertyName = "ThucLanh";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThucLanh.DefaultCellStyle = dataGridViewCellStyle7;
            this.ThucLanh.HeaderText = "Thực Lãnh";
            this.ThucLanh.MinimumWidth = 6;
            this.ThucLanh.Name = "ThucLanh";
            this.ThucLanh.ReadOnly = true;
            // 
            // frmChiTietLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(818, 469);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.dgvChiTietLuong);
            this.Name = "frmChiTietLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng lương";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChiTietLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiTietLuong;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTietLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGioCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThucLanh;
    }
}