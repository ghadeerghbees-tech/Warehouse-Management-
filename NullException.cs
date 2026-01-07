using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management__
{
   public class NullException:Exception
    {
        public NullException(string message):base ($"The  {message}   is empty,please fill  it with the appropriate information")
        { }
    }
}
