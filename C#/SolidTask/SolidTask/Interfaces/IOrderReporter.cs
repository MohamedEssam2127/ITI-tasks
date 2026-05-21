using OrderSystem.Entities;

namespace OrderSystem.Interfaces;

// ISP: Focused interface for reporting concern only
public interface IOrderReporter
{
    string GenerateReport(IEnumerable<Order> orders);
    string ExportToCsv(IEnumerable<Order> orders);
}
