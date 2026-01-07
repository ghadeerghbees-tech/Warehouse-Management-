using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management__
{
    internal class NegtiveQuantityException:Exception
    {
        public NegtiveQuantityException(string message) : base($"The  {message}   does not have to be negative")
        { }
    }
}
