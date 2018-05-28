using CafeManager.Controller;
using CafeManager.Model;
using CafeManager.Utils;
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
            String query = @"select count(*) as count from dbo.Account_Info";
            return (int) DataProvider.getController().ExecuteScalar(query);
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

        internal int saveNew(Account_Info enity)
        {
            String query = String.Format(@"insert into dbo.Account_Info(First_Name,Last_Name,Birthday) Output Inserted.ID
                            values ('{0}','{1}','{2}')", enity.First_Name, enity.Last_Name, enity.Birthday.ToString());           
            return (int) DataProvider.getController().ExecuteScalar(query);
        }

        public int saveGetID()
        {
            String query = @"insert into dbo.Account_Info(First_Name) values ('None')";
            return (int) count();
            //throw new NotImplementedException();
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
            if (data.Rows.Count > 0)
            {
                var data_row = data.Rows[0];
                Account_Info account_Info = new Account_Info();
                Account_Type account_Type = new Account_Type();
                account_Info.ID = (int)data_row.ItemArray[0];
                account_Info.First_Name = data_row.ItemArray[1].ToString();
                account_Info.Last_Name = data_row.ItemArray[2].ToString();
                account_Info.Birthday = (DateTime)data_row.ItemArray[3];
                account_Info.Address = data_row.ItemArray[4].ToString();
                account_Info.Phone = data_row.ItemArray[5].ToString();
                account_Info.Note = data_row.ItemArray[6].ToString();
                Bitmap bmp;
                Console.WriteLine(data_row.ItemArray[7].GetType());
                var check = data_row.ItemArray[7].ToString();
                if (check != "")
                {
                    account_Info.Image = HelperUtils.ObjToImg(data_row.ItemArray[7]);
                }

                account_Type.ID = int.Parse(data_row.ItemArray[8].ToString());

                account_Type.Name = data_row.ItemArray[9].ToString();
                return new Tuple<Account_Info, Account_Type>(account_Info, account_Type);

            }
            return null;

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
            string query = String.Format(
                @"update dbo.Account_Info
                set First_Name = N'{0}',
                Last_Name = N'{1}',
                Birthday = '{2}',
                Note = N'{3}',
                ""Address"" = N'{4}',
                Phone = N'{5}'
                where ID = '{6}'",
                entity.First_Name,
                entity.Last_Name,
                entity.Birthday,
                entity.Note,
                entity.Address,
                entity.Phone,
                entity.ID
                );
            int data = DataProvider.getController().ExecuteNonQuery(query);
            return data != 0;
        }

        public bool update(List<Account_Info> listEntity)
        {
            throw new NotImplementedException();
        }
    }
}
