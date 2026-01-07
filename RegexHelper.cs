using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Warehouse_Management__
{
    internal static class RegexHelper
    {// اسم المستخدم: أحرف + أرقام + _
        public static bool IsValidUsername(string text)
        {
            return Regex.IsMatch(text, @"^[a-zA-Z0-9_]{4,20}$");
        }

        // كلمة المرور: أي شي من 4 إلى 20
        public static bool IsValidPassword(string text)
        {
            return Regex.IsMatch(text, @"^.{4,20}$");
        }
      
        // رقم الهاتف: 10 أرقام
        public static bool IsValidPhone(string text)
        {
            return Regex.IsMatch(text, @"^(\+9639\09)(\d{8})$");
        }
        public static bool IsValidNumber(string text)
        {
            return Regex.IsMatch(text, @"^\d$");
        }
    }
}
