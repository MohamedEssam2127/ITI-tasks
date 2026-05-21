using OrderSystem;
using OrderSystem.Entities;

var order = new Order
{
    CustomerEmail = "customer@example.com",
    OrderType = "Premium",
    TotalAmount = 250.00m,
    Items = new List<OrderItem>
    {
        new OrderItem { ProductName = "Laptop Stand", Quantity = 1, UnitPrice = 150.00m },
        new OrderItem { ProductName = "USB Hub",      Quantity = 2, UnitPrice = 50.00m }
    }
};

var processor = CompositionRoot.Setup(order.OrderType);
processor.ProcessOrder(order);
