﻿using CafeManager.Model;
using CafeManager.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Controller
{
    class CustomerController
    {
        private static CustomerController instance = null;
        private CustomerService accountService;

        public static CustomerController getController()
        {
            if (instance == null) instance = new CustomerController();
            return instance;
        }

        public DataTable FindAll()
        {
            return accountService.findAll();
            //throw new NotImplementedException();
        }

        public CustomerController()
        {
            accountService = new CustomerService();
        }

        public bool Save(Customer customer)
        {
            Boolean check = false;
            try
            {
               return accountService.save(customer);
            }catch(Exception e)
            {

            }
            return check;
        }

        public bool Update(Customer customer)
        {
            return accountService.update(customer);
        }

        public void Delete(Customer customer)
        {
            accountService.delete(customer);
        }
    }
}