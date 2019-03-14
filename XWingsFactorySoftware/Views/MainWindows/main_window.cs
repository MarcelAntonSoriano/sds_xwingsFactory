using System;
using System.Windows.Forms;
using XWings_MainWindows.OtrasGestiones;
using XWings_MainWindows.Views.Mantenimiento;
using XWingsFactorySoftware.Views.Mantenimiento;
using XWingsFactorySoftware.Views.OtrasGestiones;

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

        private void Btn_permisos_Click(object sender, EventArgs e)
        {
            AccessLevel acceso = new AccessLevel();
            acceso.Show();
        }

        private void Btn_instrucciones_Click(object sender, EventArgs e)
        {
            instrucciones_montaje instrucciones = new instrucciones_montaje();
            instrucciones.Show();
        }
    }
}
