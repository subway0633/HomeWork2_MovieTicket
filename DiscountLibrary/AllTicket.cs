using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountLibrary
{
    public class AllTicket
    {
        public double Price { get; set; }

        public IDiscount discount;

        public void SetDiscount(IDiscount discount)
        {
            if (discount != null)
                Price = discount.setDiscount(Price);
        }
    }
}