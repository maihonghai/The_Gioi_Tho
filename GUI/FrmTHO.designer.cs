namespace GUI
{
    partial class FrmTHO
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTHO));
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.btnDanhGia = new Guna.UI2.WinForms.Guna2Button();
            this.btnLichHen = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangBai = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_TrangChuTho1 = new GUI.All_User_Control.UC_TrangChuTho();
            this.uC_XemDanhGia1 = new GUI.All_Tho_Control.UC_XemDanhGia();
            this.uC_ThongKe1 = new GUI.All_Tho_Control.UC_ThongKe();
            this.uC_LichHen1 = new GUI.All_Tho_Control.UC_LichHen();
            this.uC_DangBai1 = new GUI.All_Tho_Control.UC_DangBai();
            this.uC_TaiKhoan1 = new GUI.All_Tho_Control.UC_TaiKhoan();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.AutoSize = true;
            this.gunaPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel2.Controls.Add(this.gunaControlBox3);
            this.gunaPanel2.Controls.Add(this.gunaControlBox2);
            this.gunaPanel2.Controls.Add(this.gunaControlBox1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1385, 34);
            this.gunaPanel2.TabIndex = 3;
            this.gunaPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel2_Paint);
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox3.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox3.IconSize = 15F;
            this.gunaControlBox3.Location = new System.Drawing.Point(1236, 0);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox3.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox3.TabIndex = 2;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(1287, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 1;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1338, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel1.Controls.Add(this.guna2Panel1);
            this.gunaPanel1.Controls.Add(this.btnTrangChu);
            this.gunaPanel1.Controls.Add(this.btnDanhGia);
            this.gunaPanel1.Controls.Add(this.btnLichHen);
            this.gunaPanel1.Controls.Add(this.btnThongKe);
            this.gunaPanel1.Controls.Add(this.btnTaiKhoan);
            this.gunaPanel1.Controls.Add(this.btnDangBai);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 33);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(218, 638);
            this.gunaPanel1.TabIndex = 4;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(218, 143);
            this.guna2Panel1.TabIndex = 21;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(49, 20);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(111, 103);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 13;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Animated = true;
            this.btnTrangChu.BorderRadius = 10;
            this.btnTrangChu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTrangChu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.btnTrangChu.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTrangChu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangChu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrangChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrangChu.FillColor = System.Drawing.Color.White;
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnTrangChu.ForeColor = System.Drawing.Color.Black;
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTrangChu.Location = new System.Drawing.Point(11, 170);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(197, 45);
            this.btnTrangChu.TabIndex = 20;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnDanhGia
            // 
            this.btnDanhGia.Animated = true;
            this.btnDanhGia.BorderRadius = 10;
            this.btnDanhGia.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDanhGia.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.btnDanhGia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDanhGia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDanhGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDanhGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDanhGia.FillColor = System.Drawing.Color.White;
            this.btnDanhGia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnDanhGia.ForeColor = System.Drawing.Color.Black;
            this.btnDanhGia.Image = global::GUI.Properties.Resources.star;
            this.btnDanhGia.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDanhGia.Location = new System.Drawing.Point(11, 368);
            this.btnDanhGia.Name = "btnDanhGia";
            this.btnDanhGia.Size = new System.Drawing.Size(197, 45);
            this.btnDanhGia.TabIndex = 18;
            this.btnDanhGia.Text = "Đánh Giá";
            this.btnDanhGia.Click += new System.EventHandler(this.btnDanhGia_Click);
            // 
            // btnLichHen
            // 
            this.btnLichHen.Animated = true;
            this.btnLichHen.BorderRadius = 10;
            this.btnLichHen.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLichHen.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.btnLichHen.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnLichHen.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLichHen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLichHen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLichHen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLichHen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLichHen.FillColor = System.Drawing.Color.White;
            this.btnLichHen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnLichHen.ForeColor = System.Drawing.Color.Black;
            this.btnLichHen.Image = ((System.Drawing.Image)(resources.GetObject("btnLichHen.Image")));
            this.btnLichHen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLichHen.Location = new System.Drawing.Point(11, 302);
            this.btnLichHen.Name = "btnLichHen";
            this.btnLichHen.Size = new System.Drawing.Size(197, 45);
            this.btnLichHen.TabIndex = 17;
            this.btnLichHen.Text = "Lịch Hẹn";
            this.btnLichHen.Click += new System.EventHandler(this.btnLichHen_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Animated = true;
            this.btnThongKe.BorderRadius = 10;
            this.btnThongKe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThongKe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKe.FillColor = System.Drawing.Color.White;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongKe.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnThongKe.ImageSize = new System.Drawing.Size(25, 25);
            this.btnThongKe.Location = new System.Drawing.Point(11, 443);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(197, 45);
            this.btnThongKe.TabIndex = 15;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Animated = true;
            this.btnTaiKhoan.BorderRadius = 10;
            this.btnTaiKhoan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTaiKhoan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.btnTaiKhoan.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiKhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaiKhoan.FillColor = System.Drawing.Color.White;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTaiKhoan.Location = new System.Drawing.Point(11, 504);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(197, 45);
            this.btnTaiKhoan.TabIndex = 8;
            this.btnTaiKhoan.Text = "Tài Khoản";
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnDangBai
            // 
            this.btnDangBai.Animated = true;
            this.btnDangBai.BorderRadius = 10;
            this.btnDangBai.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDangBai.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.btnDangBai.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDangBai.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangBai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangBai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangBai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangBai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangBai.FillColor = System.Drawing.Color.White;
            this.btnDangBai.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnDangBai.ForeColor = System.Drawing.Color.Black;
            this.btnDangBai.Image = ((System.Drawing.Image)(resources.GetObject("btnDangBai.Image")));
            this.btnDangBai.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangBai.Location = new System.Drawing.Point(11, 236);
            this.btnDangBai.Name = "btnDangBai";
            this.btnDangBai.Size = new System.Drawing.Size(197, 45);
            this.btnDangBai.TabIndex = 5;
            this.btnDangBai.Text = "Đăng Bài";
            this.btnDangBai.Click += new System.EventHandler(this.btnDangBai_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.uC_TrangChuTho1);
            this.panel1.Controls.Add(this.uC_XemDanhGia1);
            this.panel1.Controls.Add(this.uC_ThongKe1);
            this.panel1.Controls.Add(this.uC_LichHen1);
            this.panel1.Controls.Add(this.uC_DangBai1);
            this.panel1.Controls.Add(this.uC_TaiKhoan1);
            this.panel1.Location = new System.Drawing.Point(250, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 574);
            this.panel1.TabIndex = 6;
            // 
            // uC_TrangChuTho1
            // 
            this.uC_TrangChuTho1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_TrangChuTho1.Location = new System.Drawing.Point(0, 3);
            this.uC_TrangChuTho1.Name = "uC_TrangChuTho1";
            this.uC_TrangChuTho1.Size = new System.Drawing.Size(1103, 568);
            this.uC_TrangChuTho1.TabIndex = 11;
            // 
            // uC_XemDanhGia1
            // 
            this.uC_XemDanhGia1.BackColor = System.Drawing.Color.White;
            this.uC_XemDanhGia1.Location = new System.Drawing.Point(0, 3);
            this.uC_XemDanhGia1.Name = "uC_XemDanhGia1";
            this.uC_XemDanhGia1.Size = new System.Drawing.Size(1109, 568);
            this.uC_XemDanhGia1.TabIndex = 10;
            // 
            // uC_ThongKe1
            // 
            this.uC_ThongKe1.Location = new System.Drawing.Point(0, 0);
            this.uC_ThongKe1.Name = "uC_ThongKe1";
            this.uC_ThongKe1.Size = new System.Drawing.Size(1109, 568);
            this.uC_ThongKe1.TabIndex = 9;
            this.uC_ThongKe1.Load += new System.EventHandler(this.uC_ThongKe1_Load);
            // 
            // uC_LichHen1
            // 
            this.uC_LichHen1.Location = new System.Drawing.Point(0, 0);
            this.uC_LichHen1.Name = "uC_LichHen1";
            this.uC_LichHen1.Size = new System.Drawing.Size(1109, 571);
            this.uC_LichHen1.TabIndex = 8;
            this.uC_LichHen1.Load += new System.EventHandler(this.uC_LichHen1_Load);
            // 
            // uC_DangBai1
            // 
            this.uC_DangBai1.BackColor = System.Drawing.Color.White;
            this.uC_DangBai1.Location = new System.Drawing.Point(-3, 0);
            this.uC_DangBai1.Name = "uC_DangBai1";
            this.uC_DangBai1.Size = new System.Drawing.Size(1112, 571);
            this.uC_DangBai1.TabIndex = 7;
            // 
            // uC_TaiKhoan1
            // 
            this.uC_TaiKhoan1.BackColor = System.Drawing.Color.White;
            this.uC_TaiKhoan1.Location = new System.Drawing.Point(6, 3);
            this.uC_TaiKhoan1.Name = "uC_TaiKhoan1";
            this.uC_TaiKhoan1.Size = new System.Drawing.Size(1103, 568);
            this.uC_TaiKhoan1.TabIndex = 6;
            // 
            // FrmTHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1385, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTHO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTHO";
            this.Load += new System.EventHandler(this.FrmTHO_Load);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI2.WinForms.Guna2Button btnTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btnDangBai;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private All_Tho_Control.UC_TaiKhoan uC_TaiKhoan1;
        private Guna.UI2.WinForms.Guna2Button btnLichHen;
        private All_Tho_Control.UC_LichHen uC_LichHen1;
        private All_Tho_Control.UC_DangBai uC_DangBai1;
        private All_Tho_Control.UC_ThongKe uC_ThongKe1;
        private All_Tho_Control.UC_XemDanhGia uC_XemDanhGia1;
        private Guna.UI2.WinForms.Guna2Button btnDanhGia;
        private Guna.UI2.WinForms.Guna2Button btnTrangChu;
        private All_User_Control.UC_TrangChuTho uC_TrangChuTho1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}