namespace GUI.All_Tho_Control
{
    partial class UC_DanhGia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DanhGia));
            this.lblTenNguoiDung = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ptbBTrai = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ptbBPhai = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtDangGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ratingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBTrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBPhai)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.AutoSize = false;
            this.lblTenNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.lblTenNguoiDung.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoiDung.ForeColor = System.Drawing.Color.DimGray;
            this.lblTenNguoiDung.Location = new System.Drawing.Point(100, 10);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(305, 37);
            this.lblTenNguoiDung.TabIndex = 2;
            this.lblTenNguoiDung.Text = "Tên người dùng";
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::GUI.Properties.Resources.user;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(66, 10);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(35, 30);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ptbBTrai
            // 
            this.ptbBTrai.FillColor = System.Drawing.Color.Transparent;
            this.ptbBTrai.Image = ((System.Drawing.Image)(resources.GetObject("ptbBTrai.Image")));
            this.ptbBTrai.ImageRotate = 0F;
            this.ptbBTrai.Location = new System.Drawing.Point(110, 223);
            this.ptbBTrai.Name = "ptbBTrai";
            this.ptbBTrai.Size = new System.Drawing.Size(32, 42);
            this.ptbBTrai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBTrai.TabIndex = 54;
            this.ptbBTrai.TabStop = false;
            this.ptbBTrai.Click += new System.EventHandler(this.ptbBTrai_Click);
            // 
            // ptbBPhai
            // 
            this.ptbBPhai.FillColor = System.Drawing.Color.Transparent;
            this.ptbBPhai.Image = ((System.Drawing.Image)(resources.GetObject("ptbBPhai.Image")));
            this.ptbBPhai.ImageRotate = 0F;
            this.ptbBPhai.Location = new System.Drawing.Point(433, 223);
            this.ptbBPhai.Name = "ptbBPhai";
            this.ptbBPhai.Size = new System.Drawing.Size(32, 42);
            this.ptbBPhai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBPhai.TabIndex = 53;
            this.ptbBPhai.TabStop = false;
            this.ptbBPhai.Click += new System.EventHandler(this.ptbBPhai_Click);
            // 
            // txtDangGia
            // 
            this.txtDangGia.Animated = true;
            this.txtDangGia.AutoScroll = true;
            this.txtDangGia.BorderColor = System.Drawing.Color.Gray;
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
            this.txtDangGia.Location = new System.Drawing.Point(66, 77);
            this.txtDangGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDangGia.Multiline = true;
            this.txtDangGia.Name = "txtDangGia";
            this.txtDangGia.PasswordChar = '\0';
            this.txtDangGia.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtDangGia.PlaceholderText = "";
            this.txtDangGia.ReadOnly = true;
            this.txtDangGia.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDangGia.SelectedText = "";
            this.txtDangGia.Size = new System.Drawing.Size(464, 81);
            this.txtDangGia.TabIndex = 60;
            // 
            // lblSao
            // 
            this.lblSao.BackColor = System.Drawing.Color.Transparent;
            this.lblSao.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSao.Location = new System.Drawing.Point(80, 39);
            this.lblSao.Name = "lblSao";
            this.lblSao.Size = new System.Drawing.Size(14, 30);
            this.lblSao.TabIndex = 59;
            this.lblSao.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(148, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 153);
            this.panel1.TabIndex = 58;
            // 
            // ratingStar1
            // 
            this.ratingStar1.FillColor = System.Drawing.Color.Transparent;
            this.ratingStar1.Location = new System.Drawing.Point(110, 44);
            this.ratingStar1.Name = "ratingStar1";
            this.ratingStar1.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ratingStar1.ReadOnly = true;
            this.ratingStar1.Size = new System.Drawing.Size(115, 25);
            this.ratingStar1.TabIndex = 6;
            this.ratingStar1.Value = 4F;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2GradientPanel1.BorderRadius = 5;
            this.guna2GradientPanel1.BorderThickness = 1;
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.ptbBTrai);
            this.guna2GradientPanel1.Controls.Add(this.lblTenNguoiDung);
            this.guna2GradientPanel1.Controls.Add(this.ptbBPhai);
            this.guna2GradientPanel1.Controls.Add(this.txtDangGia);
            this.guna2GradientPanel1.Controls.Add(this.panel1);
            this.guna2GradientPanel1.Controls.Add(this.lblSao);
            this.guna2GradientPanel1.Controls.Add(this.ratingStar1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Snow;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(554, 326);
            this.guna2GradientPanel1.TabIndex = 61;
            // 
            // UC_DanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UC_DanhGia";
            this.Size = new System.Drawing.Size(559, 332);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBTrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBPhai)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenNguoiDung;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private Guna.UI2.WinForms.Guna2PictureBox ptbBTrai;
        private Guna.UI2.WinForms.Guna2PictureBox ptbBPhai;
        private Guna.UI2.WinForms.Guna2TextBox txtDangGia;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSao;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2RatingStar ratingStar1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}
