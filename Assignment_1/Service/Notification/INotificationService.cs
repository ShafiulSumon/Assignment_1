using System;

namespace Assignment_1.Service.Notification;

public interface INotificationService
{
    Task NotificationThroughEmail(string To);
}
