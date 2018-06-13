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
    class TableService : BaseService<Table, int>
    {
        public long count()
        {
            string query = "SELECT COUNT(*) as Count from dbo.TableIn";
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            return count;
        }

        public void delete(int id)
        {
            string query = "DELETE FROM dbo.TableIn WHERE ID='" + id.ToString() + "'";
            int data = (int)DataProvider.getController().ExecuteNonQuery(query);
        }

        public void delete(Table entity)
        {
            delete(entity.ID);
        }

        public void delete(List<Table> listEntity)
        {
            throw new NotImplementedException();
        }

        public void deleteAll()
        {
            throw new NotImplementedException();
        }

        public bool exists(int id)
        {
            string query = "SELECT COUNT(*) as Count from dbo.TableIn t where t.ID = '" + id.ToString() + "'";
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            if (count == 0) return false;
            return true;
        }

        public DataTable findAll()
        {
            string query = "SELECT * from dbo.TableIn";
            return DataProvider.getController().ExecuteQuery(query);
        }

        public DataTable findAll(List<int> listId)
        {
            throw new NotImplementedException();
        }

        public Table findOne(int id)
        {
            string query = "SELECT * from dbo.TableIn t where t.ID = '" + id.ToString() + "'" ;
            List<Table> list = DataProvider.getController().ExecuteQuery(query).DataTableToList<Table>();
            if (list == null) return null;
            if (list.Count == 0) return null;
            return list[0];
        }

        public bool save(Table entity)
        {
            string query = String.Format(
                @"  insert into dbo.TableIn(TableName,TableStatus) values(N'{0}',0)",
                entity.TableName);
            int data = DataProvider.getController().ExecuteNonQuery(query);
            return data != 0;
        }

        public bool save(List<Table> listEntity)
        {
            int count = 0;
            foreach(var item in listEntity)
            {
                count += save(item) == false ? 0 : 1;
            }
            return count != 0;
        }

        public bool update(Table entity)
        {
            string query = "UPDATE dbo.TableIn SET TableName=" + entity.TableName.ToStringSQL() + ",TableStatus=" + entity.TableStatus.ToStringSQL()  + ",IDBill=" + entity.IDBill.ToStringSQL() + " WHERE ID='" + entity.ID.ToString() + "'";
            int data = DataProvider.getController().ExecuteNonQuery(query);
            return data != 0;
        }

        public bool update(List<Table> listEntity)
        {
            throw new NotImplementedException();
        }
    }
}
