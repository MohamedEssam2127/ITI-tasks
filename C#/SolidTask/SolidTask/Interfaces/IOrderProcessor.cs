using OrderSystem.Entities;

namespace OrderSystem.Interfaces;

// ISP: Focused interface for order processing concern only
public interface IOrderProcessor
{
    void ProcessOrder(Order order);
}
