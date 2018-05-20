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
    class VoucherController
    {
        private static VoucherController instance = null;
        private VoucherService voucherService;

        public static VoucherController getController()
        {
            if (instance == null) instance = new VoucherController();
            return instance;
        }

        public VoucherController()
        {
            voucherService = new VoucherService();
        }

        public Voucher checkExist(string code)
        {
            Voucher v = voucherService.findOne(code);
            return v;
        }

        public bool updateVoucher(Voucher voucher)
        {
            return voucherService.update(voucher);
        }
    }

}
