using CafeManager.GUI.ManagerForm;
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
            //Application.Exit();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff staffForm = Staff.Instance;
            staffForm.TopLevel = false;
            this.contentPanel.Controls.Clear();
            this.contentPanel.Controls.Add(staffForm);
            staffForm.Dock = DockStyle.Fill;
            staffForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Items items = Items.Instance;
            items.TopLevel = false;
            this.contentPanel.Controls.Clear();
            this.contentPanel.Controls.Add(items);
            items.Dock = DockStyle.Fill;
            items.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerForm form = CustomerForm.Instance;
            form.TopLevel = false;
            this.contentPanel.Controls.Clear();
            this.contentPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VoucherForm form = VoucherForm.Instance;
            form.TopLevel = false;
            this.contentPanel.Controls.Clear();
            this.contentPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Statistics form = Statistics.Instance;
            form.TopLevel = false;
            this.contentPanel.Controls.Clear();
            this.contentPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TableForm form = TableForm.Instance;
            form.TopLevel = false;
            this.contentPanel.Controls.Clear();
            this.contentPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
