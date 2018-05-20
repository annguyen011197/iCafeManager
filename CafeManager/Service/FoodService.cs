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
    class FoodService : BaseService<Food, int>
    {
        public long count()
        {
            string query = "SELECT COUNT(*) as Count from dbo.Food";
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            return count;
        }

        public void delete(int id)
        {
            string query = "DELETE FROM dbo.Food WHERE ID ='" + id.ToString() + "'";
            int data = (int)DataProvider.getController().ExecuteNonQuery(query);
        }

        public void delete(Food entity)
        {
            delete(entity.ID);
        }

        public void delete(List<Food> listEntity)
        {
            throw new NotImplementedException();
        }

        public  DataTable getAllWithType()
        {
            string query = @"
                select f.ID, f.FoodName, f.Price, c.CategoryName, c.ID as CategoryID
                from dbo.Food f, dbo.Category c
                where f.Category = c.ID";

            return DataProvider.getController().ExecuteQuery(query);
        }

        public void deleteAll()
        {
            throw new NotImplementedException();
        }

        internal Boolean exists(Food food)
        {
            String query = String.Format(@"select * from dbo.Food f
                where f.FoodName='{0}' and f.Category ={1}",food.FoodName,food.Category);
            var count = DataProvider.getController().ExecuteScalar(query);
            if (count == null) return true;
            else return (int)count == 0;
            //return count == 0;
        }

        public bool exists(int id)
        {
            string query = "SELECT COUNT(*) as Count from dbo.Food t where t.ID = '" + id.ToString() + "'";
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            if (count == 0) return false;
            return true;
        }

        internal DataTable getAllWithType(string text)
        {
            string query = String.Format(@"
                select f.ID, f.FoodName, f.Price, c.CategoryName, c.ID as CategoryID
                from dbo.Food f, dbo.Category c
                where f.Category = c.ID and c.CategoryName like N'%{0}%'",text);

            return DataProvider.getController().ExecuteQuery(query);
        }

        public DataTable findAll()
        {
            string query = "SELECT * from dbo.Food";
            return DataProvider.getController().ExecuteQuery(query);
        }

        public DataTable findAll(List<int> listId)
        {
            throw new NotImplementedException();
        }

        public Food findOne(int id)
        {
            string query = "SELECT * from dbo.Food t where t.ID = '" + id.ToString() + "'" ;
            List<Food> list = DataProvider.getController().ExecuteQuery(query).DataTableToList<Food>();
            if (list == null) return null;
            if (list.Count == 0) return null;
            return list[0];
        }

        public bool save(Food entity)
        {
            string query = String.Format("insert into Food (FoodName, Price, Category) values ('{0}', {1},{2})",
                entity.FoodName,entity.Price, entity.Category);
            int data = DataProvider.getController().ExecuteNonQuery(query);
            return data != 0;
        }

        public bool save(List<Food> listEntity)
        {
            int count = 0;
            foreach(var item in listEntity)
            {
                count += save(item) == false ? 0 : 1;
            }
            return count != 0;
        }

        public bool update(Food entity)
        {
            string query = "UPDATE dbo.Food SET FoodName=N'" + entity.FoodName + "',Price='" + entity.Price.ToString() + "',Category='" + entity.Category.ToString() + "' WHERE ID='" + entity.ID.ToString() + "'";
            int data = DataProvider.getController().ExecuteNonQuery(query);
            return data != 0;
        }

        public bool update(List<Food> listEntity)
        {
            throw new NotImplementedException();
        }
    }
}
