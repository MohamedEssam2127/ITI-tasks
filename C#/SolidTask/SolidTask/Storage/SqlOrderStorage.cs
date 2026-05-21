using OrderSystem.Entities;
using OrderSystem.Interfaces;

namespace OrderSystem.Storage;

// LSP: SqlOrderStorage implements BOTH IOrderWriter + IOrderReader (full storage)
public class SqlOrderStorage : IOrderStorage
{
    public void Save(Order order) => Console.WriteLine($"[SQL] Saved {order.Id}");

    public IEnumerable<Order> GetAll() => Enumerable.Empty<Order>();
}
