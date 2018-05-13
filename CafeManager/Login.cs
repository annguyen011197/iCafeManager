using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager
{
   
    public partial class Login : Form
    {
   

       
        public Login()
        {
            InitializeComponent();
            //Elipse.Apply(panel2, 20);
            //Elipse.Apply(this, 20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customPanel1_Resize(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //new HomeV2().Show();
            new Manager().Show();
        }
    }
}
