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
    class CategoryService : BaseService<Category, int>
    {
        public long count()
        {
            string query = "SELECT COUNT(*) as Count from dbo.Category";
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            return count;
        }

        public void delete(int id)
        {
            string query = "DELETE FROM dbo.Category WHERE ID ='" + id.ToString() + "'";
            int data = (int)DataProvider.getController().ExecuteNonQuery(query);
        }

        public void delete(Category entity)
        {
            delete(entity.ID);
        }

        public void delete(List<Category> listEntity)
        {
            throw new NotImplementedException();
        }

        public void deleteAll()
        {
            throw new NotImplementedException();
        }

        internal bool exists(Category cat)
        {
            string query = "SELECT COUNT(*) as Count from dbo.Category t where t.CategoryName = '" + cat.CategoryName + "'";
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            if (count == 0) return false;
            return true;
        }

        public bool exists(int id)
        {
            string query = "SELECT COUNT(*) as Count from dbo.Category t where t.ID = '" + id.ToString() + "'";
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            if (count == 0) return false;
            return true;
        }

        public DataTable findAll()
        {
            string query = "SELECT * from dbo.Category";
            return DataProvider.getController().ExecuteQuery(query);
        }

        public DataTable findAll(List<int> listId)
        {
            throw new NotImplementedException();
        }

        public Category findOne(int id)
        {
            string query = "SELECT * from dbo.Category t where t.ID = '" + id.ToString() + "'" ;
            List<Category> list = DataProvider.getController().ExecuteQuery(query).DataTableToList<Category>();
            if (list == null) return null;
            if (list.Count == 0) return null;
            return list[0];
        }

        public bool save(Category entity)
        {
            string query = "INSERT INTO dbo.Category VALUES(N'" + entity.CategoryName + "')";
            int data = DataProvider.getController().ExecuteNonQuery(query);
            return data != 0;
        }

        public bool save(List<Category> listEntity)
        {
            int count = 0;
            foreach(var item in listEntity)
            {
                count += save(item) == false ? 0 : 1;
            }
            return count != 0;
        }

        public bool update(Category entity)
        {
            string query = "UPDATE dbo.Category SET CategoryName=N'" + entity.CategoryName +"' WHERE ID='" + entity.ID.ToString() + "'";
            int data = DataProvider.getController().ExecuteNonQuery(query);
            return data != 0;
        }

        public bool update(List<Category> listEntity)
        {
            throw new NotImplementedException();
        }
    }
}
