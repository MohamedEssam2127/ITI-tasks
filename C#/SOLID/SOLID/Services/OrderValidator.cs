using System;
using OrderSystem.Models;
using OrderSystem.Infrastructure;

namespace OrderSystem.Services;

public class OrderValidator
{
    private readonly FileOrderLogger _logger = new FileOrderLogger();

    public bool Validate(Order order)
    {
        // Responsibility: Validation (should be a separate class)
        if (order.Items.Count == 0) { _logger.Log("No items."); return false; }
        if (string.IsNullOrWhiteSpace(order.CustomerEmail)) { return false; }
        return true;
    }
}
