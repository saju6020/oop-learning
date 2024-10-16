using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPCorrect
{
    // Abstraction for Discount
    public interface IDiscount
    {
        decimal ApplyDiscount(decimal totalAmount);
    }

    // Regular customer discount
    public class RegularCustomerDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount * 0.90m;  // 10% discount
        }
    }

    // Premium customer discount
    public class PremiumCustomerDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount * 0.80m;  // 20% discount
        }
    }

    // No discount for other customers
    public class NoDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount;  // No discount
        }
    }

    // Seasonal discount
    public class SeasonalDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount * 0.85m;  // 15% seasonal discount
        }
    }

    public class Order
    {
        public decimal TotalAmount { get; set; }

        private IDiscount discountStrategy;

        // Constructor accepting the discount strategy
        public Order(IDiscount discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }

        public decimal GetTotalWithDiscount()
        {
            return discountStrategy.ApplyDiscount(TotalAmount);
        }
    }

}
