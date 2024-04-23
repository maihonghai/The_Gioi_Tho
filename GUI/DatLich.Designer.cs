namespace GUI
{
    partial class DatLich
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIDBaiDang = new System.Windows.Forms.Label();
            this.cbGio = new System.Windows.Forms.ComboBox();
            this.btnDatLichNgay = new Guna.UI2.WinForms.Guna2Button();
            this.dtpLichThoDen = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtGiaTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMoTaChiTiet = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblIDBaiDang);
            this.panel1.Controls.Add(this.cbGio);
            this.panel1.Controls.Add(this.btnDatLichNgay);
            this.panel1.Controls.Add(this.dtpLichThoDen);
            this.panel1.Controls.Add(this.txtGiaTien);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMoTaChiTiet);
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 527);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblIDBaiDang
            // 
            this.lblIDBaiDang.AutoSize = true;
            this.lblIDBaiDang.Location = new System.Drawing.Point(4, 4);
            this.lblIDBaiDang.Name = "lblIDBaiDang";
            this.lblIDBaiDang.Size = new System.Drawing.Size(0, 16);
            this.lblIDBaiDang.TabIndex = 11;
            // 
            // cbGio
            // 
            this.cbGio.FormattingEnabled = true;
            this.cbGio.Location = new System.Drawing.Point(171, 125);
            this.cbGio.Name = "cbGio";
            this.cbGio.Size = new System.Drawing.Size(121, 24);
            this.cbGio.TabIndex = 10;
            this.cbGio.SelectedIndexChanged += new System.EventHandler(this.cbGio_SelectedIndexChanged);
            // 
            // btnDatLichNgay
            // 
            this.btnDatLichNgay.BorderRadius = 10;
            this.btnDatLichNgay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatLichNgay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatLichNgay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatLichNgay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatLichNgay.FillColor = System.Drawing.Color.LimeGreen;
            this.btnDatLichNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLichNgay.ForeColor = System.Drawing.Color.White;
            this.btnDatLichNgay.Location = new System.Drawing.Point(66, 428);
            this.btnDatLichNgay.Name = "btnDatLichNgay";
            this.btnDatLichNgay.Size = new System.Drawing.Size(229, 72);
            this.btnDatLichNgay.TabIndex = 6;
            this.btnDatLichNgay.Text = "Đặt Lịch Ngay";
            this.btnDatLichNgay.TextChanged += new System.EventHandler(this.btnDatLichNgay_Click);
            this.btnDatLichNgay.Click += new System.EventHandler(this.btnDatLichNgay_Click);
            // 
            // dtpLichThoDen
            // 
            this.dtpLichThoDen.Checked = true;
            this.dtpLichThoDen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpLichThoDen.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpLichThoDen.Location = new System.Drawing.Point(63, 63);
            this.dtpLichThoDen.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpLichThoDen.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpLichThoDen.Name = "dtpLichThoDen";
            this.dtpLichThoDen.Size = new System.Drawing.Size(229, 36);
            this.dtpLichThoDen.TabIndex = 5;
            this.dtpLichThoDen.Value = new System.DateTime(2024, 3, 12, 14, 8, 25, 336);
            this.dtpLichThoDen.ValueChanged += new System.EventHandler(this.dtpLichThoDen_ValueChanged);
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.BorderRadius = 17;
            this.txtGiaTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTien.DefaultText = "200.000";
            this.txtGiaTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaTien.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtGiaTien.ForeColor = System.Drawing.Color.IndianRed;
            this.txtGiaTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaTien.Location = new System.Drawing.Point(63, 371);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.PasswordChar = '\0';
            this.txtGiaTien.PlaceholderText = "";
            this.txtGiaTien.ReadOnly = true;
            this.txtGiaTien.SelectedText = "";
            this.txtGiaTien.Size = new System.Drawing.Size(229, 37);
            this.txtGiaTien.TabIndex = 3;
            this.txtGiaTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGiaTien.TextChanged += new System.EventHandler(this.guna2TextBox5_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(63, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 19);
            this.label14.TabIndex = 2;
            this.label14.Text = "Chọn Giờ:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(58, 185);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "Mô tả chi tiết:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ghi Chú:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lịch Thợ Đến:";
            // 
            // txtMoTaChiTiet
            // 
            this.txtMoTaChiTiet.BorderRadius = 17;
            this.txtMoTaChiTiet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTaChiTiet.DefaultText = "";
            this.txtMoTaChiTiet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTaChiTiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTaChiTiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTaChiTiet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTaChiTiet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTaChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTaChiTiet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTaChiTiet.Location = new System.Drawing.Point(62, 208);
            this.txtMoTaChiTiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoTaChiTiet.Name = "txtMoTaChiTiet";
            this.txtMoTaChiTiet.PasswordChar = '\0';
            this.txtMoTaChiTiet.PlaceholderText = "";
            this.txtMoTaChiTiet.SelectedText = "";
            this.txtMoTaChiTiet.Size = new System.Drawing.Size(229, 37);
            this.txtMoTaChiTiet.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BorderRadius = 17;
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.DefaultText = "";
            this.txtGhiChu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGhiChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGhiChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.Location = new System.Drawing.Point(63, 295);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PasswordChar = '\0';
            this.txtGhiChu.PlaceholderText = "";
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.Size = new System.Drawing.Size(229, 37);
            this.txtGhiChu.TabIndex = 3;
            // 
            // DatLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 556);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DatLich";
            this.Text = "DatLich";
            this.Load += new System.EventHandler(this.DatLich_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIDBaiDang;
        private System.Windows.Forms.ComboBox cbGio;
        private Guna.UI2.WinForms.Guna2Button btnDatLichNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpLichThoDen;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaTien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTaChiTiet;
        private Guna.UI2.WinForms.Guna2TextBox txtGhiChu;
    }
}