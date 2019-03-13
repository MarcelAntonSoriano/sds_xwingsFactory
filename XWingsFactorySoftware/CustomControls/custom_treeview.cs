using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace XWings_MainWindows.CustomControls
{
    public partial class custom_treeview : UserControl
    {
        //Propiedades
        private string _selected_item;
        public string SelectedItem
        {
            get { return _selected_item; }
            set
            {
                if (treeView.SelectedNode != null) _selected_item = treeView.SelectedNode.Text;
                else _selected_item = value;
            }
        }

        //Aquí hay que obtener Diccionario de otra clase
        IDictionary<string, List<string>> dict = new Dictionary<string, List<string>>()
        {
            { "Item 1", new List<string> {"Value 1", "Value 2", "Value 3"} },
            { "Item 2", new List<string> {"Value 1"} },
            { "Item 3", new List<string> {"Value 1", "Value 2"} }
        };

        //Llenamos el TreeView al Iniciar y Escogemos Elemento Seleccionado
        public custom_treeview()
        {
            InitializeComponent();

            foreach (var elemento in dict)
            {
                TreeNode item = new TreeNode(elemento.Key);
                treeView.Nodes.Add(item);
                foreach (string value in elemento.Value)
                {
                    TreeNode val = new TreeNode(value);
                    item.Nodes.Add(val);
                }
            }
        }
        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelectedItem = treeView.SelectedNode.Text;
        }
    }
}
