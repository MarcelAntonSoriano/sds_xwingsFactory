using System;
using System.Windows.Forms;

namespace XWingsFactorySoftware
{
    public partial class splash : Form
    {
        private Timer timer;

        public splash()
        {
            InitializeComponent();
        }
        //Carga el Timer del Splash
        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = (3 * 1000); // 3 secs
            timer.Tick += new EventHandler(MyTimer_Tick);
            timer.Start();
        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new main_window();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            timer.Stop();
        }
    }
}
