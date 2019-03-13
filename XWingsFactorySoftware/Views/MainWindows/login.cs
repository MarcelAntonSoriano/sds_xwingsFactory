using System;
using System.Windows.Forms;

namespace XWingsFactorySoftware
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new splash();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
