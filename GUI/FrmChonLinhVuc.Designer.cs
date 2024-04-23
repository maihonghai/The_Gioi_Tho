namespace GUI
{
    partial class FrmChonLinhVuc
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
            this.uC_TrangChu1 = new GUI.All_User_Control.UC_TrangChu();
            this.SuspendLayout();
            // 
            // uC_TrangChu1
            // 
            this.uC_TrangChu1.BackColor = System.Drawing.Color.White;
            this.uC_TrangChu1.Location = new System.Drawing.Point(1, -1);
            this.uC_TrangChu1.Name = "uC_TrangChu1";
            this.uC_TrangChu1.Size = new System.Drawing.Size(1052, 555);
            this.uC_TrangChu1.TabIndex = 0;
            this.uC_TrangChu1.Load += new System.EventHandler(this.uC_TrangChu1_Load);
            // 
            // FrmChonLinhVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 554);
            this.Controls.Add(this.uC_TrangChu1);
            this.Name = "FrmChonLinhVuc";
            this.Text = "FrmChonLinhVuc";
            this.Load += new System.EventHandler(this.FrmChonLinhVuc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private All_User_Control.UC_TrangChu uC_TrangChu1;
    }
}