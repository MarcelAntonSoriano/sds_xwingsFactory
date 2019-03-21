using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using XWingsFactorySoftware.Models;


namespace XWings_MainWindows.OtrasGestiones
{
    public partial class escandallo_form : Form
    {
        public xwingsfactoryEntities ef = new xwingsfactoryEntities();
        private IDictionary<string, IEnumerable<string>> dict_escandallo;
        public escandallo_form()
        {
            InitializeComponent();
        }

        private void escandallo_form_Load(object sender, EventArgs e)
        {
            CargarForm();
        }
        private void CargarForm()
        {
            dict_escandallo = ObtenerDatosEscandallo();
            if (dict_escandallo != null)
            {
                TreeNode nave = new TreeNode("Nave XWing");
                treeView.Nodes.Add(nave);

                foreach (var elemento in dict_escandallo)
                {
                    TreeNode item = new TreeNode(elemento.Key);
                    treeView.Nodes.Add(item);
                    foreach (string value in elemento.Value)
                        item.Nodes.Add(value);
                }
            }
        }
        private IDictionary<string, IEnumerable<string>> ObtenerDatosEscandallo()
        {
            IDictionary<string, IEnumerable<string>> dict_final = new Dictionary<string, IEnumerable<string>>();
            try
            {
                IEnumerable<string> producto_intermedio_ids = from b in ef.Structure.AsEnumerable()
                                                              where b.idReferenceFinal == 21
                                                              select b.idReferencePart.ToString();
                foreach (string id in producto_intermedio_ids)
                {
                    string parte_intermedia = (from a in ef.References
                                               where a.idReference.ToString() == id.ToString()
                                               select a.descReference).ToArray()[0];
                    IEnumerable<string> producto_primo = from c in ef.Structure.AsEnumerable()
                                                         join d in ef.References.AsEnumerable()
                                                         on c.idReferencePart equals d.idReference
                                                         where c.idReferenceFinal.ToString() == id
                                                         select d.descReference.ToString();
                    dict_final.Add(parte_intermedia, producto_primo);
                }
            }
            catch
            {
                dict_final = null;
                MessageBox.Show("Error al Obtener los Datos de la Estructura");
            }
            return dict_final;
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string selected_item = e.Node.Text;
            string code = (from b in ef.References
                           where b.descReference.ToString() == selected_item
                           select b.codeReference).ToArray()[0];
            string photo_path = (from b in ef.References
                                where b.descReference.ToString() == selected_item
                                select b.Photo).ToArray()[0];
            txtBox_Code.Text = code;
            txtBox_Desc.Text = e.Node.Text;
            pictureBox1.ImageLocation = photo_path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form();
            frm.Show();
        }
    }
}
