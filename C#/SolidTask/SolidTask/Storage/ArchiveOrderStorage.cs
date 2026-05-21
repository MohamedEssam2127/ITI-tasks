using OrderSystem.Entities;
using OrderSystem.Interfaces;

namespace OrderSystem.Storage;

// LSP: ArchiveOrderStorage implements IOrderReader ONLY (no forced Save)
// No more NotSupportedException - every implementation is safely substitutable
public class ArchiveOrderStorage : IOrderReader
{
    public IEnumerable<Order> GetAll() =>
        Enumerable.Empty<Order>(); // simulates fetching from archive
}
