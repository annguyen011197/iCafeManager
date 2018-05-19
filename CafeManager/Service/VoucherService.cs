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
    class VoucherService : BaseService<Voucher, int>
    {
        public long count()
        {
            string query = "SELECT COUNT(*) as Count from dbo.Voucher";
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            return count;
        }

        public void delete(int id)
        {
            string query = "DELETE FROM dbo.Voucher WHERE ID='" + id.ToString() + "'";
            int data = (int)DataProvider.getController().ExecuteNonQuery(query);
        }

        public void delete(Voucher entity)
        {
            delete(entity.ID);
        }

        public void delete(List<Voucher> listEntity)
        {
            throw new NotImplementedException();
        }

        public void deleteAll()
        {
            throw new NotImplementedException();
        }

        public bool exists(int id)
        {
            string query = "SELECT COUNT(*) as Count from dbo.Voucher t where t.ID = '" + id.ToString() + "'";
            int count = (int)DataProvider.getController().ExecuteScalar(query);
            if (count == 0) return false;
            return true;
        }

        public DataTable findAll()
        {
            string query = "SELECT * from dbo.Voucher";
            return DataProvider.getController().ExecuteQuery(query);
        }

        public DataTable findAll(List<int> listId)
        {
            throw new NotImplementedException();
        }

        public Voucher findOne(int id)
        {
            string query = "SELECT * from dbo.Voucher t where t.ID = '" + id.ToString() + "'" ;
            List<Voucher> list = DataProvider.getController().ExecuteQuery(query).DataTableToList<Voucher>();
            if (list == null) return null;
            if (list.Count == 0) return null;
            return list[0];
        }

        public bool save(Voucher entity)
        {
            string query = "INSERT INTO dbo.Voucher VALUES('" + entity.ID.ToString() + "','" + entity.Expired.ConvertDate() + "','" + entity.VCValue.ToString() +"')";
            int data = DataProvider.getController().ExecuteNonQuery(query);
            return data != 0;
        }

        public bool save(List<Voucher> listEntity)
        {
            int count = 0;
            foreach(var item in listEntity)
            {
                count += save(item) == false ? 0 : 1;
            }
            return count != 0;
        }

        public bool update(Voucher entity)
        {
            string query = "UPDATE dbo.Voucher SET Expired='" + entity.Expired.ConvertDate() + "',VCValue='" + entity.VCValue.ToString() + "' WHERE ID='" + entity.ID.ToString() + "'";
            int data = DataProvider.getController().ExecuteNonQuery(query);
            return data != 0;
        }

        public bool update(List<Voucher> listEntity)
        {
            throw new NotImplementedException();
        }
    }
}