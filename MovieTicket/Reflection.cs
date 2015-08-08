using DiscountLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket
{
    public class Reflection
    {
        public static IDiscount GetDiscount(string key)
        {
            string s = "DiscountLibrary." + key;
            IDiscount Discount = (IDiscount)Assembly.Load("DiscountLibrary").CreateInstance(s);
            return Discount;
        }
    }
}