using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management__
{
    internal class PriceException:Exception
    {
        public PriceException():base("The Wholesale price is more expensive than or equal to  the sales after price")
        {
            
        }
    }
}
