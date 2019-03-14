using System;
using System.Linq;
using System.Windows.Forms;
using XWingsFactorySoftware.Models;

namespace XWings_MainWindows.Views.Mantenimiento
{
    public partial class AccessLevel : Form
    {
        private xwingsfactoryEntities EF = new xwingsfactoryEntities();
        public AccessLevel()
        {
            InitializeComponent();
        }

        private void AccessLevel_Load(object sender, EventArgs e)
        {
            
        }
    }
}
