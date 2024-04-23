namespace GUI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnTho = new Guna.UI2.WinForms.Guna2Button();
            this.btnBaiDang = new Guna.UI2.WinForms.Guna2Button();
            this.btnHoatDong = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.pnlDashBoard = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_DSThoYeuThich1 = new GUI.All_User_Control.UC_DSThoYeuThich();
            this.uC_TrangChuUser1 = new GUI.All_User_Control.uC_TrangChuUser();
            this.uC_HoatDong1 = new GUI.All_User_Control.UC_HoatDong();
            this.uC_BaiDang1 = new GUI.All_User_Control.UC_BaiDang();
            this.uC_TrangChu1 = new GUI.All_User_Control.UC_TrangChu();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.pnlDashBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel1.Controls.Add(this.btnDangXuat);
            this.gunaPanel1.Controls.Add(this.guna2PictureBox1);
            this.gunaPanel1.Controls.Add(this.btnTho);
            this.gunaPanel1.Controls.Add(this.btnBaiDang);
            this.gunaPanel1.Controls.Add(this.btnHoatDong);
            this.gunaPanel1.Controls.Add(this.btnTrangChu);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 30);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(218, 638);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BorderRadius = 10;
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(11, 570);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(197, 40);
            this.btnDangXuat.TabIndex = 10;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(218, 151);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnTho
            // 
            this.btnTho.Animated = true;
            this.btnTho.BorderRadius = 10;
            this.btnTho.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTho.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.btnTho.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTho.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTho.FillColor = System.Drawing.Color.White;
            this.btnTho.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnTho.ForeColor = System.Drawing.Color.Black;
            this.btnTho.Location = new System.Drawing.Point(11, 380);
            this.btnTho.Name = "btnTho";
            this.btnTho.Size = new System.Drawing.Size(197, 45);
            this.btnTho.TabIndex = 6;
            this.btnTho.Text = "Thợ Yêu Thích";
            this.btnTho.Click += new System.EventHandler(this.btnTho_Click);
            // 
            // btnBaiDang
            // 
            this.btnBaiDang.Animated = true;
            this.btnBaiDang.BorderRadius = 10;
            this.btnBaiDang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBaiDang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.btnBaiDang.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnBaiDang.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBaiDang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBaiDang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBaiDang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBaiDang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBaiDang.FillColor = System.Drawing.Color.White;
            this.btnBaiDang.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnBaiDang.ForeColor = System.Drawing.Color.Black;
            this.btnBaiDang.Location = new System.Drawing.Point(11, 313);
            this.btnBaiDang.Name = "btnBaiDang";
            this.btnBaiDang.Size = new System.Drawing.Size(197, 45);
            this.btnBaiDang.TabIndex = 5;
            this.btnBaiDang.Text = "Bài Đăng";
            this.btnBaiDang.Click += new System.EventHandler(this.btnBaiDang_Click);
            // 
            // btnHoatDong
            // 
            this.btnHoatDong.Animated = true;
            this.btnHoatDong.BorderRadius = 10;
            this.btnHoatDong.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHoatDong.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.btnHoatDong.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnHoatDong.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHoatDong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoatDong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoatDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoatDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoatDong.FillColor = System.Drawing.Color.White;
            this.btnHoatDong.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnHoatDong.ForeColor = System.Drawing.Color.Black;
            this.btnHoatDong.Location = new System.Drawing.Point(11, 245);
            this.btnHoatDong.Name = "btnHoatDong";
            this.btnHoatDong.Size = new System.Drawing.Size(197, 45);
            this.btnHoatDong.TabIndex = 4;
            this.btnHoatDong.Text = "Hoạt Động";
            this.btnHoatDong.Click += new System.EventHandler(this.btnHoatDong_Click);
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
            this.btnTrangChu.Location = new System.Drawing.Point(11, 182);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(197, 45);
            this.btnTrangChu.TabIndex = 3;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel2.Controls.Add(this.gunaControlBox3);
            this.gunaPanel2.Controls.Add(this.gunaControlBox2);
            this.gunaPanel2.Controls.Add(this.gunaControlBox1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1385, 33);
            this.gunaPanel2.TabIndex = 2;
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
            // pnlDashBoard
            // 
            this.pnlDashBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDashBoard.Controls.Add(this.uC_DSThoYeuThich1);
            this.pnlDashBoard.Controls.Add(this.uC_TrangChuUser1);
            this.pnlDashBoard.Controls.Add(this.uC_HoatDong1);
            this.pnlDashBoard.Controls.Add(this.uC_BaiDang1);
            this.pnlDashBoard.Controls.Add(this.uC_TrangChu1);
            this.pnlDashBoard.Location = new System.Drawing.Point(281, 73);
            this.pnlDashBoard.Name = "pnlDashBoard";
            this.pnlDashBoard.Size = new System.Drawing.Size(1052, 555);
            this.pnlDashBoard.TabIndex = 3;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // uC_DSThoYeuThich1
            // 
            this.uC_DSThoYeuThich1.BackColor = System.Drawing.Color.White;
            this.uC_DSThoYeuThich1.Location = new System.Drawing.Point(-1, -1);
            this.uC_DSThoYeuThich1.Name = "uC_DSThoYeuThich1";
            this.uC_DSThoYeuThich1.Size = new System.Drawing.Size(1052, 555);
            this.uC_DSThoYeuThich1.TabIndex = 5;
            // 
            // uC_TrangChuUser1
            // 
            this.uC_TrangChuUser1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_TrangChuUser1.Location = new System.Drawing.Point(-1, -1);
            this.uC_TrangChuUser1.Name = "uC_TrangChuUser1";
            this.uC_TrangChuUser1.Size = new System.Drawing.Size(1052, 555);
            this.uC_TrangChuUser1.TabIndex = 4;
            this.uC_TrangChuUser1.Load += new System.EventHandler(this.uC_TrangChuUser1_Load);
            // 
            // uC_HoatDong1
            // 
            this.uC_HoatDong1.BackColor = System.Drawing.SystemColors.Control;
            this.uC_HoatDong1.Location = new System.Drawing.Point(-1, -1);
            this.uC_HoatDong1.Name = "uC_HoatDong1";
            this.uC_HoatDong1.Size = new System.Drawing.Size(1052, 555);
            this.uC_HoatDong1.TabIndex = 2;
            // 
            // uC_BaiDang1
            // 
            this.uC_BaiDang1.BackColor = System.Drawing.Color.White;
            this.uC_BaiDang1.Location = new System.Drawing.Point(-1, -1);
            this.uC_BaiDang1.Name = "uC_BaiDang1";
            this.uC_BaiDang1.Size = new System.Drawing.Size(1052, 555);
            this.uC_BaiDang1.TabIndex = 1;
            // 
            // uC_TrangChu1
            // 
            this.uC_TrangChu1.BackColor = System.Drawing.Color.White;
            this.uC_TrangChu1.Location = new System.Drawing.Point(-1, -1);
            this.uC_TrangChu1.Name = "uC_TrangChu1";
            this.uC_TrangChu1.Size = new System.Drawing.Size(1052, 555);
            this.uC_TrangChu1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1385, 666);
            this.Controls.Add(this.pnlDashBoard);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChuNguoiDung";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.pnlDashBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI2.WinForms.Guna2Button btnTrangChu;
        private Guna.UI2.WinForms.Guna2Button btnTho;
        private Guna.UI2.WinForms.Guna2Button btnBaiDang;
        private Guna.UI2.WinForms.Guna2Button btnHoatDong;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel pnlDashBoard;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Control.UC_TrangChu uC_TrangChu1;
        private All_User_Control.UC_BaiDang uC_BaiDang1;
        private All_User_Control.UC_HoatDong uC_HoatDong1;
        private All_User_Control.UC_ThoYeuThich uC_Tho1;
        private All_User_Control.uC_TrangChuUser uC_TrangChuUser1;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private All_User_Control.UC_DSThoYeuThich uC_DSThoYeuThich1;
    }
}