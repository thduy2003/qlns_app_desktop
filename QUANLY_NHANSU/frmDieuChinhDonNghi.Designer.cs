namespace QUANLY_NHANSU
{
    partial class frmDieuChinhDonNghi
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
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayNghi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayNopDon = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLoaiPhep = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbThu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtLyDo
            // 
            this.txtLyDo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtLyDo.Location = new System.Drawing.Point(85, 44);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(197, 22);
            this.txtLyDo.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label8.Location = new System.Drawing.Point(36, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Lý do";
            // 
            // dtpNgayNghi
            // 
            this.dtpNgayNghi.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtpNgayNghi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNghi.Location = new System.Drawing.Point(387, 44);
            this.dtpNgayNghi.Name = "dtpNgayNghi";
            this.dtpNgayNghi.Size = new System.Drawing.Size(204, 26);
            this.dtpNgayNghi.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(312, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ngày nghỉ";
            // 
            // dtpNgayNopDon
            // 
            this.dtpNgayNopDon.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtpNgayNopDon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNopDon.Location = new System.Drawing.Point(387, 7);
            this.dtpNgayNopDon.Name = "dtpNgayNopDon";
            this.dtpNgayNopDon.Size = new System.Drawing.Size(204, 26);
            this.dtpNgayNopDon.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(288, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ngày nộp đơn";
            // 
            // cbbLoaiPhep
            // 
            this.cbbLoaiPhep.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbbLoaiPhep.FormattingEnabled = true;
            this.cbbLoaiPhep.Location = new System.Drawing.Point(85, 6);
            this.cbbLoaiPhep.Name = "cbbLoaiPhep";
            this.cbbLoaiPhep.Size = new System.Drawing.Size(197, 26);
            this.cbbLoaiPhep.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Loại phép";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightBlue;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(155, 106);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 43);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightBlue;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Location = new System.Drawing.Point(302, 107);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 42);
            this.btnHuy.TabIndex = 28;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(44, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Thứ";
            // 
            // cbbThu
            // 
            this.cbbThu.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbbThu.FormattingEnabled = true;
            this.cbbThu.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbbThu.Location = new System.Drawing.Point(85, 74);
            this.cbbThu.Name = "cbbThu";
            this.cbbThu.Size = new System.Drawing.Size(197, 26);
            this.cbbThu.TabIndex = 30;
            // 
            // frmDieuChinhDonNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(603, 161);
            this.Controls.Add(this.cbbThu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbLoaiPhep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpNgayNghi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNgayNopDon);
            this.Controls.Add(this.label3);
            this.Name = "frmDieuChinhDonNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điều chỉnh đơn nghỉ";
            this.Load += new System.EventHandler(this.frmDieuChinhDonNghi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayNghi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayNopDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbLoaiPhep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbThu;
    }
}