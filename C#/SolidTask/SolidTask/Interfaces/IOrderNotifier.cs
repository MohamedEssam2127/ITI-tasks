using OrderSystem.Entities;

namespace OrderSystem.Interfaces;

// ISP: Focused interface for notification concern only
public interface IOrderNotifier
{
    void SendConfirmationEmail(Order order);
}
