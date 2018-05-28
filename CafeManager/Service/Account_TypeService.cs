using CafeManager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManager.Controller;
using CafeManager.Utils;

namespace CafeManager.Service
{
    class Account_TypeService : BaseService<Account_Type, int>
    {
        public long count()
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            String query = @"delete from dbo.Account_Info where ID=" + id;
            DataProvider.getController().ExecuteNonQuery(query);
            //throw new NotImplementedException();
        }

        public void delete(Account_Type entity)
        {
            throw new NotImplementedException();
        }

        public void delete(List<Account_Type> listEntity)
        {
            //HelperUtils.DataTableToList<Account_Type>()
            throw new NotImplementedException();
        }

        public void deleteAll()
        {
            throw new NotImplementedException();
        }

        public bool exists(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable findAll()
        {
            String query = "select * from dbo.Account_Type";
            return DataProvider.getController().ExecuteQuery(query);
            //throw new NotImplementedException();
        }

        public DataTable findAll(List<int> listId)
        {
            throw new NotImplementedException();
        }

        public Account_Type findOne(int id)
        {
            throw new NotImplementedException();
        }

        public bool save(Account_Type entity)
        {
            String query = String.Format(@"insert into dbo.Account_Type (""name"") values ('{0}')", entity.Name);
            return DataProvider.getController().ExecuteNonQuery(query) != 0;
           
        }

        public bool save(List<Account_Type> listEntity)
        {
            throw new NotImplementedException();
        }

        public bool update(Account_Type entity)
        {
            throw new NotImplementedException();
        }

        public bool update(List<Account_Type> listEntity)
        {
            throw new NotImplementedException();
        }
    }
}
