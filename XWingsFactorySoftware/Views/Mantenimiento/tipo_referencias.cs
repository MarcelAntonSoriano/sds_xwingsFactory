using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using XWingsFactorySoftware.Models;

namespace XWingsFactorySoftware.Views.Mantenimiento
{
    public partial class tipo_referencias : Form
    {
        public xwingsfactoryEntities ef = new xwingsfactoryEntities();
        public ReferenceTypes ReferenceT = new ReferenceTypes();
        private List<ReferenceTypes> data = new List<ReferenceTypes>();

        private bool isNewRow = false;




        public tipo_referencias()
        {
            InitializeComponent();
        }

        private void tipo_referencias_Load(object sender, EventArgs e)
        {
            //var Estructura = new List<ReferenceTypes>(from s in ef.ReferenceTypes select s).ToList();
            data = ef.ReferenceTypes.ToList();
            dgrid_typeRef.DataSource = data;
            DataBinding();

        }

        private void DataBinding()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    ((TextBox)ctrl).DataBindings.Clear();
                    ctrl.Text = "";
                    ((TextBox)ctrl).DataBindings.Add("Text", data, (((TextBox)ctrl).Tag).ToString());
                }
            }
        }

    }
}

