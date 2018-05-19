using CafeManager.ManagerForm;
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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void btnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff staffForm = Staff.Instance;
            staffForm.TopLevel = false;
            this.contentPanel.Controls.Add(staffForm);
            staffForm.Dock = DockStyle.Fill;
            staffForm.Show();
        }
    }
}
