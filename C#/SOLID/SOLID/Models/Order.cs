using System;
using System.Collections.Generic;

namespace OrderSystem.Models;

// ── Entities ────────────────────────────────────────────
public class Order
{
    public Guid   Id            { get; set; } = Guid.NewGuid();
    public string CustomerEmail { get; set; }
    public string OrderType     { get; set; }  // "Standard", "Premium", "Bulk"
    public decimal TotalAmount  { get; set; }
    public List<OrderItem> Items { get; set; } = new();
}

public class OrderItem
{
    public string  ProductName { get; set; }
    public int     Quantity    { get; set; }
    public decimal UnitPrice   { get; set; }
}
