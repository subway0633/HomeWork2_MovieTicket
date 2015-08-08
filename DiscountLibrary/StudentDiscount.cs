using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountLibrary
{
    public class StudentDiscount : IDiscount
    {
        public override string ToString()
        {
            string s = string.Format("電影票九折優惠");
            return s;
        }

        public double setDiscount(double price)
        {
            double p = price * 0.9;
            return p;
        }
    }
}