using System;
using System.Windows.Forms;

namespace XWings_MainWindows.OtrasGestiones
{
    public partial class escandallo_form : Form
    {
        public escandallo_form()
        {
            InitializeComponent();
        }

        private void escandallo_form_Load(object sender, EventArgs e)
        {
            textBox1.Text = custom_treeview1.SelectedItem;
        }
    }
}
