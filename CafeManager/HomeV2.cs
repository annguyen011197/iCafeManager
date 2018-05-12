using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager
{
    public partial class HomeV2 : Form
    {
        public HomeV2()
        {
            InitializeComponent();
        }

        private void btnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExitHover(object sender, EventArgs e)
        {
            this.btnExit.BackgroundImage = Properties.Resources.exit_hover;
        }

        private void btnExitLeave(object sender, EventArgs e)
        {
            this.btnExit.BackgroundImage = Properties.Resources.exit;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
