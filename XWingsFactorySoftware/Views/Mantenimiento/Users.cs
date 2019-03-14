using System;
using System.Linq;
using System.Windows.Forms;
using XWingsFactorySoftware.Models;

namespace XWingsFactorySoftware.Views.Mantenimiento
{
    public partial class Users : Form
    {
        private xwingsfactoryEntities EF = new xwingsfactoryEntities();
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            Btn_new.Enabled = true;
            RefrescarForm();
        }

        private void RefrescarForm()
        {
            try
            {
                var usuarios = from users in EF.FactoryUsers.AsEnumerable()
                               select users;
                DataGrid_Users.DataSource = usuarios.ToList();
            }
            catch
            {
                Btn_new.Enabled = false;
                MessageBox.Show("No se ha podido establecer conexión con los datos de los Usuarios");
            }
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            FactoryUsers Users = new FactoryUsers();
            if (TextBox_nombre.Text.ToString().Trim().Equals("") || Combo_tipo.SelectedText.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Por favor, rellene los campos correctamente");
                return;
            }
            Users.UserName = TextBox_nombre.Text.ToString().Trim();
            EF.FactoryUsers.Add(Users);
            EF.SaveChanges();
            RefrescarForm();
        }
    }
}
