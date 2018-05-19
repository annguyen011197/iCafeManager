using CafeManager.Controller;
using CafeManager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Service
{
    class Account_InfoService : BaseService<Account_Info, int>
    {
        public long count()
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void delete(Account_Info entity)
        {
            throw new NotImplementedException();
        }

        public void delete(List<Account_Info> listEntity)
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

        public Account_Info findOne(int id)
        {
            throw new NotImplementedException();
        }

        public Tuple<Account_Info,Account_Type> findOneWithType(String id)
        {
            String query = String.Format(
@"select  ai.ID as InfoID, ai.First_Name, ai.Last_Name, ai.Birthday, ai.""Address"", ai.Phone, ai.Note, ai.""Image"", 
""at"".ID as 'TypeID', ""at"".""Name"" as 'TypeName'
from dbo.Account a, dbo.Account_Info ai, dbo.Account_Type ""at""
where a.Info = ai.ID and a.""Type"" = ""at"".ID and a.Username = N'{0}'", id);
            var data =  DataProvider.getController().ExecuteQuery(query);
            var data_row = data.Rows[0];
            Account_Info account_Info = new Account_Info();
            Account_Type account_Type = new Account_Type();
            account_Info.ID = (int) data_row.ItemArray[0];
            account_Info.First_Name = data_row.ItemArray[1].ToString();
            account_Info.Last_Name = data_row.ItemArray[2].ToString();
            account_Info.Birthday = (DateTime) data_row.ItemArray[3];
            account_Info.Address = data_row.ItemArray[4].ToString();
            account_Info.Phone = data_row.ItemArray[5].ToString();
            account_Info.Note = data_row.ItemArray[6].ToString();
            Bitmap bmp;
            using (var ms = new MemoryStream((byte[])data_row.ItemArray[7]))
            {
                account_Info.Image = new Bitmap(ms);
            }

            account_Type.ID = int.Parse(data_row.ItemArray[8].ToString());
            account_Type.Name = data_row.ItemArray[9].ToString();

            return new Tuple<Account_Info, Account_Type>(account_Info, account_Type);
        }

        public bool save(Account_Info entity)
        {
            throw new NotImplementedException();
        }

        public bool save(List<Account_Info> listEntity)
        {
            throw new NotImplementedException();
        }

        public bool update(Account_Info entity)
        {
            throw new NotImplementedException();
        }

        public bool update(List<Account_Info> listEntity)
        {
            throw new NotImplementedException();
        }
    }
}
