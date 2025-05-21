using System;
using Assignment_1.Service.Email;
using Assignment_1.Utils;

namespace Assignment_1.Service.Notification;

public class NotificationService : INotificationService
{
    private readonly IEmailService _emailService;

    public NotificationService(IEmailService emailService)
    {
        _emailService = emailService;
    }

    public async Task NotificationThroughEmail(string To)
    {
        await _emailService.SendEmailAsync(To, ConstantMessage.EmailSubject, ConstantMessage.EmailBody);
    }
}
