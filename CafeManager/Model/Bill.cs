using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Model
{
    public class Bill
    {
        public int ID { get; set; }
        public DateTime Date_Check_In { get; set; }
        public DateTime Date_Check_Out { get; set; }
        public int IDTable { get; set; }
        public int Discount { get; set; }
        public String Customer { get; set; }
    }
}
