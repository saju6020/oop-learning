using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPBreak
{
    public class Order
    {
        public decimal TotalAmount { get; set; }
        public string CustomerType { get; set; }

        public decimal ApplyDiscount()
        {
            if (CustomerType == "Regular")
            {
                return TotalAmount * 0.90m;  // 10% discount
            }
            else if (CustomerType == "Premium")
            {
                return TotalAmount * 0.80m;  // 20% discount
            }
            else
            {
                return TotalAmount;
            }
        }
    }

}
