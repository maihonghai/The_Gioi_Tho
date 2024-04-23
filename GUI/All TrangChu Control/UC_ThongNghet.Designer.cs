namespace GUI.All_TrangChu_Control
{
    partial class UC_ThongNghet
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
            this.btnCong = new Guna.UI2.WinForms.Guna2Button();
            this.btnBonCau = new Guna.UI2.WinForms.Guna2Button();
            this.btnDuongOngNuoc = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnCong
            // 
            this.btnCong.BorderRadius = 10;
            this.btnCong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCong.FillColor = System.Drawing.Color.LightBlue;
            this.btnCong.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCong.ForeColor = System.Drawing.Color.Black;
            this.btnCong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCong.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCong.Location = new System.Drawing.Point(50, 158);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(245, 43);
            this.btnCong.TabIndex = 6;
            this.btnCong.Text = "thông nghẹt cống";
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnBonCau
            // 
            this.btnBonCau.BorderRadius = 10;
            this.btnBonCau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBonCau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBonCau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBonCau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBonCau.FillColor = System.Drawing.Color.LightBlue;
            this.btnBonCau.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBonCau.ForeColor = System.Drawing.Color.Black;
            this.btnBonCau.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBonCau.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBonCau.Location = new System.Drawing.Point(50, 244);
            this.btnBonCau.Name = "btnBonCau";
            this.btnBonCau.Size = new System.Drawing.Size(245, 43);
            this.btnBonCau.TabIndex = 7;
            this.btnBonCau.Text = "thông nghẹt bồn cầu";
            this.btnBonCau.Click += new System.EventHandler(this.btnBonCau_Click);
            // 
            // btnDuongOngNuoc
            // 
            this.btnDuongOngNuoc.BorderRadius = 10;
            this.btnDuongOngNuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDuongOngNuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDuongOngNuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDuongOngNuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDuongOngNuoc.FillColor = System.Drawing.Color.LightBlue;
            this.btnDuongOngNuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuongOngNuoc.ForeColor = System.Drawing.Color.Black;
            this.btnDuongOngNuoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDuongOngNuoc.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDuongOngNuoc.Location = new System.Drawing.Point(50, 334);
            this.btnDuongOngNuoc.Name = "btnDuongOngNuoc";
            this.btnDuongOngNuoc.Size = new System.Drawing.Size(245, 43);
            this.btnDuongOngNuoc.TabIndex = 8;
            this.btnDuongOngNuoc.Text = "thông nghẹt đường ống nước";
            this.btnDuongOngNuoc.Click += new System.EventHandler(this.btnDuongOngNuoc_Click);
            // 
            // UC_ThongNghet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDuongOngNuoc);
            this.Controls.Add(this.btnBonCau);
            this.Controls.Add(this.btnCong);
            this.Name = "UC_ThongNghet";
            this.Size = new System.Drawing.Size(342, 551);
            this.Load += new System.EventHandler(this.UC_ThongNghet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCong;
        private Guna.UI2.WinForms.Guna2Button btnBonCau;
        private Guna.UI2.WinForms.Guna2Button btnDuongOngNuoc;
    }
}
