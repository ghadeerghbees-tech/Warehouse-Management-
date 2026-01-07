using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management__
{
    internal class Report
    {
        public DateTime DateTime { get; } = DateTime.Now;
        public int MIQuantity{ get; set; }
        public Product MSProduct { get; set; }
        public decimal PriceTotal{ get; set; }
        public decimal PriceCash { get; set; }
    }
}
