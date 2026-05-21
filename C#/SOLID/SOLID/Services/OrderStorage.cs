using OrderSystem.Models;
using OrderSystem.Infrastructure;

namespace OrderSystem.Services;

public class OrderStorage
{
    private readonly SqlOrderStorage _storage = new SqlOrderStorage();

    public void Save(Order order)
    {
        // Responsibility: Persist
        _storage.Save(order);
    }
}
