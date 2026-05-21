using OrderSystem.Entities;

namespace OrderSystem.Interfaces;

// OCP: Strategy Pattern - adding a new discount type = adding a new class only
public interface IDiscountStrategy
{
    decimal GetDiscount(Order order);
}
