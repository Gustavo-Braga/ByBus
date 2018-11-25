using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logatti.ByBus.Domain.CommandHandler.Bus
{
    public class BusRouteByIdCommand : IRequest<BusRouteResponse>
    {
        public BusRouteByIdCommand(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

    }
}
