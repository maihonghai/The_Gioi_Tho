namespace GUI.All_User_Control
{
    partial class UC_BaiDang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BaiDang));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLocTheoDanhMuc = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDanhSachBaiDang = new System.Windows.Forms.Panel();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.btnQuayLai = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.pnlDanhSachBaiDang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.pnlDanhSachBaiDang);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1052, 555);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 79);
            this.panel2.TabIndex = 7;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.btnQuayLai);
            this.guna2Panel1.Controls.Add(this.btnLocTheoDanhMuc);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 79);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnLocTheoDanhMuc
            // 
            this.btnLocTheoDanhMuc.BorderRadius = 15;
            this.btnLocTheoDanhMuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLocTheoDanhMuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLocTheoDanhMuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLocTheoDanhMuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLocTheoDanhMuc.FillColor = System.Drawing.Color.LightGreen;
            this.btnLocTheoDanhMuc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocTheoDanhMuc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLocTheoDanhMuc.Location = new System.Drawing.Point(9, 14);
            this.btnLocTheoDanhMuc.Name = "btnLocTheoDanhMuc";
            this.btnLocTheoDanhMuc.Size = new System.Drawing.Size(180, 45);
            this.btnLocTheoDanhMuc.TabIndex = 0;
            this.btnLocTheoDanhMuc.Text = "Lọc Theo Danh Mục";
            this.btnLocTheoDanhMuc.Click += new System.EventHandler(this.btnLocTheoDanhMuc_Click);
            // 
            // pnlDanhSachBaiDang
            // 
            this.pnlDanhSachBaiDang.Controls.Add(this.gunaVScrollBar1);
            this.pnlDanhSachBaiDang.Location = new System.Drawing.Point(0, 66);
            this.pnlDanhSachBaiDang.Name = "pnlDanhSachBaiDang";
            this.pnlDanhSachBaiDang.Size = new System.Drawing.Size(1052, 489);
            this.pnlDanhSachBaiDang.TabIndex = 6;
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(1020, 19);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.gunaVScrollBar1.Size = new System.Drawing.Size(10, 447);
            this.gunaVScrollBar1.TabIndex = 5;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            this.gunaVScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gunaVScrollBar1_Scroll);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnQuayLai.BorderRadius = 15;
            this.btnQuayLai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuayLai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuayLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuayLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuayLai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnQuayLai.Image = ((System.Drawing.Image)(resources.GetObject("btnQuayLai.Image")));
            this.btnQuayLai.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuayLai.Location = new System.Drawing.Point(9, 14);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(180, 45);
            this.btnQuayLai.TabIndex = 1;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.Visible = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // UC_BaiDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Name = "UC_BaiDang";
            this.Size = new System.Drawing.Size(1052, 555);
            this.Load += new System.EventHandler(this.UC_BaiDang_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.pnlDanhSachBaiDang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private System.Windows.Forms.Panel pnlDanhSachBaiDang;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnLocTheoDanhMuc;
        private Guna.UI2.WinForms.Guna2Button btnQuayLai;
    }
}
