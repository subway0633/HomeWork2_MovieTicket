using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountLibrary
{
    public class KidDiscount : IDiscount
    {
        public double setDiscount(double price)
        {
            double p = price * 0.3;
            return p;
        }
    }
}