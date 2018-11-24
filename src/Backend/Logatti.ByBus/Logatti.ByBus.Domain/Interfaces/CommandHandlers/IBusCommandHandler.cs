using Logatti.ByBus.Domain.CommandHandler.Bus;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logatti.ByBus.Domain.Interfaces.CommandHandlers
{
    public interface IBusCommandHandler: IRequestHandler<BusRouteByIdCommand, BusRouteResponse>
    { 

    }
}
