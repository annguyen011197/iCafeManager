using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Model
{
    public class BillReport
    {
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public decimal Count { get; set; }
        public decimal Sum
        {
            get
            {
                return Price * Count;
            }
        }
    }
}
