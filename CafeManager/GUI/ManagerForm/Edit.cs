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
    public partial class Edit : Form
    {

        Account account;
        Account_Info account_Info;
        Account_Type account_Type;
        public Edit(Account account)
        {
            InitializeComponent();
            this.account = account;
            cbType.FlatStyle = FlatStyle.Flat;
            cbType.DataSource = Account_TypeController.getController().getTypeTable();
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "ID";
            var info = Account_InfoController.getController().findOneWithType(account.Username);
            if (info != null)
            {
                account_Info = info.Item1;
                account_Type = info.Item2;
                tbFirstName.Text = account_Info.First_Name;
                tbLastName.Text = account_Info.Last_Name;
                tbPhone.Text = account_Info.Phone;
                rtbAddress.Text = account_Info.Address;
                rtbNote.Text = account_Info.Note;
                dtpBd.Value = account_Info.Birthday;
            }
            else
            {
                tbFirstName.Text = "";
                tbLastName.Text = "";
                tbPhone.Text = "";
                rtbAddress.Text = "";
                rtbNote.Text = "";

            }
            tbDisplay.Text = account.Display_Name;
            cbType.SelectedValue = account.Type;

        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag1 = false, flag2 = false;
            //Update DisplayName
            if (tbDisplay.Text != account.Display_Name
                || (int)cbType.SelectedValue != account.Type
                )
            {
                account.Display_Name = tbDisplay.Text;
                account.Type = (int)cbType.SelectedValue;
                if (!AccountController.getController().update(account))
                {
                    MessageBox.Show("không thể update tên hiển thị");
                }
                else flag1 = true;
            }
            else flag1 = true;
            if (account_Info == null) account_Info = new Account_Info();
            if (tbFirstName.Text != account_Info.First_Name
                || tbLastName.Text != account_Info.Last_Name
                || tbPhone.Text != account_Info.Phone
                || rtbAddress.Text != account_Info.Address
                || rtbNote.Text != account_Info.Note
                || dtpBd.Value != account_Info.Birthday)
            {
                account_Info.First_Name = tbFirstName.Text;
                account_Info.Last_Name = tbLastName.Text;
                account_Info.Phone = tbPhone.Text;
                account_Info.Note = rtbNote.Text;
                account_Info.Address = rtbAddress.Text;
                account_Info.Birthday = dtpBd.Value;
                if (!Account_InfoController.getController().Update(account_Info))
                {
                    MessageBox.Show("không thể update thông tin");
                }
                else flag2 = true;
            }
            else flag2 = true;
            if(flag1 && flag2)
            {
                MessageBox.Show("Thành công");
                this.Close();
            }
        }
    }
}
