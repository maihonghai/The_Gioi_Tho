namespace GUI
{
    partial class FormDanhGia
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
            this.ratingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtNoiDungDanhGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuuDanhGia = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ratingStar1
            // 
            this.ratingStar1.Location = new System.Drawing.Point(92, 175);
            this.ratingStar1.Name = "ratingStar1";
            this.ratingStar1.Size = new System.Drawing.Size(355, 51);
            this.ratingStar1.TabIndex = 27;
            this.ratingStar1.UseWaitCursor = true;
           // this.ratingStar1.ValueChanged += new System.EventHandler(this.guna2RatingStar1_ValueChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(34, 250);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(273, 34);
            this.guna2HtmlLabel1.TabIndex = 28;
            this.guna2HtmlLabel1.Text = "Đánh giá của bạn:";
           // this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(34, 429);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(258, 32);
            this.guna2HtmlLabel2.TabIndex = 28;
            this.guna2HtmlLabel2.Text = "Thêm hình ảnh mô tả:";
           // this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::GUI.Properties.Resources.user;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(203, 12);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(140, 115);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 30;
            this.guna2PictureBox2.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 10;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(232, 429);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 29);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtNoiDungDanhGia
            // 
            this.txtNoiDungDanhGia.BorderRadius = 10;
            this.txtNoiDungDanhGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiDungDanhGia.DefaultText = "";
            this.txtNoiDungDanhGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoiDungDanhGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoiDungDanhGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDungDanhGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDungDanhGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDungDanhGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNoiDungDanhGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDungDanhGia.Location = new System.Drawing.Point(34, 282);
            this.txtNoiDungDanhGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoiDungDanhGia.Name = "txtNoiDungDanhGia";
            this.txtNoiDungDanhGia.PasswordChar = '\0';
            this.txtNoiDungDanhGia.PlaceholderText = "";
            this.txtNoiDungDanhGia.SelectedText = "";
            this.txtNoiDungDanhGia.Size = new System.Drawing.Size(475, 126);
            this.txtNoiDungDanhGia.TabIndex = 33;
            //this.txtNoiDungDanhGia.TextChanged += new System.EventHandler(this.txtNoiDungDanhGia_TextChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(232, 133);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(143, 43);
            this.guna2HtmlLabel3.TabIndex = 34;
            this.guna2HtmlLabel3.Text = "Tên người dùng";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(34, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 139);
            this.panel1.TabIndex = 35;
            // 
            // btnLuuDanhGia
            // 
            this.btnLuuDanhGia.BorderRadius = 10;
            this.btnLuuDanhGia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuDanhGia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuDanhGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuDanhGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuDanhGia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuuDanhGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuuDanhGia.ForeColor = System.Drawing.Color.White;
            this.btnLuuDanhGia.Location = new System.Drawing.Point(179, 626);
            this.btnLuuDanhGia.Name = "btnLuuDanhGia";
            this.btnLuuDanhGia.Size = new System.Drawing.Size(180, 45);
            this.btnLuuDanhGia.TabIndex = 36;
            this.btnLuuDanhGia.Text = "Lưu đánh giá";
            this.btnLuuDanhGia.Click += new System.EventHandler(this.btnLuuDanhGia_Click);
            // 
            // FormDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 683);
            this.Controls.Add(this.btnLuuDanhGia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtNoiDungDanhGia);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.ratingStar1);
            this.Name = "FormDanhGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDanhGia";
            this.Load += new System.EventHandler(this.FormDanhGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2RatingStar ratingStar1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2TextBox txtNoiDungDanhGia;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnLuuDanhGia;
    }
}