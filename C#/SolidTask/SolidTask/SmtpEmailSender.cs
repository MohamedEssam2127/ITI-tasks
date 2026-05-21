using OrderSystem.Interfaces;

namespace OrderSystem;

// DIP: SmtpEmailSender implements IOrderEmailSender abstraction
public class SmtpEmailSender : IOrderEmailSender
{
    public void Send(string to, string subject, string body) =>
        Console.WriteLine($"[SMTP] {to}");
}
