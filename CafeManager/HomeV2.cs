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
            button6.Enabled = false;
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Black;
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

        private void button7_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            button6.BackColor = Color.FromArgb(232, 65, 24);
            button6.ForeColor = Color.FromArgb(240, 240, 240);

            button7.Enabled = false;
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Black;
            flowLayoutPanel2.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button7.Enabled = true;
            button7.BackColor = Color.FromArgb(232, 65, 24);
            button7.ForeColor = Color.FromArgb(240, 240, 240);

            button6.Enabled = false;
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Black;
            flowLayoutPanel1.BringToFront();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
