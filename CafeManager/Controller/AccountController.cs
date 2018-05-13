using CafeManager.Model;
using CafeManager.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Controller
{
    class AccountController 
    {
        private static AccountController instance = null;
        private AccountService accountService;

        public static AccountController getController()
        {
            if (instance == null) instance = new AccountController();
            return instance;
        }

        public AccountController()
        {
            accountService = new AccountService();
        }

        public bool checkAccount(string userName, string passWord)
        {
            Account account = accountService.findOne(userName);
            if (account == null) return false;
            if (passWord == account.PassWord) return true;
            return false;
        }

        public bool createAccount(Account account)
        {
            if (accountService.exists(account.UserName))
            {
                return false;
            }
            return accountService.save(account);
        }
    }
}
