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

namespace CafeManager.ManagerForm
{
    public partial class Staff : Form
    {
        List<Account> listAccount;
        List<AccountControl> listControl=  new List<AccountControl>();
        public Staff()
        {
            InitializeComponent();
            this.lbName.Text = "";
            this.lbBirthay.Text = "";
            this.lbType.Text = "";
            this.rtbAdress.Text = "";
            this.rtbNote.Text = "";
            this.lbPhone.Text = "";
            updateData();
        }

        public void updateData()
        {
            flowLayoutPanel1.Controls.Clear();
            listAccount = AccountController.getController().getList();
            listAccount.ForEach(item =>
            {
                AccountControl ac = new AccountControl();
                ac.Account = item;
                ac.Parent = flowLayoutPanel1;
                flowLayoutPanel1.Controls.Add(ac);
                ac.onClick = new AccountControl.onClickAccount(onClickAccountEvent);
                listControl.Add(ac);
            });
        }

        public void onClickAccountEvent(AccountControl tb)
        {
            //la.Text = tb.Table.Name;
            Account account = tb.Account;
            Tuple<Account_Info,Account_Type> info =  Account_InfoController.getController().findOneWithType(account.Username);
            unCheckTable();
            tb.check();
        }


        void unCheckTable()
        {
            listControl.ForEach(item =>
            {
                item.unCheck();
            });
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

        private void textBox7_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                flowLayoutPanel1.Controls.Clear();
                listAccount = AccountController.getController().getList();
                listAccount.ForEach(item =>
                {
                    if (item.Display_Name.ToLower().IndexOf(textBox7.Text.ToLower()) >=0)
                    {
                        AccountControl ac = new AccountControl();
                        ac.Account = item;
                        ac.Parent = flowLayoutPanel1;
                        flowLayoutPanel1.Controls.Add(ac);
                        ac.onClick = new AccountControl.onClickAccount(onClickAccountEvent);
                        listControl.Add(ac);
                    }
                });
            }
            else
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
