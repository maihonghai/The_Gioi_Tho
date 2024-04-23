namespace GUI.All_User_Control
{
    partial class UC_TrangChuTho
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.listDanhMuc = new System.Windows.Forms.ListBox();
            this.pnlDanhSachBaiDang = new System.Windows.Forms.Panel();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // listDanhMuc
            // 
            this.listDanhMuc.FormattingEnabled = true;
            this.listDanhMuc.ItemHeight = 16;
            this.listDanhMuc.Location = new System.Drawing.Point(36, 52);
            this.listDanhMuc.Name = "listDanhMuc";
            this.listDanhMuc.Size = new System.Drawing.Size(304, 68);
            this.listDanhMuc.TabIndex = 37;
            this.listDanhMuc.Visible = false;
            // 
            // pnlDanhSachBaiDang
            // 
            this.pnlDanhSachBaiDang.AutoScroll = true;
            this.pnlDanhSachBaiDang.BackColor = System.Drawing.Color.White;
            this.pnlDanhSachBaiDang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDanhSachBaiDang.Location = new System.Drawing.Point(36, 73);
            this.pnlDanhSachBaiDang.Name = "pnlDanhSachBaiDang";
            this.pnlDanhSachBaiDang.Size = new System.Drawing.Size(1030, 485);
            this.pnlDanhSachBaiDang.TabIndex = 35;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Animated = true;
            this.txtTimKiem.BorderColor = System.Drawing.Color.Gray;
            this.txtTimKiem.BorderRadius = 7;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.IconLeft = global::GUI.Properties.Resources.search;
            this.txtTimKiem.Location = new System.Drawing.Point(36, 11);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "Tìm dịch vụ sửa chữa.\r\n";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(304, 34);
            this.txtTimKiem.TabIndex = 36;
            // 
            // UC_TrangChuTho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.listDanhMuc);
            this.Controls.Add(this.pnlDanhSachBaiDang);
            this.Controls.Add(this.txtTimKiem);
            this.Name = "UC_TrangChuTho";
            this.Size = new System.Drawing.Size(1103, 568);
            this.Load += new System.EventHandler(this.UC_TrangChuTho_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ListBox listDanhMuc;
        private System.Windows.Forms.Panel pnlDanhSachBaiDang;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
    }
}
