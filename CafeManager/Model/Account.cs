using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Model
{
    public class Account
    {
        public string ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Display_Name { get; set; }
        public int Type { get; set; }
        public int Info { get; set; }
        public string Color { get; set; }
    }
}
