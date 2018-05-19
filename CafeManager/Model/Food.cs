using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Model
{
    public class Food
    {
        public int ID { get; set; }
        public string FoodName { get; set; }
        public int Price { get; set; }
        public int Category { get; set; }

        public override string ToString()
        {
            return FoodName + " - " + Price.ToString() + "vnđ"; 
        }
    }
}
