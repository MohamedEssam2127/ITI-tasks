using OrderSystem.Interfaces;

namespace OrderSystem;

// DIP: ConsoleOrderLogger implements IOrderLogger abstraction
public class ConsoleOrderLogger : IOrderLogger
{
    public void Log(string message) => Console.WriteLine($"[LOG] {message}");
}
