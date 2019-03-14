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

        private void Btn_users_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void Btn_instrucciones_Click(object sender, EventArgs e)
        {
            instrucciones_montaje montaje = new instrucciones_montaje();
            montaje.Show();
        }

        private void Btn_ordenes_Click(object sender, EventArgs e)
        {
            ordenes_fabricacion ordenes = new ordenes_fabricacion();
            ordenes.Show();
        }

        private void Btn_proceso_Click(object sender, EventArgs e)
        {
            proceso_fabricacion proceso = new proceso_fabricacion();
            proceso.Show();
        }
    }
}
