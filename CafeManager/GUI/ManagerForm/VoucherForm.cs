using CafeManager.Controller;
using CafeManager.GUI.ManagerForm;
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

namespace CafeManager.ManagerForm
{
    public partial class VoucherForm : Form
    {
        List<Voucher> listAccount;
        public VoucherForm()
        {
            InitializeComponent();
            this.lbName.Text = "";
            this.lbBirthay.Text = "";
            this.lbType.Text = "";
            this.lbUsed.Text = "";
            this.lbValue.Text = "";
            updateData("");
        }

        public void updateData(String select)
        {
            int offset = Decimal.ToInt32(offsetBox.Value);
            int limit = 10;
            dgvItems.DataSource = VoucherController.getController().getList(select,offset*limit,limit);
            dgvItems.RowHeadersVisible = false;
            dgvItems.AllowUserToAddRows = false;
            dgvItems.Columns["Code"].HeaderText = "Code";
            dgvItems.Columns["Expired"].HeaderText = "Expired";
            dgvItems.Columns["Status"].HeaderText = "Status";
            dgvItems.Columns["VCValue"].HeaderText = "VCValue";

            dgvItems.Columns["Code"].Width = 200;
            dgvItems.Columns["Expired"].Width = 200;
            dgvItems.Columns["Status"].Width = 200;
            dgvItems.Columns["VCValue"].Width = 200;

            dgvItems.Columns["ID"].Visible = false;
            dgvItems.Columns["Type"].Visible = false;
        }

        public static VoucherForm Instance
        {
            get
            {
                return new VoucherForm();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddVoucher().ShowDialog();
            updateData("");
        }

        private void textBox7_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                updateData(textBox7.Text.ToLower());
                //flowLayoutPanel1.Controls.Clear();
                //listAccount = AccountController.getController().getList();
                //listAccount.ForEach(item =>
                //{
                //    if (item.Display_Name.ToLower().IndexOf(textBox7.Text.ToLower()) >= 0)
                //    {
                //        AccountControl ac = new AccountControl();
                //        ac.Account = item;
                //        ac.Parent = flowLayoutPanel1;
                //        flowLayoutPanel1.Controls.Add(ac);
                //        ac.onClick = new AccountControl.onClickAccount(onClickAccountEvent);
                //        listControl.Add(ac);
                //    }
                //});
            }
            else
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Voucher v = new Voucher();
            var row = dgvItems.CurrentRow;
            v.Code = row.Cells["Code"].Value.ToString();
            v.Expired = DateTime.Parse(row.Cells["Expired"].Value.ToString());
            v.Status = (bool)row.Cells["Status"].Value;
            v.VCValue= (int)row.Cells["VCValue"].Value;
            v.ID = (int)row.Cells["ID"].Value;
            new EditVoucher(v).ShowDialog();
            updateData("");
            //listControl.ForEach(item =>
            //{
            //    if (item.Checked)
            //    {
            //        var account = item.Account;
            //        new Edit(account).ShowDialog();
            //        UpdateClickItem(account);
            //        return;
            //    }
            //});
            //updateData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AddAccType().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var row = dgvItems.CurrentRow;
            string Code = row.Cells["Code"].Value.ToString();
            VoucherController.getController().Delete(Code);
            updateData("");
            //AccountController.getController().Delete(account);
            //listControl.ForEach(item =>
            //{
            //    if (item.Checked)
            //    {
            //        var account = item.Account;
            //        AccountController.getController().Delete(account);
            //        UpdateClickItem(account);

            //    }
            //});
            //updateData();
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            var row = dgvItems.CurrentRow;
            this.lbName.Text = row.Cells["Code"].Value.ToString();
            this.lbBirthay.Text = row.Cells["Expired"].Value.ToString();
            this.lbUsed.Text = row.Cells["Status"].Value.ToString();
            this.lbValue.Text = row.Cells["VCValue"].Value.ToString();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            offsetBox.UpButton();
            updateData("");
        }

        private void offsetBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                updateData("");
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            offsetBox.DownButton();
            updateData("");
        }

    }
}   
