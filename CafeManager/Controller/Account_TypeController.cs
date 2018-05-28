using CafeManager.Model;
using CafeManager.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Controller
{
    class Account_TypeController
    {
        private static Account_TypeController instance = null;
        private Account_TypeService Service;

        public static Account_TypeController getController()
        {
            if (instance == null) instance = new Account_TypeController();
            return instance;
        }

        public Account_TypeController()
        {
            Service = new Account_TypeService();
        }

        public DataTable getTypeTable()
        {
            return Service.findAll();
        }

        public bool Save(Account_Type at)
        {
            return Service.save(at);
        }

        public void Delete(int iD)
        {
            Service.delete(iD);
            //throw new NotImplementedException();
        }
    }
}
