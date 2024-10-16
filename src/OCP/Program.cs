// See https://aka.ms/new-console-template for more information
using OCPCorrect;

Console.WriteLine("Hello, World!");

IDiscount regularDiscount = new RegularCustomerDiscount();
Order regularOrder = new Order(regularDiscount);
regularOrder.TotalAmount = 1000;
Console.WriteLine("Regular customer total with discount: " + regularOrder.GetTotalWithDiscount());

// Premium customer
IDiscount premiumDiscount = new PremiumCustomerDiscount();
Order premiumOrder = new Order(premiumDiscount);
premiumOrder.TotalAmount = 1000;
Console.WriteLine("Premium customer total with discount: " + premiumOrder.GetTotalWithDiscount());

// Seasonal discount
IDiscount seasonalDiscount = new SeasonalDiscount();
Order seasonalOrder = new Order(seasonalDiscount);
seasonalOrder.TotalAmount = 1000;
Console.WriteLine("Total with seasonal discount: " + seasonalOrder.GetTotalWithDiscount());
