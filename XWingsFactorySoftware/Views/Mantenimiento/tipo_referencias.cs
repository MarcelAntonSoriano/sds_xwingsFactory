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



        public tipo_referencias()
        {
            InitializeComponent();
        }

        private void tipo_referencias_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void CargarDataGrid()
        {
            var select = from rt in ef.ReferenceTypes.AsEnumerable()
                         select new
                         {
                             Code = rt.codeReferenceType,
                             Description = rt.descReferenceType
                         };
            dgrid_typeRef.DataSource = select.ToList();


            //  HAY QUE HACER QUE AL SELECCIONAR ALGO, SE META EN LOS TEXTBOXS

            //foreach (Control ctrl in this.Controls)
            //{
            //    if (ctrl.GetType() == typeof(TextBox))
            //    {
            //        ((TextBox)ctrl).DataBindings.Clear();
            //        ctrl.Text = "";
            //        ((TextBox)ctrl).DataBindings.Add("Text", select, (((TextBox)ctrl).Tag).ToString());

            //    }
            //}
        }

        private void dgrid_typeRef_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
        
