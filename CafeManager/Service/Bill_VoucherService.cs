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
    class Bill_VoucherService : BaseService<Bill_Voucher, int>
    {
        public long count()
        {
            string query = "SELECT COUNT(*) as Count from dbo.Bill_Voucher";
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            return count;
        }

        public void delete(int id)
        {
            string query = "DELETE FROM dbo.Bill_Voucher WHERE ID='" + id.ToString() + "'";
            int data = (int)DataProvider.getController().ExecuteNonQuery(query);
        }

        public void delete(Bill_Voucher entity)
        {
            delete(entity.ID);
        }

        public void delete(List<Bill_Voucher> listEntity)
        {
            throw new NotImplementedException();
        }

        public void deleteAll()
        {
            throw new NotImplementedException();
        }

        public bool exists(int id)
        {
            string query = "SELECT COUNT(*) as Count from dbo.Bill_Voucher t where t.ID = '" + id.ToString() + "'";
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            if (count == 0) return false;
            return true;
        }

        public DataTable findAll()
        {
            string query = "SELECT * from dbo.Bill_Voucher";
            return DataProvider.getController().ExecuteQuery(query);
        }

        public DataTable findAll(List<int> listId)
        {
            throw new NotImplementedException();
        }

        public Bill_Voucher findOne(int id)
        {
            string query = "SELECT * from dbo.Bill_Voucher t where t.ID = '" + id.ToString() + "'";
            List<Bill_Voucher> list = DataProvider.getController().ExecuteQuery(query).DataTableToList<Bill_Voucher>();
            if (list == null) return null;
            if (list.Count == 0) return null;
            return list[0];
        }

        public bool save(Bill_Voucher entity)
        {
            string query = "INSERT INTO dbo.Bill_Voucher VALUES('" + entity.ID.ToString() + "','" + entity.ID_Bill.ToString() + "','" + entity.ID_Voucher.ToString() + "')";
            int data = DataProvider.getController().ExecuteNonQuery(query);
            return data != 0;
        }

        public bool save(List<Bill_Voucher> listEntity)
        {
            int count = 0;
            foreach (var item in listEntity)
            {
                count += save(item) == false ? 0 : 1;
            }
            return count != 0;
        }

        public bool update(Bill_Voucher entity)
        {
            string query = "UPDATE dbo.Bill_Voucher SET ID_Bill='" + entity.ID_Bill.ToString() + "',ID_Voucher='" + entity.ID_Voucher.ToString() + "' WHERE ID='" + entity.ID.ToString() + "'";
            int data = DataProvider.getController().ExecuteNonQuery(query);
            return data != 0;
        }

        public bool update(List<Bill_Voucher> listEntity)
        {
            throw new NotImplementedException();
        }
    }
}
