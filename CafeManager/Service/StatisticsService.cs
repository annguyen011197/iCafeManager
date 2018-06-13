using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManager.Controller;
using CafeManager.Model;

namespace CafeManager.Service
{
    class StatisticsService : BaseService<Bill, int>
    {
        public long count()
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void delete(Bill entity)
        {
            throw new NotImplementedException();
        }

        public void delete(List<Bill> listEntity)
        {
            throw new NotImplementedException();
        }

        public void deleteAll()
        {
            throw new NotImplementedException();
        }

        public DataTable findWithOffset(int offset, int limit)
        {
            String query = String.Format(
                @"
                select Bill, Sum(Total) as Total, bill.Date_Check_In
                from (
	                select bi.Bill, bi.FoodCount*f.Price as Total
	                from dbo.Bill_Info bi, dbo.Food f
	                where bi.Food = f.ID
                ) b, dbo.Bill bill
                where b.Bill = bill.ID
                group by Bill,  bill.Date_Check_In
                order by bill.Date_Check_In
                offset {0} rows
                fetch next {1} rows only
                ",
                offset,
                limit
                );
            return DataProvider.getController().ExecuteQuery(query);
        }

        public DataTable findWithOffsetGroupbyDate(object offset, int limit, object dayStart, object dayEnd)
        {
            if (limit > 0)
            {
                String query = String.Format(
            @"
                select  CAST(b.Date_Check_In AS DATE) as Date, Sum(Total) as Total, Count(Bill) as BillCount
                from (
	                select bi.Bill, bi.FoodCount*f.Price as Total
	                from dbo.Bill_Info bi, dbo.Food f
	                where bi.Food = f.ID
                ) tb, dbo.Bill b
                where tb.Bill = b.ID
                and b.Date_Check_In > '{2}'
                and b.Date_Check_In < '{3}'
                group by CAST(b.Date_Check_In AS DATE)
                order by 'Date'
                offset {0} rows
                fetch next {1} rows only
                ",
             offset,
             limit,
             dayStart,
             dayEnd
             );
                return DataProvider.getController().ExecuteQuery(query);
            }
            else
            {
                String query = String.Format(
            @"
                select  CAST(b.Date_Check_In AS DATE) as Date, Sum(Total) as Total, Count(Bill) as BillCount
                from (
	                select bi.Bill, bi.FoodCount*f.Price as Total
	                from dbo.Bill_Info bi, dbo.Food f
	                where bi.Food = f.ID
                ) tb, dbo.Bill b
                where tb.Bill = b.ID
                and b.Date_Check_In > '{0}'
                and b.Date_Check_In < '{1}'
                group by CAST(b.Date_Check_In AS DATE)
                order by 'Date'
                ",
             dayStart,
             dayEnd
             );
                return DataProvider.getController().ExecuteQuery(query);
            }

        }

        public DataTable findWithOffsetGroupbyFood(int offset, int limit, string dayStart, string dayEnd)
        {
            if (limit > 0)
            {
                String query = String.Format(
    @"
                select Food, FoodName,Sum(FoodCount) as FoodCount, Sum(Total) as Total
                from (
	                select Bill, Food, FoodName,Price, FoodCount, Price*FoodCount as Total 
	                from dbo.Bill_Info bi, dbo.Food f
	                where bi.Food = f.ID
                ) db, dbo.Bill bill
                where bill.ID = db.Bill
                and bill.Date_Check_In > '{2}'
                and bill.Date_Check_In < '{3}'
                group by Food, FoodName, Price
                order by Food
                offset {0} rows
                fetch next {1} rows only
                ",
    offset,
    limit,
    dayStart,
    dayEnd
    );
                return DataProvider.getController().ExecuteQuery(query);
            }
            else
            {
                String query = String.Format(
    @"
                select Food, FoodName,Sum(FoodCount) as FoodCount, Sum(Total) as Total
                from (
	                select Bill, Food, FoodName,Price, FoodCount, Price*FoodCount as Total 
	                from dbo.Bill_Info bi, dbo.Food f
	                where bi.Food = f.ID
                ) db, dbo.Bill bill
                where bill.ID = db.Bill
                and bill.Date_Check_In > '{0}'
                and bill.Date_Check_In < '{1}'
                group by Food, FoodName, Price
                order by Food
                ",
    dayStart,
    dayEnd
    );
                return DataProvider.getController().ExecuteQuery(query);
            }


        }

        public DataTable findWithOffset(int offset, int limit, String dayStart, String dayEnd)
        {
            if (limit > 0)
            {
                String query = String.Format(
                @"
                select Bill, Sum(Total) as Total, bill.Date_Check_In
                from (
	                select bi.Bill, bi.FoodCount*f.Price as Total
	                from dbo.Bill_Info bi, dbo.Food f
	                where bi.Food = f.ID
                ) b, dbo.Bill bill
                where b.Bill = bill.ID
                and bill.Date_Check_In > '{2}'
                and bill.Date_Check_In < '{3}'
                group by Bill,  bill.Date_Check_In
                order by bill.Date_Check_In
                offset {0} rows
                fetch next {1} rows only
                ",
                offset,
                limit,
                dayStart,
                dayEnd
                );
                return DataProvider.getController().ExecuteQuery(query);
            }
            else
            {
                String query = String.Format(
                @"
                select Bill, Sum(Total) as Total, bill.Date_Check_In
                from (
	                select bi.Bill, bi.FoodCount*f.Price as Total
	                from dbo.Bill_Info bi, dbo.Food f
	                where bi.Food = f.ID
                ) b, dbo.Bill bill
                where b.Bill = bill.ID
                and bill.Date_Check_In > '{0}'
                and bill.Date_Check_In < '{1}'
                group by Bill,  bill.Date_Check_In
                order by bill.Date_Check_In
                ",
                dayStart,
                dayEnd
                );
                return DataProvider.getController().ExecuteQuery(query);

            }

        }

        public bool exists(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable findAll()
        {
            String query = String.Format(
                @"
                select Bill, Sum(Total) as Total, bill.Date_Check_In
                from (
	                select bi.Bill, bi.FoodCount*f.Price as Total
	                from dbo.Bill_Info bi, dbo.Food f
	                where bi.Food = f.ID
                ) b, dbo.Bill bill
                where b.Bill = bill.ID
                group by Bill,  bill.Date_Check_In
                order by bill.Date_Check_In
                "
                );
            return DataProvider.getController().ExecuteQuery(query);
        }

        public DataTable findAll(List<int> listId)
        {
            throw new NotImplementedException();
        }

        public Bill findOne(int id)
        {
            throw new NotImplementedException();
        }

        public bool save(Bill entity)
        {
            throw new NotImplementedException();
        }

        public bool save(List<Bill> listEntity)
        {
            throw new NotImplementedException();
        }

        public bool update(Bill entity)
        {
            throw new NotImplementedException();
        }

        public bool update(List<Bill> listEntity)
        {
            throw new NotImplementedException();
        }
    }
}
