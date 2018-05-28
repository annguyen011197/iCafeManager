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


namespace CafeManager.ManagerForm
{
    public partial class AddNew : Form
    {

        public AddNew()
        {
            InitializeComponent();
            cbType.FlatStyle = FlatStyle.Flat;
            cbType.DataSource = Account_TypeController.getController().getTypeTable();
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "ID";
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Tài khoản và mật khẩu không được bỏ trống!");
            }

            else if (tbDisplayName.Text == "")
            {
                MessageBox.Show("Tên hiển thị không được để trống!");
            }
            else
            {
                Account account = new Account();
                account.Display_Name = tbDisplayName.Text;
                account.Username = textBox1.Text; // Thêm kiểm tra tên
                account.Password = textBox2.Text.makeMD5(); // Thêm kiểm tra mật khẩu
                account.Type = (int)cbType.SelectedValue;
                if (AccountController.getController().exits(account))
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại!");
                }
                else
                {
                    Account_Info info = new Account_Info();
                    info.First_Name = tbFirstName.Text.Trim() == "" ? "None" : tbFirstName.Text.Trim();
                    info.Last_Name = tbLastName.Text.Trim() == "" ? "None" : tbLastName.Text.Trim();
                    info.Birthday = dtpBirthDay.Value;
                    account.Info = Account_InfoController.getController().SaveNew(info);
                    bool done = AccountController.getController().createAccount(account);
                    if (done)
                    {
                        MessageBox.Show("Tạo thành công tài khoản: " + account.Username);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi ");
                    }
                }
            }
        }

        private void sexyDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
