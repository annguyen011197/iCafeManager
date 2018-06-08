using CafeManager.Controller;
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
    class CustomerService : BaseService<Customer, String>
    {
        public long count()
        {
            throw new NotImplementedException();
        }

        public void delete(String id)
        {
            String query = @"delete from dbo.Customer where IDNumber = " + id;
            DataProvider.getController().ExecuteNonQuery(query);
        }

        public void delete(Customer entity)
        {
            // String query = @"select * from dbo.Customer";
            delete(entity.IDNumber);
        }

        public void delete(List<Customer> listEntity)
        {
            throw new NotImplementedException();
        }

        public void deleteAll()
        {
            throw new NotImplementedException();
        }

        public bool exists(String id)
        {
            string query = "SELECT COUNT(*) as Count from dbo.Customer t where t.IDNumber = " + id.ToStringSQL();
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            if (count == 0) return false;
            return true;
        }

        public DataTable findAll()
        {
            String query = @"select * from dbo.Customer";
            return DataProvider.getController().ExecuteQuery(query);
            //throw new NotImplementedException();
        }

        public DataTable findAll(List<String> listId)
        {
            throw new NotImplementedException();
        }

        public Customer findOne(String String)
        {
            throw new NotImplementedException();
        }

        public bool save(Customer entity)
        {
            String query = String.Format(@"insert into Customer (CustomerName, Phone, CustomerAddress, Note, IDNumber) values (N'{0}', '{1}', N'{2}', '{3}','{4}')",
                entity.CustomerName,
                entity.Phone,
                entity.CustomerAddress,
                entity.Note,
                entity.IDNumber
                );
            return DataProvider.getController().ExecuteNonQuery(query) != 0;
        }

        public bool save(List<Customer> listEntity)
        {
            throw new NotImplementedException();
        }

        public bool update(Customer entity)
        {
            String query = String.Format(@"update dbo.Customer
set CustomerName=N'{0}',Phone=N'{1}',CustomerAddress=N'{2}',Note=N'{3}'
where IDNumber={4}",
                    entity.CustomerName,entity.Phone, entity.CustomerAddress,
                    entity.Note,entity.IDNumber
                    );
            return DataProvider.getController().ExecuteNonQuery(query)!=0;
        }

        public bool update(List<Customer> listEntity)
        {
            throw new NotImplementedException();
        }

    }
}
