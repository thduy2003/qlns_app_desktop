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
            this.dgvChiTietLuong = new System.Windows.Forms.DataGridView();
            this.btnIn = new System.Windows.Forms.Button();
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
            this.dgvChiTietLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietLuong.Location = new System.Drawing.Point(12, 73);
            this.dgvChiTietLuong.Name = "dgvChiTietLuong";
            this.dgvChiTietLuong.ReadOnly = true;
            this.dgvChiTietLuong.RowHeadersWidth = 51;
            this.dgvChiTietLuong.RowTemplate.Height = 24;
            this.dgvChiTietLuong.Size = new System.Drawing.Size(794, 384);
            this.dgvChiTietLuong.TabIndex = 0;
            // 
            // btnIn
            // 
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
    }
}