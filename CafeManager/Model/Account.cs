using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Model
{
    public class Account
    {
        private string userName;
        public string UserName { get => userName; set => userName = value; }

        private string passWord;
        public string PassWord { get => passWord; set => passWord = value; }

        private string displayName;
        public string DisplayName { get => displayName; set => displayName = value; }

        private int type;
        public int Type { get => type; set => type = value; }

        //public Account(string userName, string passWord, string displayName, int type)
        //{
        //    this.userName = userName;
        //    this.passWord = passWord;
        //    this.displayName = displayName;
        //    this.type = type;
        //}
    }
}
