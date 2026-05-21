namespace OrderSystem.Interfaces;

// DIP: Abstracts how emails are sent
public interface IOrderEmailSender
{
    void Send(string to, string subject, string body);
}
