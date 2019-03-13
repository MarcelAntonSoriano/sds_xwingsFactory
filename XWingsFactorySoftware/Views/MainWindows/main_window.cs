using System;
using System.Windows.Forms;
using XWings_MainWindows.OtrasGestiones;

namespace XWingsFactorySoftware
{
    public partial class main_window : Form
    {
        public main_window()
        {
            InitializeComponent();
        }

        private void Btn_escandallo_Click(object sender, EventArgs e)
        {
            escandallo_form escandallo = new escandallo_form();
            escandallo.Show();
        }
    }
}
