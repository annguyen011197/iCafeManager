using CafeManager.Model;
using CafeManager.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeManager.Utils;
namespace CafeManager.Controller
{
    class BillController
    {
        private static BillController instance = null;
        private BillService billService;

        public static BillController getController()
        {
            if (instance == null) instance = new BillController();
            return instance;
        }

        public BillController()
        {
            billService = new BillService();
        }

        public Bill createNoneBill()
        {
            Bill bill = new Bill();
            int id = billService.createNone();
            bill.ID = id;
            return bill;
        }

        public void updateBill(Bill bill)
        {
            billService.update(bill);
        }
        
        public Bill findBill(int id)
        {
           return billService.findOne(id);
        }
    }

}
