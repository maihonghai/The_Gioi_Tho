namespace GUI.All_Tho_Control
{
    partial class UC_XemDanhGiaChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_XemDanhGiaChiTiet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.lblSoBaiDanhGia = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rtSosaotb = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lblSaotb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(69, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 487);
            this.panel1.TabIndex = 89;
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.AutoSize = false;
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.DimGray;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(266, 7);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(336, 44);
            this.guna2HtmlLabel10.TabIndex = 87;
            this.guna2HtmlLabel10.Text = "Các Đánh Giá";
            // 
            // btnThoat
            // 
            this.btnThoat.Animated = true;
            this.btnThoat.BorderRadius = 10;
            this.btnThoat.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(12, 7);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(38, 38);
            this.btnThoat.TabIndex = 88;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblSoBaiDanhGia
            // 
            this.lblSoBaiDanhGia.BackColor = System.Drawing.Color.Transparent;
            this.lblSoBaiDanhGia.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.lblSoBaiDanhGia.Location = new System.Drawing.Point(412, 78);
            this.lblSoBaiDanhGia.Name = "lblSoBaiDanhGia";
            this.lblSoBaiDanhGia.Size = new System.Drawing.Size(82, 25);
            this.lblSoBaiDanhGia.TabIndex = 92;
            this.lblSoBaiDanhGia.Text = "Sodanhgia";
            // 
            // rtSosaotb
            // 
            this.rtSosaotb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.rtSosaotb.Location = new System.Drawing.Point(266, 72);
            this.rtSosaotb.Name = "rtSosaotb";
            this.rtSosaotb.RatingColor = System.Drawing.Color.Gold;
            this.rtSosaotb.ReadOnly = true;
            this.rtSosaotb.Size = new System.Drawing.Size(140, 34);
            this.rtSosaotb.TabIndex = 91;
            this.rtSosaotb.Value = 1F;
            // 
            // lblSaotb
            // 
            this.lblSaotb.BackColor = System.Drawing.Color.Transparent;
            this.lblSaotb.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaotb.Location = new System.Drawing.Point(210, 67);
            this.lblSaotb.Name = "lblSaotb";
            this.lblSaotb.Size = new System.Drawing.Size(50, 43);
            this.lblSaotb.TabIndex = 90;
            this.lblSaotb.Text = "sao";
            // 
            // UC_XemDanhGiaChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSoBaiDanhGia);
            this.Controls.Add(this.rtSosaotb);
            this.Controls.Add(this.lblSaotb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Name = "UC_XemDanhGiaChiTiet";
            this.Size = new System.Drawing.Size(758, 634);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoBaiDanhGia;
        private Guna.UI2.WinForms.Guna2RatingStar rtSosaotb;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSaotb;
    }
}
