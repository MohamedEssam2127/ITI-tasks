using OrderSystem.Entities;

namespace OrderSystem.Interfaces;

// LSP: Write-only contract - only for storages that support saving
public interface IOrderWriter
{
    void Save(Order order);
}
