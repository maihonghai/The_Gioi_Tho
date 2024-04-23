using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.All_Login_Control
{
    public partial class UC_DangKyND : UserControl
    {

        public event EventHandler BackClicked;
        public event EventHandler XacNhanClicked;
        public UC_DangKyND()
        {
            InitializeComponent();
        }
        public string HovaTenText
        {
            get { return txtHovaTen.Text; }
            set { txtHovaTen.Text = value; }
        }
        public string SoDTText
        {
            get { return txtSodt.Text; }
            set { txtSodt.Text = value; }
        }
        public string DiaChiText
        {
            get { return txtDiaChi.Text; }
            set { txtDiaChi.Text = value; }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            XacNhanClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
