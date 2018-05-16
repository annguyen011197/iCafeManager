﻿using CafeManager.Controller;
using CafeManager.Model;
using CafeManager.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Service
{
    class AccountService : BaseService<Account, String>
    {
        public long count()
        {
            string query = "SELECT COUNT(*) as Count from dbo.Account";
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            return count;
        }

        public void delete(string id)
        {
            string query = "DELETE FROM dbo.Account WHERE UserName='" + id + "'";
            int data = (int)DataProvider.getController().ExecuteNonQuery(query);
        }

        public void delete(Account entity)
        {
            delete(entity.UserName);
        }

        public void delete(List<Account> listEntity)
        {
            throw new NotImplementedException();
        }

        public void deleteAll()
        {
            throw new NotImplementedException();
        }

        public bool exists(string id)
        {
            string query = "SELECT COUNT(*) as Count from dbo.Account t where t.UserName = '" + id + "'";
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            if (count == 0) return false;
            return true;
        }

        public DataTable findAll()
        {
            string query = "SELECT * from dbo.Account";
            return DataProvider.getController().ExecuteQuery(query);
        }

        public DataTable findAll(List<string> listId)
        {
            throw new NotImplementedException();
        }

        public Account findOne(string id)
        {
            string query = "SELECT * from dbo.Account t where t.UserName = '" + id + "'" ;
            List<Account> list = DataProvider.getController().ExecuteQuery(query).DataTableToList<Account>();
            if (list == null) return null;
            if (list.Count == 0) return null;
            return list[0];
        }

        public bool save(Account entity)
        {
            string query = "INSERT INTO dbo.Account VALUES('"+ entity.UserName + "','" + entity.DisplayName + "','" + entity.PassWord +"','" + entity.Type+"')";
            int data = DataProvider.getController().ExecuteNonQuery(query);
            return data != 0;
        }

        public bool save(List<Account> listEntity)
        {
            int count = 0;
            foreach(var item in listEntity)
            {
                count += save(item) == false ? 0 : 1;
            }
            return count != 0;
        }

        public bool update(Account entity)
        {
            string query = "UPDATE dbo.Account SET PassWord='" + entity.PassWord + "',DisplayName=N'" + entity.DisplayName + "',Type='" + entity.Type + "' WHERE ID='" + entity.UserName + "'";
            int data = DataProvider.getController().ExecuteNonQuery(query);
            return data != 0;
        }

        public bool update(List<Account> listEntity)
        {
            throw new NotImplementedException();
        }
    }
}
