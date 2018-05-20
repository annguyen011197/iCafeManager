using CafeManager.Controller;
using CafeManager.Model;
using CafeManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager
{
   
    public partial class Login : Form
    {
   

       
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customPanel1_Resize(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Manager().Show();
            //string username = textBox1.Text;
            //string password = textBox2.Text.makeMD5();
            //if (username == "" || password == "")
            //{
            //    MessageBox.Show("tài khoản và mật khẩu không được bỏ trống");
            //}
            //Account account = AccountController.getController().checkAccount(username, password);
            //if (account != null)
            //{
            //    if (account.Type == 1 || account.Type == 2)
            //    {
            //        this.Hide();
            //        new Manager().Show();
            //    }
            //    else
            //    {
            //        this.Hide();
            //        new HomeV2().Show();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("tài khoản nhập sai");
            //}


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
