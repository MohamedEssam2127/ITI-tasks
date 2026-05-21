namespace OrderSystem.Interfaces;

// DIP: Abstracts where logs go
public interface IOrderLogger
{
    void Log(string message);
}
