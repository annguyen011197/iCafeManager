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
            string userName = textBox1.Text;
            string passWord = textBox2.Text.makeMD5();
            if (userName == "" || passWord == "")
            {
                MessageBox.Show("Tài khoản và mật khẩu không được bỏ trống");
            }
            if(AccountController.getController().checkAccount(userName, passWord))
            {
                this.Hide();
                new Manager().Show();
            }
            else
            {
                MessageBox.Show("Tài khoản nhập sai");
            }

           
        }
    }
}
