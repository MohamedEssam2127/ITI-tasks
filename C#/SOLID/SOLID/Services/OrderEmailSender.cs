using OrderSystem.Models;
using OrderSystem.Infrastructure;

namespace OrderSystem.Services;

public class OrderEmailSender
{
    private readonly SmtpEmailSender _emailer = new SmtpEmailSender();

    public void SendConfirmationEmail(Order order) =>
        // Responsibility: Notify
        _emailer.Send(order.CustomerEmail, $"Order {order.Id} Confirmed", "...");
}
