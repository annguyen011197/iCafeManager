using CafeManager.Controller;
using CafeManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager.GUI.ManagerForm
{
    public partial class EditCustomer : Form
    {
        Customer customer;
        public EditCustomer(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
            tbDisplayName.Text = customer.CustomerName.ToString();
            tbPhone.Text = customer.Phone.ToString();
            tbCMND.Text = customer.IDNumber.ToString();
            rtbAddress.Text = customer.CustomerAddress.ToString();
            rtbNote.Text = customer.Note.ToString();
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbDisplayName.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống");
                return;
            }
            else
            {
                customer.CustomerName = tbDisplayName.Text.Trim();
            }

            customer.Phone = tbPhone.Text.Trim().Length != 0 ? tbPhone.Text.Trim()
                : "None";

            customer.CustomerAddress = rtbAddress.Text.Trim().Length != 0 ? rtbAddress.Text.Trim()
                : "None";
            customer.Note = rtbNote.Text.Trim().Length != 0 ? rtbNote.Text.Trim()
                : "None";
            if (CustomerController.getController().Update(customer))
            {
                MessageBox.Show("Thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("CMND không được trùng");
            }
        }
    }
}
