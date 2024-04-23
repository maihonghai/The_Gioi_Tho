namespace GUI.All_Tho_Control
{
    partial class UC_DanhSachBaiDang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DanhSachBaiDang));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblIDTho = new System.Windows.Forms.Label();
            this.pnlDanhSachIDTho = new Guna.UI2.WinForms.Guna2Panel();
            this.ptbBack = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2GradientPanel1.Controls.Add(this.ptbBack);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-5, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1108, 71);
            this.guna2GradientPanel1.TabIndex = 4;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Black", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(42, 17);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(424, 51);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Danh Sách Bài Đăng";
            // 
            // lblIDTho
            // 
            this.lblIDTho.AutoSize = true;
            this.lblIDTho.Location = new System.Drawing.Point(8, 74);
            this.lblIDTho.Name = "lblIDTho";
            this.lblIDTho.Size = new System.Drawing.Size(44, 16);
            this.lblIDTho.TabIndex = 5;
            this.lblIDTho.Text = "label1";
            // 
            // pnlDanhSachIDTho
            // 
            this.pnlDanhSachIDTho.AutoScroll = true;
            this.pnlDanhSachIDTho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDanhSachIDTho.Location = new System.Drawing.Point(37, 93);
            this.pnlDanhSachIDTho.Name = "pnlDanhSachIDTho";
            this.pnlDanhSachIDTho.Size = new System.Drawing.Size(1037, 451);
            this.pnlDanhSachIDTho.TabIndex = 6;
            // 
            // ptbBack
            // 
            this.ptbBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ptbBack.Image = ((System.Drawing.Image)(resources.GetObject("ptbBack.Image")));
            this.ptbBack.ImageRotate = 0F;
            this.ptbBack.Location = new System.Drawing.Point(8, 26);
            this.ptbBack.Name = "ptbBack";
            this.ptbBack.Size = new System.Drawing.Size(25, 25);
            this.ptbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBack.TabIndex = 1;
            this.ptbBack.TabStop = false;
            this.ptbBack.Click += new System.EventHandler(this.ptbBack_Click);
            // 
            // UC_DanhSachBaiDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDanhSachIDTho);
            this.Controls.Add(this.lblIDTho);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UC_DanhSachBaiDang";
            this.Size = new System.Drawing.Size(1103, 568);
            //this.Load += new System.EventHandler(this.UC_DanhSachBaiDang_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label lblIDTho;
        private Guna.UI2.WinForms.Guna2Panel pnlDanhSachIDTho;
        private Guna.UI2.WinForms.Guna2PictureBox ptbBack;
    }
}
