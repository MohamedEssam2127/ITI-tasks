using OrderSystem.Entities;

namespace OrderSystem.Interfaces;

// DIP: Abstracts where orders are saved (combines IOrderWriter + IOrderReader)
public interface IOrderStorage : IOrderWriter, IOrderReader
{
}
