using Assignment_1.Service.Email;
using Assignment_1.Utils;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;

namespace Assignment_1.Service.EmailService;

public class EmailService : IEmailService
{
    public async Task SendEmailAsync(string _To, string _Subject, string _Body)
    {
        var email = Environment.GetEnvironmentVariable("EMAIL_USERNAME");
        var password = Environment.GetEnvironmentVariable("EMAIL_PASSWORD");

        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("Shafiul Alam", email));
        message.To.Add(MailboxAddress.Parse(_To));
        message.Subject = _Subject;
        message.Body = new TextPart("html")
        {
            Text = _Body
        };

        using var client = new SmtpClient();
        await client.ConnectAsync(ConstantMessage.Host, ConstantMessage.Port, SecureSocketOptions.StartTls);
        await client.AuthenticateAsync(email, password);
        await client.SendAsync(message);
        await client.DisconnectAsync(true);
    }
}
