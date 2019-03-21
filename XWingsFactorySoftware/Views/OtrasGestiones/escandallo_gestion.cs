using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Data.OleDb;
using XWingsFactorySoftware.Models;

namespace Insings
{
    public partial class escandallo_gestion : Form
    {
        public string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Badges.accdb";

        public string queryAlumnos, queryIntegrantesClan, queryComboboxClan;
        public bool bindingActiu = false;

        public string idEscandallo { get; set; }

        public xwingsfactoryEntities ef = new xwingsfactoryEntities();

        public OleDbConnection cn; 
        public OleDbDataAdapter da = new OleDbDataAdapter();
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();

        public escandallo_gestion()
        {
            InitializeComponent();
        }
        private void derecha_Click(object sender, EventArgs e)
        {
            if (alumnos.SelectedIndex != -1)
            {
                integrantesClan.Items.Add(alumnos.SelectedItem);
                alumnos.Items.Remove(alumnos.SelectedItem);
            }
        }

        private void izquierda_Click(object sender, EventArgs e)
        {
            if (integrantesClan.SelectedIndex != -1)
            {
                alumnos.Items.Add(integrantesClan.SelectedItem);
                integrantesClan.Items.Remove(integrantesClan.SelectedItem);
            }
        }

        private void alumnos_MouseDown(object sender, MouseEventArgs e)
        {
            if (alumnos.Items.Count == 0)
                return;

            int index = alumnos.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                string s = alumnos.Items[index].ToString();
                DragDropEffects dde1 = DoDragDrop(s,
                    DragDropEffects.All);

                if (dde1 == DragDropEffects.All)
                {
                    alumnos.Items.RemoveAt(alumnos.IndexFromPoint(e.X, e.Y));
                }
            }
        }

        private void integrantesClan_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void integrantesClan_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(
                    DataFormats.StringFormat);

                integrantesClan.Items.Add(str);
            }
        }

        private void integrantesClan_MouseDown(object sender, MouseEventArgs e)
        {
            if (integrantesClan.Items.Count == 0)
                return;

            int index = integrantesClan.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                string s = integrantesClan.Items[index].ToString();
                DragDropEffects dde1 = DoDragDrop(s,
                    DragDropEffects.All);

                if (dde1 == DragDropEffects.All)
                {
                    // Peta
                    integrantesClan.Items.RemoveAt(alumnos.IndexFromPoint(e.X, e.Y));
                }
            }
        }

        private void alumnos_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void alumnos_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(
                    DataFormats.StringFormat);

                alumnos.Items.Add(str);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string id_selecccionado = comboClan.SelectedText.ToString();

            try
            {
                cn = new OleDbConnection(connectionString);

                cn.Open();

                // Alumnos
                queryAlumnos = "SELECT Users.DescUser FROM UserTypes INNER JOIN(Users INNER JOIN ClanMembers ON Users.IdUser = ClanMembers.idUser) ON UserTypes.IdUserType = Users.idUserType WHERE(((IsNull([ClanMembers].[idClan])) <> False) AND((UserTypes.CodeType) <> 'PROF')); ";

                using (OleDbCommand command = new OleDbCommand(queryAlumnos, cn))
                {
                    da.SelectCommand = command;

                    da.Fill(ds);

                    dt = ds.Tables[0];

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        alumnos.Items.Add(dt.Rows[i][0].ToString());
                    }
                }

                ds.Reset();
                dt.Reset();

                string nombrePartes = (from b in ef.References
                                       where b.idReference.ToString() == id_selecccionado
                                       select b.codeReference).ToArray()[0];


                // Combobox de los clanes

                string comboboxFill = (from b in ef.References
                                       where b.idReference.ToString() == idEscandallo
                                       select b.codeReference).ToArray()[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                      comboClan.Items.Add(dt.Rows[i][0].ToString());
                }
          
                comboClan.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void comboClan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn = new OleDbConnection(connectionString);

            cn.Open();

            ds.Reset();
            dt.Reset();
            integrantesClan.Items.Clear();

            // Integrantes del clan
            queryIntegrantesClan = "SELECT Users.DescUser FROM UserTypes INNER JOIN (Users INNER JOIN (Clans INNER JOIN ClanMembers ON Clans.IdClan = ClanMembers.idClan) ON Users.IdUser = ClanMembers.idUser) ON UserTypes.IdUserType = Users.idUserType WHERE(((IsNull([ClanMembers].[idClan])) <> True) AND((UserTypes.CodeType) <> 'PROF') AND ((Clans.ClanName)='" + comboClan.Text + "'));";

            using (OleDbCommand command = new OleDbCommand(queryIntegrantesClan, cn))
            {
                da.SelectCommand = command;

                da.Fill(ds);

                dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    integrantesClan.Items.Add(dt.Rows[i][0].ToString());
                }
            }

            ds.Reset();
            dt.Reset();
            cn.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            cn = new OleDbConnection(connectionString);

            cn.Open();           

            // Afegir nous integrants al clan
            afegirIntegrantsClan(cn);


            cn.Close();
        }

        public void afegirIntegrantsClan(OleDbConnection cn)
        {
            string idClan;

            //comboClan.Items.Insert(0, "-- Select --");

            if (comboClan.Text != "")
            {
                try
                {
                    // Agafa el idClan
                    string querySelectIdClan = "SELECT IdClan FROM Clans WHERE ((Clans.ClanName)='" + comboClan.Items[comboClan.SelectedIndex].ToString() + "');";

                    using (OleDbCommand command = new OleDbCommand(querySelectIdClan, cn))
                    {
                        da.SelectCommand = command;

                        da.Fill(ds);

                        dt = ds.Tables[0];

                        idClan = dt.Rows[0][0].ToString();
                    }

                    ds.Reset();
                    dt.Reset();

                    // Quan treus a gent del clan
                    string queryUpdateNull = "UPDATE ClanMembers SET ClanMembers.idClan = NULL WHERE ((ClanMembers.idClan) = " + idClan + ");";

                    using (OleDbConnection conexion1 = new OleDbConnection(connectionString))
                    {
                        conexion1.Open();
                        OleDbCommand update = new OleDbCommand(queryUpdateNull, conexion1);

                        update.ExecuteNonQuery();

                    }


                    // Afageixes gent al clan
                    foreach (string listItems in integrantesClan.Items)
                    {
                        string queryUpdateClanMembers = "UPDATE ClanMembers INNER JOIN Users ON ClanMembers.idUser = Users.IdUser SET ClanMembers.idClan = " + idClan + " WHERE((Users.DescUser) = '" + listItems + "');";

                        using (OleDbConnection conexion1 = new OleDbConnection(connectionString))
                        {
                            conexion1.Open();
                            OleDbCommand update = new OleDbCommand(queryUpdateClanMembers, conexion1);

                            update.ExecuteNonQuery();

                        }
                    }

                    // Igual dentro del bucle 
                    ds.Reset();
                    dt.Reset();
                    cn.Close();

                    MessageBox.Show("S'ha guardat correctament");
                }
                catch
                {
                    MessageBox.Show("No s'ha guardat correctament");
                }
            }
        }
    }
}