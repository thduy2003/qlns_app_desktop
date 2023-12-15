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
            this.dgvDonNghi = new System.Windows.Forms.DataGridView();
            this.btnThemDon = new System.Windows.Forms.Button();
            this.btnXoaDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgvDonNghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonNghi.Location = new System.Drawing.Point(12, 113);
            this.dgvDonNghi.Name = "dgvDonNghi";
            this.dgvDonNghi.ReadOnly = true;
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
    }
}