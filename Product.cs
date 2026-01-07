using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management__
{
    internal class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal PriceW{ get; set; }
        public decimal PriceS{ get; set; }
        public DateTime DT { get; set; }
        public int Qun { get; set; }
        public int IdCtegory{ get; set; }
    }
}
