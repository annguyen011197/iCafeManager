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
    class Bill_InfoService : BaseService<Bill_Info, int>
    {
        public long count()
        {
            string query = "SELECT COUNT(*) as Count from dbo.Bill_Info";
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            return count;
        }

        public void delete(int id)
        {
            string query = "DELETE FROM dbo.Bill_Info WHERE ID='" + id.ToString() + "'";
            int data = (int)DataProvider.getController().ExecuteNonQuery(query);
        }

        public void delete(Bill_Info entity)
        {
            delete(entity.ID);
        }

        public void delete(List<Bill_Info> listEntity)
        {
            throw new NotImplementedException();
        }

        public void deleteAll()
        {
            throw new NotImplementedException();
        }

        public bool exists(int id)
        {
            string query = "SELECT COUNT(*) as Count from dbo.Bill_Info t where t.ID = '" + id.ToString() + "'";
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            if (count == 0) return false;
            return true;
        }

        public DataTable findAll()
        {
            string query = "SELECT * from dbo.Bill_Info";
            return DataProvider.getController().ExecuteQuery(query);
        }

        public DataTable findAll(List<int> listId)
        {
            throw new NotImplementedException();
        }

        public Bill_Info findOne(int id)
        {
            string query = "SELECT * from dbo.Bill_Info t where t.ID = '" + id.ToString() + "'" ;
            List<Bill_Info> list = DataProvider.getController().ExecuteQuery(query).DataTableToList<Bill_Info>();
            if (list == null) return null;
            if (list.Count == 0) return null;
            return list[0];
        }

        public bool save(Bill_Info entity)
        {
            string query = "INSERT INTO dbo.Bill_Info VALUES(" + entity.Bill.ToStringSQL()+ "," + entity.Food.ToStringSQL() + "," + entity.FoodCount.ToStringSQL() + ")";
            int data = DataProvider.getController().ExecuteNonQuery(query);
            return data != 0;
        }

        public bool save(List<Bill_Info> listEntity)
        {
            int count = 0;
            foreach(var item in listEntity)
            {
                count += save(item) == false ? 0 : 1;
            }
            return count != 0;
        }

        public bool update(Bill_Info entity)
        {
            string query = "UPDATE dbo.Bill_Info SET Bill='" + entity.Bill.ToString() + "',Food='" + entity.Food.ToString() + "',FoodCount='" + entity.FoodCount.ToString() + "' WHERE ID='" + entity.ID.ToString() + "'";
            int data = DataProvider.getController().ExecuteNonQuery(query);
            return data != 0;
        }

        public bool update(List<Bill_Info> listEntity)
        {
            throw new NotImplementedException();
        }

        public DataTable findAllFromIdBill(int id)
        {
            string query = "SELECT * from dbo.Bill_Info t where t.Bill = '" + id.ToString() + "'";
            return DataProvider.getController().ExecuteQuery(query);
        }
    }
}
