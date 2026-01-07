using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management__
{
    internal class Account
    {
        public int Id { get; set; } 
        public string Name{ get; set; }
        public string Password{ get; set; }
        public int Phone { get; set; }
        public bool IsAdmin { get; set; }
    }
}
