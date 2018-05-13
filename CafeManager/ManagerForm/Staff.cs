using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager.ManagerForm
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        public static Staff Instance
        {
            get
            {
                return new Staff();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddNew().ShowDialog();
        }
    }
}
