using Logatti.ByBus.CrossCutting.Notifications;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Logatti.ByBus.Domain.CommandHandler
{
    public abstract class BaseCommandHandler
    {
        private readonly NotificationHandler _notifications;
        protected readonly IMediator _mediator;
        public IMediator Mediator => _mediator;

        public BaseCommandHandler(IMediator mediator, INotificationHandler notifications)
        {
            _notifications = (NotificationHandler)notifications;
            _mediator = mediator;
        }
        protected void NotifyErrors(string key, string message)
        {
            _notifications.Handle(new Notification(key, message), default(CancellationToken));
        }
    }
}
