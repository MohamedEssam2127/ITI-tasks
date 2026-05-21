using System;
using OrderSystem.Models;
using OrderSystem.Infrastructure;

namespace OrderSystem.Services;

// ── [VIOLATION 2: SRP + DIP] God class with 5 responsibilities
public class OrderProcessor
{
    // [VIOLATION 3: DIP] Hardcoded concrete dependencies
    private readonly OrderValidator _validator = new OrderValidator();
    private readonly OrderStorage _storage = new OrderStorage();
    private readonly OrderEmailSender _emailer = new OrderEmailSender();
    private readonly FileOrderLogger _logger = new FileOrderLogger();

    public void ProcessOrder(Order order)
    {
        _logger.Log($"Processing order {order.Id}");

        if (!_validator.Validate(order)) return;

        // Responsibility: Discount calculation
        var discount = GetDiscount(order);
        var finalAmount = order.TotalAmount - (order.TotalAmount * discount);

        _storage.Save(order);

        _emailer.SendConfirmationEmail(order);
    }

    // [VIOLATION 4: OCP] Every new order type = edit this method
    private decimal GetDiscount(Order order)
    {
        if (order.OrderType == "Standard") return 0.00m;  // edit here for new types
        else if (order.OrderType == "Premium") return 0.10m;
        else if (order.OrderType == "Bulk") return 0.20m;
        else return 0.00m;
    }
}
