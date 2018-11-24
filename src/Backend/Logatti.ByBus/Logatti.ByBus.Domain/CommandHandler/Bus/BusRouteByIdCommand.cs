using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logatti.ByBus.Domain.CommandHandler.Bus
{
    public class BusRouteByIdCommand : IRequest<BusRouteResponse>
    {
        public BusRouteByIdCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }
}
