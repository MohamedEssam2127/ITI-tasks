using OrderSystem.Entities;
using OrderSystem.Interfaces;

namespace OrderSystem;

// SRP: OrderReportService - generates reports and exports only (single reason to change)
// ISP: Implements IOrderReporter only - no forced ProcessOrder or SendEmail methods
public class OrderReportService : IOrderReporter
{
    public string GenerateReport(IEnumerable<Order> orders) =>
        $"Orders: {orders.Count()} | Revenue: {orders.Sum(o => o.TotalAmount):C}";

    public string ExportToCsv(IEnumerable<Order> orders) =>
        string.Join("\n", orders.Select(o => $"{o.Id},{o.CustomerEmail},{o.TotalAmount}"));
}
