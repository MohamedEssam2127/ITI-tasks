using OrderSystem.Entities;

namespace OrderSystem.Interfaces;

// LSP: Read-only contract - safe for ArchiveOrderStorage to implement
public interface IOrderReader
{
    IEnumerable<Order> GetAll();
}
