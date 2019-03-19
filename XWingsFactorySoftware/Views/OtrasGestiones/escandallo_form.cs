using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XWingsFactorySoftware.Models;


namespace XWings_MainWindows.OtrasGestiones
{
    public partial class escandallo_form : Form
    {
        public xwingsfactoryEntities ef = new xwingsfactoryEntities();
        public escandallo_form()
        {
            InitializeComponent();
        }

        private void escandallo_form_Load(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();

            var producto_final = from b in ef.References.AsEnumerable()
                                 where b.idReferenceType == 11
                                 select b.codeReference;

            var producto_intermedio = from b in ef.References.AsEnumerable()
                                      where b.idReferenceType == 12
                                      select b.codeReference;

            foreach(var value in producto_intermedio)
            {
                lista.Add(value.ToString());
            }

            foreach (var value in producto_final) {
                custom_treeview1.dict.Add(value.ToString(),lista);
            }


            textBox1.Text = custom_treeview1.SelectedItem;
        }
    }
}
