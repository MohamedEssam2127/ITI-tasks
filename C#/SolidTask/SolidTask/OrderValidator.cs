using OrderSystem.Entities;
using OrderSystem.Interfaces;

namespace OrderSystem;

// SRP: OrderValidator - validates orders only (single reason to change)
public class OrderValidator
{
    private readonly IOrderLogger _logger;

    // DIP: Depends on IOrderLogger abstraction, not concrete FileOrderLogger
    public OrderValidator(IOrderLogger logger)
    {
        _logger = logger;
    }

    public bool Validate(Order order)
    {
        if (order.Items.Count == 0) { _logger.Log("No items."); return false; }
        if (string.IsNullOrWhiteSpace(order.CustomerEmail)) { return false; }
        return true;
    }
}
