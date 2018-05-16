using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Model
{
    public class Table
    {
        private int Id;
        public int ID { get => Id; set => Id = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private bool status;
        public bool Status { get => status; set => status = value; }
    }
}
