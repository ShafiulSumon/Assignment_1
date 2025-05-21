using System;

namespace Assignment_1.Service.Email;

public interface IEmailService
{
    Task SendEmailAsync(string _To, string _Subject, string _Body);
}
