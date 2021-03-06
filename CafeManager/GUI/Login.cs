﻿using CafeManager.Controller;
using CafeManager.GUI;
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
            //this.Hide();
            //new Manager().Show();
            string userName = textBox1.Text;
            string passWord = textBox2.Text.makeMD5();
            if (userName == "" || passWord == "")
            {
                MessageBox.Show("tài khoản và mật khẩu không được bỏ trống");
            }
            Account account = AccountController.getController().checkAccount(userName, passWord);
            if (account != null)
            {
                if (account.Type == 1)
                {
                    this.Hide();
                    new HomeV2().ShowDialog();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    new Manager().ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("tài khoản nhập sai");
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(this, e);
            }
        }
    }
}
