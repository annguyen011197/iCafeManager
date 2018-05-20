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
    class Bill_InfoController
    {
        private static Bill_InfoController instance = null;
        private Bill_InfoService bill_InfoService;

        public static Bill_InfoController getController()
        {
            if (instance == null) instance = new Bill_InfoController();
            return instance;
        }

        public Bill_InfoController()
        {
            bill_InfoService = new Bill_InfoService();
        }

        public bool createBill_Info(Bill_Info bill)
        {
            return bill_InfoService.save(bill);
        }

        public void updateBill_Info(Bill_Info bill)
        {
            bill_InfoService.update(bill);
        }

        public void deleteBill_Info(Bill_Info bill)
        {
            bill_InfoService.delete(bill);
        }

        public List<Bill_Info> getListFromBill(int id)
        {
            return bill_InfoService.findAllFromIdBill(id).DataTableToList<Bill_Info>();
        }
        
    }

}
