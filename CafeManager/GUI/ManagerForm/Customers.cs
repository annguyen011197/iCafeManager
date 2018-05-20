using CafeManager.Controller;
using CafeManager.Model;
using CafeManager.Utils;
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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            dgvCus.RowHeadersVisible = false;
            dgvCus.AllowUserToAddRows = false;
            UpdateData();

        }
        
        public void UpdateData()
        {
            dgvCus.DataSource = CustomerController.getController().FindAll();
            dgvCus.Columns["CustomerName"].HeaderText = "Tên khách hàng";
            dgvCus.Columns["CustomerName"].Width = 200;
            dgvCus.Columns["Phone"].HeaderText = "Số điện thoại";
            dgvCus.Columns["CustomerAddress"].Visible = false;
            dgvCus.Columns["Note"].Visible = false;
            dgvCus.Columns["IDNumber"].HeaderText = "CMND";
        }

        public static CustomerForm Instance
        {
            get
            {
                return new CustomerForm();
            }
        }

        private void selection_change(object sender, EventArgs e)
        {
            var row = dgvCus.CurrentRow;
            Updateform(row);

        }

        private void Updateform(DataGridViewRow row)
        {
            if (row != null)
            {
                lbFullName.Text = row.Cells["CustomerName"].Value.ToString();
                lbPhone.Text = row.Cells["Phone"].Value.ToString();
                lbCMND.Text = row.Cells["IDNumber"].Value.ToString();
                rtbAdress.Text = row.Cells["CustomerAddress"].Value.ToString();
                rtbNote.Text = row.Cells["Note"].Value.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddNewCustomer().ShowDialog();
            UpdateData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var row = dgvCus.CurrentRow;
            Customer customer = new Customer();
            customer.ID = (int)row.Cells["ID"].Value;
            customer.CustomerName = row.Cells["CustomerName"].Value.ToString();
            customer.Phone = row.Cells["Phone"].Value.ToString();
            customer.CustomerAddress = row.Cells["CustomerAddress"].Value.ToString();
            customer.Note = row.Cells["Note"].Value.ToString();
            customer.IDNumber = row.Cells["IDNumber"].Value.ToString();
            CustomerController.getController().Delete(customer);
            UpdateData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var row = dgvCus.CurrentRow;
            Customer customer = new Customer();
            customer.ID = (int)row.Cells["ID"].Value;
            customer.CustomerName = row.Cells["CustomerName"].Value.ToString();
            customer.Phone = row.Cells["Phone"].Value.ToString();
            customer.CustomerAddress = row.Cells["CustomerAddress"].Value.ToString();
            customer.Note = row.Cells["Note"].Value.ToString();
            customer.IDNumber = row.Cells["IDNumber"].Value.ToString();
            new EditCustomer(customer).ShowDialog();
            UpdateData();
        }
    }
}
