using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Warehouse_Management__
{
    internal class Category
    {
      
        public int Id { get; set; } 
        public string Name { get; set; }
        public bool Switch { get; set; }

        public override string ToString()
        {
            return Name ;//اجعل الكومبوبكس يعرض قيمة الخاصية name
            //لجعل الكومبوبكس يعرض اسم المنتج
        }
    }
}
