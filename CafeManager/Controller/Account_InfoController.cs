using CafeManager.Model;
using CafeManager.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Controller
{
    class Account_InfoController
    {
        private static Account_InfoController instance = null;
        private Account_InfoService accountService;

        public static Account_InfoController getController()
        {
            if (instance == null) instance = new Account_InfoController();
            return instance;
        }

        public Account_InfoController()
        {
            accountService = new Account_InfoService();
        }

        public Tuple<Account_Info, Account_Type> findOneWithType(String id)
        {
            return accountService.findOneWithType(id);
        }

        public int SaveNone()
        {
            return accountService.saveGetID();
        }

        public int SaveNew(Account_Info ai)
        {
            return accountService.saveNew(ai);
        }

        public bool Update(Account_Info account_Info)
        {
            return accountService.update(account_Info);
        }
    }
}
