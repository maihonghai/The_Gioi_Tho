namespace GUI
{
    partial class FormXemDanhGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXemDanhGia));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtDangGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTenNguoiDung = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ratingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.ThongTin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ptbBPhai = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ptbBTrai = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBPhai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBTrai)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.ptbBTrai);
            this.guna2Panel1.Controls.Add(this.ptbBPhai);
            this.guna2Panel1.Controls.Add(this.txtDangGia);
            this.guna2Panel1.Controls.Add(this.lblSao);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Controls.Add(this.lblTenNguoiDung);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel1.Controls.Add(this.ratingStar1);
            this.guna2Panel1.Location = new System.Drawing.Point(1, 36);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(555, 377);
            this.guna2Panel1.TabIndex = 0;
            // 
            // txtDangGia
            // 
            this.txtDangGia.Animated = true;
            this.txtDangGia.AutoScroll = true;
            this.txtDangGia.BorderRadius = 10;
            this.txtDangGia.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtDangGia.BorderThickness = 2;
            this.txtDangGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDangGia.DefaultText = "";
            this.txtDangGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDangGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDangGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDangGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDangGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDangGia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDangGia.ForeColor = System.Drawing.Color.Black;
            this.txtDangGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDangGia.Location = new System.Drawing.Point(21, 101);
            this.txtDangGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDangGia.Multiline = true;
            this.txtDangGia.Name = "txtDangGia";
            this.txtDangGia.PasswordChar = '\0';
            this.txtDangGia.PlaceholderText = "";
            this.txtDangGia.ReadOnly = true;
            this.txtDangGia.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDangGia.SelectedText = "";
            this.txtDangGia.Size = new System.Drawing.Size(518, 81);
            this.txtDangGia.TabIndex = 52;
            this.txtDangGia.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // lblSao
            // 
            this.lblSao.BackColor = System.Drawing.Color.Transparent;
            this.lblSao.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSao.Location = new System.Drawing.Point(21, 63);
            this.lblSao.Name = "lblSao";
            this.lblSao.Size = new System.Drawing.Size(14, 30);
            this.lblSao.TabIndex = 51;
            this.lblSao.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(140, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 153);
            this.panel1.TabIndex = 49;
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.AutoSize = false;
            this.lblTenNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.lblTenNguoiDung.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTenNguoiDung.Location = new System.Drawing.Point(81, 16);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(326, 43);
            this.lblTenNguoiDung.TabIndex = 48;
            this.lblTenNguoiDung.Text = "Tên người dùng";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::GUI.Properties.Resources.user;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(21, 3);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(47, 49);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 47;
            this.guna2PictureBox2.TabStop = false;
            // 
            // ratingStar1
            // 
            this.ratingStar1.Location = new System.Drawing.Point(56, 65);
            this.ratingStar1.Name = "ratingStar1";
            this.ratingStar1.RatingColor = System.Drawing.Color.Yellow;
            this.ratingStar1.ReadOnly = true;
            this.ratingStar1.Size = new System.Drawing.Size(184, 28);
            this.ratingStar1.TabIndex = 46;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.AutoSize = true;
            this.gunaPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel2.Controls.Add(this.gunaControlBox1);
            this.gunaPanel2.Controls.Add(this.ThongTin);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(557, 34);
            this.gunaPanel2.TabIndex = 53;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(510, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // ThongTin
            // 
            this.ThongTin.AutoSize = false;
            this.ThongTin.BackColor = System.Drawing.Color.Transparent;
            this.ThongTin.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThongTin.ForeColor = System.Drawing.Color.Blue;
            this.ThongTin.Location = new System.Drawing.Point(140, -1);
            this.ThongTin.Name = "ThongTin";
            this.ThongTin.Size = new System.Drawing.Size(414, 30);
            this.ThongTin.TabIndex = 3;
            this.ThongTin.Text = "Đánh Giá Của Khách Hàng ";
            // 
            // ptbBPhai
            // 
            this.ptbBPhai.Image = ((System.Drawing.Image)(resources.GetObject("ptbBPhai.Image")));
            this.ptbBPhai.ImageRotate = 0F;
            this.ptbBPhai.Location = new System.Drawing.Point(425, 247);
            this.ptbBPhai.Name = "ptbBPhai";
            this.ptbBPhai.Size = new System.Drawing.Size(32, 42);
            this.ptbBPhai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBPhai.TabIndex = 0;
            this.ptbBPhai.TabStop = false;
            this.ptbBPhai.Click += new System.EventHandler(this.ptbPhai_Click);
            // 
            // ptbBTrai
            // 
            this.ptbBTrai.Image = ((System.Drawing.Image)(resources.GetObject("ptbBTrai.Image")));
            this.ptbBTrai.ImageRotate = 0F;
            this.ptbBTrai.Location = new System.Drawing.Point(102, 247);
            this.ptbBTrai.Name = "ptbBTrai";
            this.ptbBTrai.Size = new System.Drawing.Size(32, 42);
            this.ptbBTrai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBTrai.TabIndex = 1;
            this.ptbBTrai.TabStop = false;
            this.ptbBTrai.Click += new System.EventHandler(this.ptbTrai_Click);
            // 
            // FormXemDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(557, 414);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormXemDanhGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormXemDanhGia";
            this.Load += new System.EventHandler(this.FormXemDanhGia_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBPhai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBTrai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSao;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenNguoiDung;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2RatingStar ratingStar1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel ThongTin;
        private Guna.UI2.WinForms.Guna2TextBox txtDangGia;
        private Guna.UI2.WinForms.Guna2PictureBox ptbBTrai;
        private Guna.UI2.WinForms.Guna2PictureBox ptbBPhai;
    }
}