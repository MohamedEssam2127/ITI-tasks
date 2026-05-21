using System;

namespace OrderSystem.Infrastructure;

public class SmtpEmailSender { public void Send(string to, string sub, string body) => Console.WriteLine($"[SMTP] {to}"); }
