using CafeManager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Service
{
    class CustomerService : BaseService<Customer, int>
    {
        public long count()
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void delete(List<Customer> listEntity)
        {
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
            throw new NotImplementedException();
        }

        public DataTable findAll(List<int> listId)
        {
            throw new NotImplementedException();
        }

        public Customer findOne(int id)
        {
            throw new NotImplementedException();
        }

        public bool save(Customer entity)
        {
            throw new NotImplementedException();
        }

        public bool save(List<Customer> listEntity)
        {
            throw new NotImplementedException();
        }

        public bool update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public bool update(List<Customer> listEntity)
        {
            throw new NotImplementedException();
        }
    }
}
