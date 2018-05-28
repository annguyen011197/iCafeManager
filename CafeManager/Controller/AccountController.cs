using CafeManager.Model;
using CafeManager.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManager.Utils;
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

        public Account checkAccount(string userName, string passWord)
        {
            Account account = accountService.findOne(userName);
            if (account == null) return null;
            if (passWord == account.Password) return account;
            return null;
        }

        public bool createAccount(Account account)
        {
            if (accountService.exists(account.Username))
            {
                return false;
            }
            return accountService.save(account);
        }

        public List<Account> getList()
        {
            return accountService.findAll().DataTableToList<Account>();
        }

        public bool exits(Account account)
        {
            return accountService.exists(account.Username);
        }

        public bool update(Account account)
        {
            return accountService.update(account);
        }

        public void Delete(Account account)
        {
            Account_TypeController.getController().Delete(account.Info);
            accountService.delete(account);
            //throw new NotImplementedException();
        }
    }
}
