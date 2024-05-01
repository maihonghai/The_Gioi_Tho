namespace GUI.All_User_Control
{
    partial class UC_DSThoYeuThich
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlDanhSachTho = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnTopTho = new Guna.UI2.WinForms.Guna2Button();
            this.btnThoBiHuy = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Black", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(39, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(339, 39);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Danh Sách Thợ Yêu Thích";
            // 
            // pnlDanhSachTho
            // 
            this.pnlDanhSachTho.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlDanhSachTho.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnlDanhSachTho.BorderThickness = 2;
            this.pnlDanhSachTho.Location = new System.Drawing.Point(39, 120);
            this.pnlDanhSachTho.Name = "pnlDanhSachTho";
            this.pnlDanhSachTho.Size = new System.Drawing.Size(979, 414);
            this.pnlDanhSachTho.TabIndex = 1;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1052, 65);
            this.guna2GradientPanel1.TabIndex = 2;
            // 
            // btnTopTho
            // 
            this.btnTopTho.Animated = true;
            this.btnTopTho.BorderRadius = 10;
            this.btnTopTho.BorderThickness = 1;
            this.btnTopTho.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTopTho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTopTho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTopTho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTopTho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTopTho.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTopTho.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnTopTho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTopTho.Location = new System.Drawing.Point(39, 72);
            this.btnTopTho.Name = "btnTopTho";
            this.btnTopTho.Size = new System.Drawing.Size(339, 42);
            this.btnTopTho.TabIndex = 3;
            this.btnTopTho.Text = "Top thợ được yêu thích nhiều nhất";
            this.btnTopTho.Click += new System.EventHandler(this.btnTopTho_Click);
            // 
            // btnThoBiHuy
            // 
            this.btnThoBiHuy.Animated = true;
            this.btnThoBiHuy.BorderRadius = 10;
            this.btnThoBiHuy.BorderThickness = 1;
            this.btnThoBiHuy.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThoBiHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoBiHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoBiHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoBiHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoBiHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThoBiHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnThoBiHuy.ForeColor = System.Drawing.Color.Gray;
            this.btnThoBiHuy.Location = new System.Drawing.Point(402, 72);
            this.btnThoBiHuy.Name = "btnThoBiHuy";
            this.btnThoBiHuy.Size = new System.Drawing.Size(183, 42);
            this.btnThoBiHuy.TabIndex = 4;
            this.btnThoBiHuy.Text = "Top thợ bị hủy";
            this.btnThoBiHuy.Click += new System.EventHandler(this.btnThoBiHuy_Click);
            // 
            // UC_DSThoYeuThich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnThoBiHuy);
            this.Controls.Add(this.btnTopTho);
            this.Controls.Add(this.pnlDanhSachTho);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UC_DSThoYeuThich";
            this.Size = new System.Drawing.Size(1052, 555);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel pnlDanhSachTho;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnTopTho;
        private Guna.UI2.WinForms.Guna2Button btnThoBiHuy;
    }
}
