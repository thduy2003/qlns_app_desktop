namespace QUANLY_NHANSU
{
    partial class frmSuaBCCCT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvChiTietChamCong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbGioVao = new System.Windows.Forms.MaskedTextBox();
            this.mtbGioRa = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblThu = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.MaDuLieuChamCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiTietChamCong
            // 
            this.dgvChiTietChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietChamCong.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvChiTietChamCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTietChamCong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTietChamCong.ColumnHeadersHeight = 30;
            this.dgvChiTietChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDuLieuChamCong,
            this.Ca,
            this.TenNV,
            this.T,
            this.N,
            this.GioVao,
            this.GioRa});
            this.dgvChiTietChamCong.EnableHeadersVisualStyles = false;
            this.dgvChiTietChamCong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvChiTietChamCong.Location = new System.Drawing.Point(12, 117);
            this.dgvChiTietChamCong.MultiSelect = false;
            this.dgvChiTietChamCong.Name = "dgvChiTietChamCong";
            this.dgvChiTietChamCong.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietChamCong.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvChiTietChamCong.RowHeadersVisible = false;
            this.dgvChiTietChamCong.RowHeadersWidth = 51;
            this.dgvChiTietChamCong.RowTemplate.Height = 24;
            this.dgvChiTietChamCong.Size = new System.Drawing.Size(798, 344);
            this.dgvChiTietChamCong.TabIndex = 0;
            this.dgvChiTietChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietChamCong_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhân viên: ";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblNhanVien.Location = new System.Drawing.Point(103, 7);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(0, 18);
            this.lblNhanVien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(300, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(7, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ca làm việc:";
            // 
            // cbbCa
            // 
            this.cbbCa.FormattingEnabled = true;
            this.cbbCa.Location = new System.Drawing.Point(99, 36);
            this.cbbCa.Name = "cbbCa";
            this.cbbCa.Size = new System.Drawing.Size(172, 24);
            this.cbbCa.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(283, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giờ vào:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.Location = new System.Drawing.Point(473, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giờ ra:";
            // 
            // mtbGioVao
            // 
            this.mtbGioVao.Location = new System.Drawing.Point(351, 39);
            this.mtbGioVao.Mask = "00:00";
            this.mtbGioVao.Name = "mtbGioVao";
            this.mtbGioVao.Size = new System.Drawing.Size(110, 22);
            this.mtbGioVao.TabIndex = 9;
            this.mtbGioVao.ValidatingType = typeof(System.DateTime);
            // 
            // mtbGioRa
            // 
            this.mtbGioRa.Location = new System.Drawing.Point(525, 38);
            this.mtbGioRa.Mask = "00:00";
            this.mtbGioRa.Name = "mtbGioRa";
            this.mtbGioRa.Size = new System.Drawing.Size(124, 22);
            this.mtbGioRa.TabIndex = 10;
            this.mtbGioRa.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label6.Location = new System.Drawing.Point(481, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thứ:";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblNgay.Location = new System.Drawing.Point(349, 7);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(70, 18);
            this.lblNgay.TabIndex = 12;
            this.lblNgay.Text = "labelNgay";
            // 
            // lblThu
            // 
            this.lblThu.AutoSize = true;
            this.lblThu.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblThu.Location = new System.Drawing.Point(525, 9);
            this.lblThu.Name = "lblThu";
            this.lblThu.Size = new System.Drawing.Size(62, 18);
            this.lblThu.TabIndex = 13;
            this.lblThu.Text = "labelThu";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightBlue;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(10, 73);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 38);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightBlue;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(553, 73);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(121, 38);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightBlue;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(680, 73);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 38);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // MaDuLieuChamCong
            // 
            this.MaDuLieuChamCong.DataPropertyName = "MaDuLieuChamCong";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDuLieuChamCong.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaDuLieuChamCong.HeaderText = "Mã DLCC";
            this.MaDuLieuChamCong.MinimumWidth = 6;
            this.MaDuLieuChamCong.Name = "MaDuLieuChamCong";
            this.MaDuLieuChamCong.ReadOnly = true;
            this.MaDuLieuChamCong.Width = 106;
            // 
            // Ca
            // 
            this.Ca.DataPropertyName = "Ca";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ca.DefaultCellStyle = dataGridViewCellStyle3;
            this.Ca.HeaderText = "Ca";
            this.Ca.MinimumWidth = 6;
            this.Ca.Name = "Ca";
            this.Ca.ReadOnly = true;
            this.Ca.Width = 107;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNV.DataPropertyName = "TenNhanVien";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNV.DefaultCellStyle = dataGridViewCellStyle4;
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 106;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // T
            // 
            this.T.DataPropertyName = "Thu";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T.DefaultCellStyle = dataGridViewCellStyle5;
            this.T.HeaderText = "Thứ";
            this.T.MinimumWidth = 6;
            this.T.Name = "T";
            this.T.ReadOnly = true;
            this.T.Width = 107;
            // 
            // N
            // 
            this.N.DataPropertyName = "Ngay";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N.DefaultCellStyle = dataGridViewCellStyle6;
            this.N.HeaderText = "Ngày";
            this.N.MinimumWidth = 6;
            this.N.Name = "N";
            this.N.ReadOnly = true;
            this.N.Width = 106;
            // 
            // GioVao
            // 
            this.GioVao.DataPropertyName = "GioVao";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioVao.DefaultCellStyle = dataGridViewCellStyle7;
            this.GioVao.HeaderText = "Giờ Vào";
            this.GioVao.MinimumWidth = 6;
            this.GioVao.Name = "GioVao";
            this.GioVao.ReadOnly = true;
            this.GioVao.Width = 107;
            // 
            // GioRa
            // 
            this.GioRa.DataPropertyName = "GioRa";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioRa.DefaultCellStyle = dataGridViewCellStyle8;
            this.GioRa.HeaderText = "Giờ Ra";
            this.GioRa.MinimumWidth = 6;
            this.GioRa.Name = "GioRa";
            this.GioRa.ReadOnly = true;
            this.GioRa.Width = 106;
            // 
            // frmSuaBCCCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(822, 473);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblThu);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtbGioRa);
            this.Controls.Add(this.mtbGioVao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbCa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvChiTietChamCong);
            this.Name = "frmSuaBCCCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa bảng chấm công chi tiết";
            this.Load += new System.EventHandler(this.frmSuaBCCCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiTietChamCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbGioVao;
        private System.Windows.Forms.MaskedTextBox mtbGioRa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblThu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDuLieuChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn T;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioRa;
    }
}