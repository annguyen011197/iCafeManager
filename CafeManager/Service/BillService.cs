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
    class BillService : BaseService<Bill, int>
    {
        public long count()
        {
            string query = "SELECT COUNT(*) as Count from dbo.Bill";
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            return count;
        }

        public void delete(int id)
        {
            string query = "DELETE FROM dbo.Bill WHERE ID='" + id.ToString() + "'";
            int data = (int)DataProvider.getController().ExecuteNonQuery(query);
        }

        public void delete(Bill entity)
        {
            delete(entity.ID);
        }

        public void delete(List<Bill> listEntity)
        {
            throw new NotImplementedException();
        }

        public void deleteAll()
        {
            throw new NotImplementedException();
        }

        public bool exists(int id)
        {
            string query = "SELECT COUNT(*) as Count from dbo.Bill t where t.ID = '" + id.ToString() + "'";
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            if (count == 0) return false;
            return true;
        }

        public DataTable findAll()
        {
            string query = "SELECT * from dbo.Bill";
            return DataProvider.getController().ExecuteQuery(query);
        }

        public DataTable findAll(List<int> listId)
        {
            throw new NotImplementedException();
        }

        public Bill findOne(int id)
        {
            string query = "SELECT * from dbo.Bill t where t.ID = '" + id.ToString() + "'" ;
            List<Bill> list = DataProvider.getController().ExecuteQuery(query).DataTableToList<Bill>();
            if (list == null) return null;
            if (list.Count == 0) return null;
            return list[0];
        }

        public bool save(Bill entity)
        {
            string query = "INSERT INTO dbo.Bill VALUES('" + entity.Date_Check_In.ConvertDate() + "','" + entity.Date_Check_Out.ConvertDate() + "'," + entity.IDTable.ToStringSQL() + ","  +  entity.Discount.ToStringSQL() + "," + entity.Customer.ToStringSQL() + ")";
            int data = DataProvider.getController().ExecuteNonQuery(query);
            return data != 0;
        }

        public bool save(List<Bill> listEntity)
        {
            int count = 0;
            foreach(var item in listEntity)
            {
                count += save(item) == false ? 0 : 1;
            }
            return count != 0;
        }

        public bool update(Bill entity)
        {
            string query = "UPDATE dbo.Bill SET Date_Check_In='" + entity.Date_Check_In.ConvertDate() + "',Date_Check_Out='" + entity.Date_Check_Out.ConvertDate() + "',IDTable=" + entity.IDTable.ToStringSQL() + ",Discount=" + entity.Discount.ToStringSQL() + ",Customer=" + entity.Customer.ToStringSQL() + " WHERE ID='" + entity.ID.ToString() + "'";
            int data = DataProvider.getController().ExecuteNonQuery(query);
            return data != 0;
        }

        public bool update(List<Bill> listEntity)
        {
            throw new NotImplementedException();
        }

        public int createNone()
        {
            string query = "INSERT INTO dbo.Bill OUTPUT Inserted.ID VALUES(null,null,null,null,null)";
            int data = (int)DataProvider.getController().ExecuteScalar(query);
            return data;
        }
    }
}
