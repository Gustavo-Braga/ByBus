using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logatti.ByBus.CrossCutting.Notifications
{
    public interface INotificationHandler : INotificationHandler<Notification>
    {
        IEnumerable<Notification> GetNotifications();
        bool HasNotifications();
    }
}
