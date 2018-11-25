using Logatti.ByBus.CrossCutting.Notifications;
using Logatti.ByBus.Domain.CommandHandler.Bus;
using Logatti.ByBus.Domain.Interfaces.CommandHandlers;
using Logatti.ByBus.Domain.Interfaces.Repository;
using Logatti.ByBus.Infrastructure.Data.Command.Context;
using Logatti.ByBus.Infrastructure.Data.Command.Repository;
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
            services.AddScoped<ByBusContext>();

            //Repository
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<ILinhaRepository, LinhaRepository>();
            services.AddScoped<IOnibusRepository, OnibusRepository>();
            services.AddScoped<ISegmentoRepository, SegmentoRepository>();
            services.AddScoped<IHorarioRepository, HorarioRepository>();
            services.AddScoped<ITipoDiaRepository, TipoDiaRepository>();

            //CrossCutting
            services.AddScoped<INotificationHandler<Notification>, NotificationHandler>();
            services.AddScoped<INotification, Notification>();
            services.AddScoped<INotificationHandler, NotificationHandler>();
            //CommandHandler
            services.AddScoped<IRequestHandler<BusRouteByIdCommand, BusRouteResponse>, BusCommandHandler>();


        }
    }
}
