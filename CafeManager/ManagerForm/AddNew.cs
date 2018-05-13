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
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Tài khoản và mật khẩu không được bỏ trống!");
            }
            Account account = new Account();
            account.DisplayName = textBox3.Text;
            account.UserName = textBox1.Text; // Thêm kiểm tra tên
            account.PassWord = textBox2.Text.makeMD5(); // Thêm kiểm tra mật khẩu
            account.Type = 0;
            bool done = AccountController.getController().createAccount(account);
            if (done)
            {
                MessageBox.Show("Tạo thành công tài khoản: " + account.UserName);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên tài khoản đã tồn tại!");
            }
        }
    }
}
