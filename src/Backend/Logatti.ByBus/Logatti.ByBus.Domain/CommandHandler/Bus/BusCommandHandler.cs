﻿using Logatti.ByBus.CrossCutting.Notifications;
using Logatti.ByBus.Domain.Interfaces.CommandHandlers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logatti.ByBus.Domain.CommandHandler.Bus
{
    public class BusCommandHandler : BaseCommandHandler, IBusCommandHandler
    {
        public BusCommandHandler(IMediator mediator, INotificationHandler notifications) : base(mediator, notifications)
        {
        }

        public async Task<BusRouteResponse> Handle(BusRouteByIdCommand request, CancellationToken cancellationToken)
        {

            await Mediator.Publish(new Notification("Bus", $"Erro teste"));
            return await Task.FromResult(default(BusRouteResponse));
        }
    }
}
