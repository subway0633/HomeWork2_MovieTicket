using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountLibrary
{
    public class VipDiscount : IDiscount
    {
        public double setDiscount(double price)
        {
            double p = price * 0.6;
            return p;
        }
    }
}