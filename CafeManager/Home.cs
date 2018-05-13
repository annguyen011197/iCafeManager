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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExitHover(object sender, EventArgs e)
        {
            this.btnExit.BackColor = Color.Red;
        }

        private void btnExitLeave(object sender, EventArgs e)
        {
            this.btnExit.BackColor = Color.Gray;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
