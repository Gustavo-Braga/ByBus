using Logatti.ByBus.CrossCutting.Notifications;
using Logatti.ByBus.Domain.CommandHandler.Bus;
using Logatti.ByBus.Domain.Interfaces.CommandHandlers;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logatti.ByBus.Infrastructure.Dependencies
{
    public class Bootstrapper
    {
        public static void Initialize(IServiceCollection services)
        {
            //CrossCutting
            services.AddScoped<INotificationHandler<Notification>, NotificationHandler>();
            services.AddScoped<INotification, Notification>();
            services.AddScoped<INotificationHandler, NotificationHandler>();
            //CommandHandler
            services.AddScoped<IRequestHandler<BusRouteByIdCommand, BusRouteResponse>, BusCommandHandler>();


        }
    }
}
