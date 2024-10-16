using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPCorrect
{
    public class Order
    {
        public string CustomerName { get; set; }
    };
    public class OrderService
    {
        public void ProcessOrder(Order order)
        {
            // Business logic for processing the order
            Console.WriteLine("Processing order for customer: " + order.CustomerName);
            // More complex business rules for order processing
        }       
    }

    public class OrderRepository
    {
        public void SaveOrder(Order order)
        {
            // Code to save the order to a database
            Console.WriteLine("Saving order to the database for customer: " + order.CustomerName);
            // Database connection and persistence logic
        }
    }

}
