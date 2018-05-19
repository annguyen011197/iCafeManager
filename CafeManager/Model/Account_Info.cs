using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Model
{
    public class Account_Info
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name{ get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Note { get; set; }
        public Bitmap Image { get; set; }
    }
}
