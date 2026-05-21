using System;
using System.Collections.Generic;
using System.Linq;
using OrderSystem.Models;

namespace OrderSystem.Infrastructure;

// ── [VIOLATION 5: LSP] ArchiveOrderStorage breaks base class contract
public class SqlOrderStorage
{
    public virtual void Save(Order o) => Console.WriteLine($"[SQL] Saved {o.Id}");
    public virtual IEnumerable<Order> GetAll() => Enumerable.Empty<Order>();
}

public class ArchiveOrderStorage : SqlOrderStorage  // read-only, yet inherits Save()
{
    public override void Save(Order order)          // BREAKS the contract!
        => throw new NotSupportedException("Read-only archive — Save() not supported.");

    public override IEnumerable<Order> GetAll() =>
        Enumerable.Empty<Order>(); // simulates fetching from archive
}
