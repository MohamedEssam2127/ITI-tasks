using OrderSystem.Interfaces;
using OrderSystem.Storage;

namespace OrderSystem;

// DIP Part C: Manual Wiring (IoC Container simulation)
// All dependencies are wired together here - simulating what an IoC container does
public static class CompositionRoot
{
    public static OrderProcessor Setup(string orderType = "Standard")
    {
        // 1. Create concrete implementations of abstractions
        IOrderLogger logger = new ConsoleOrderLogger();
        IOrderEmailSender emailSender = new SmtpEmailSender();
        IOrderWriter storage = new SqlOrderStorage();

        // 2. Select the appropriate discount strategy based on order type
        IDiscountStrategy discountStrategy = orderType switch
        {
            "Premium" => new PremiumDiscountStrategy(),
            "Bulk"    => new BulkDiscountStrategy(),
            _         => new StandardDiscountStrategy()
        };

        // 3. Create the validator (depends on IOrderLogger)
        var validator = new OrderValidator(logger);

        // 4. Create the orchestrator with ALL dependencies injected via constructor
        //    OrderProcessor has ZERO new() calls for dependencies
        var processor = new OrderProcessor(
            validator,
            storage,
            emailSender,
            logger,
            discountStrategy
        );

        return processor;
    }
}
