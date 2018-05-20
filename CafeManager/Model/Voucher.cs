using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Model
{
    public class Voucher
    {
        public int ID { get; set; }
        public DateTime Expired { get; set; }
        public int VCValue { get; set; }
        public bool Type { get; set; }
        public string Code { get; set; }
        public bool Status { get; set; }
    }
}
