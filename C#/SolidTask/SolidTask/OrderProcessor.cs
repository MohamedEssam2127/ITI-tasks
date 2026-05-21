using OrderSystem.Entities;
using OrderSystem.Interfaces;

namespace OrderSystem;

// SRP: OrderProcessor - orchestrates: validate → discount → save → notify
// ISP: Implements IOrderProcessor + IOrderNotifier (the concerns it actually handles)
// DIP: Depends only on abstractions via constructor injection, zero new() calls
// OCP: Receives IDiscountStrategy - adding new discount = new class only, no edits here
public class OrderProcessor : IOrderProcessor, IOrderNotifier
{
    private readonly OrderValidator _validator;
    private readonly IOrderWriter _storage;
    private readonly IOrderEmailSender _emailSender;
    private readonly IOrderLogger _logger;
    private readonly IDiscountStrategy _discountStrategy;

    // DIP Part B: Constructor Injection - all dependencies pushed in from outside
    public OrderProcessor(
        OrderValidator validator,
        IOrderWriter storage,
        IOrderEmailSender emailSender,
        IOrderLogger logger,
        IDiscountStrategy discountStrategy)
    {
        _validator = validator;
        _storage = storage;
        _emailSender = emailSender;
        _logger = logger;
        _discountStrategy = discountStrategy;
    }

    public void ProcessOrder(Order order)
    {
        _logger.Log($"Processing order {order.Id}");

        if (!_validator.Validate(order)) return;

        // OCP: Discount calculation delegated to strategy - no if/else chain
        var discount = _discountStrategy.GetDiscount(order);
        var finalAmount = order.TotalAmount - (order.TotalAmount * discount);

        // Responsibility: Persist
        _storage.Save(order);

        // Responsibility: Notify
        SendConfirmationEmail(order);
    }

    public void SendConfirmationEmail(Order order) =>
        _emailSender.Send(order.CustomerEmail, $"Order {order.Id} Confirmed", "...");
}
