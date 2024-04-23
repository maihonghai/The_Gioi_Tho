namespace GUI
{
    partial class FormThayDoiNgayGio
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbGio = new System.Windows.Forms.ComboBox();
            this.dtpLichThoDen = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(100, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(371, 50);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Chọn ngày giờ bạn muốn thay đổi";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // cbGio
            // 
            this.cbGio.FormattingEnabled = true;
            this.cbGio.Items.AddRange(new object[] {
            "7:00 AM",
            "7:30 AM",
            "8:00 AM",
            "8:30 AM",
            "9:00 AM",
            "9:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 AM",
            "12:30 AM",
            "1:00 PM",
            "1:30 PM",
            "2:00 PM",
            "2:30 PM",
            "3:00 PM",
            "3:30 PM",
            "4:00 PM",
            "4:30 PM",
            "5:00 PM",
            "5:30 PM",
            "6:00 PM",
            "6:30 PM",
            "7:00 PM",
            "7:30 PM",
            "8:00 PM",
            "8:30 PM",
            "9:00 PM"});
            this.cbGio.Location = new System.Drawing.Point(177, 124);
            this.cbGio.Name = "cbGio";
            this.cbGio.Size = new System.Drawing.Size(121, 24);
            this.cbGio.TabIndex = 14;
            // 
            // dtpLichThoDen
            // 
            this.dtpLichThoDen.Checked = true;
            this.dtpLichThoDen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpLichThoDen.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpLichThoDen.Location = new System.Drawing.Point(177, 65);
            this.dtpLichThoDen.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpLichThoDen.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpLichThoDen.Name = "dtpLichThoDen";
            this.dtpLichThoDen.Size = new System.Drawing.Size(229, 36);
            this.dtpLichThoDen.TabIndex = 13;
            this.dtpLichThoDen.Value = new System.DateTime(2024, 3, 12, 14, 8, 25, 336);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 54);
            this.label14.TabIndex = 11;
            this.label14.Text = "Chọn Giờ:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lịch Thợ Đến:";
            // 
            // btnOK
            // 
            this.btnOK.BorderRadius = 10;
            this.btnOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(378, 162);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 32);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormThayDoiNgayGio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 206);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbGio);
            this.Controls.Add(this.dtpLichThoDen);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "FormThayDoiNgayGio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThayDoiNgayGio";
            this.Load += new System.EventHandler(this.FormThayDoiNgayGio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.ComboBox cbGio;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpLichThoDen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnOK;
    }
}