using OrderSystem.Entities;
using OrderSystem.Interfaces;

namespace OrderSystem;

// OCP: Each discount type is a separate class - no editing existing code for new types

// Standard orders get 0% discount
public class StandardDiscountStrategy : IDiscountStrategy
{
    public decimal GetDiscount(Order order) => 0.00m;
}

// Premium orders get 10% discount
public class PremiumDiscountStrategy : IDiscountStrategy
{
    public decimal GetDiscount(Order order) => 0.10m;
}

// Bulk orders get 20% discount
public class BulkDiscountStrategy : IDiscountStrategy
{
    public decimal GetDiscount(Order order) => 0.20m;
}
