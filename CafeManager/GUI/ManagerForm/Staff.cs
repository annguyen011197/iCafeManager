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
            UpdateClickItem(account);

            unCheckTable();
            tb.check();
        }

        void UpdateClickItem(Account account)
        {
            Tuple<Account_Info, Account_Type> info = Account_InfoController.getController().findOneWithType(account.Username);
            if (info != null)
            {
                lbName.Text = info.Item1.First_Name + " " + info.Item1.Last_Name;
                lbBirthay.Text = HelperUtils.ConvertDateTime(info.Item1.Birthday.ToString());
                lbPhone.Text = info.Item1.Phone;
                lbType.Text = info.Item2.Name;
                rtbAdress.Text = info.Item1.Address;
                rtbNote.Text = info.Item1.Note;
            }
            else
            {
                lbName.Text = "";
                lbBirthay.Text = "";
                lbPhone.Text = "";
                lbType.Text = "";
                rtbAdress.Text = "";
                rtbNote.Text = "";
            }
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
            updateData();
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

        private void button3_Click(object sender, EventArgs e)
        {
            listControl.ForEach(item =>
            {
                if (item.Checked)
                {
                    var account = item.Account;
                    new Edit(account).ShowDialog();
                    UpdateClickItem(account);
                    return;
                }
            });
            updateData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AddAccType().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listControl.ForEach(item =>
            {
                if (item.Checked)
                {
                    var account = item.Account;
                    AccountController.getController().Delete(account);
                    UpdateClickItem(account);

                }
            });
            updateData();
        }
    }
}
