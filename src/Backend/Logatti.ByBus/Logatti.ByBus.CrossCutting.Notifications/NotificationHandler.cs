using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logatti.ByBus.CrossCutting.Notifications
{
    public class NotificationHandler: INotificationHandler
    {
        private static List<Notification> notifications;

        public NotificationHandler()
        {
            notifications = new List<Notification>();
        }

        public Task Handle(Notification notification, CancellationToken cancellationToken)
        {
            notifications.Add(notification);

            return Task.CompletedTask;
        }

        public virtual bool HasNotifications() => notifications.Any();

        public IEnumerable<Notification> GetNotifications() => notifications;

    }
}
