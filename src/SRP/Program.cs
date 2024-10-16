// See https://aka.ms/new-console-template for more information
using SRPCorrect;
using static SRP.OrderService;

Console.WriteLine("Hello, World!");

Order order = new Order { CustomerName = "John Doe" };

// Separate responsibilities
OrderService orderService = new OrderService();
OrderRepository orderRepository = new OrderRepository();

// Process the order (business logic)
orderService.ProcessOrder(order);

// Save the order (persistence logic)
orderRepository.SaveOrder(order);
