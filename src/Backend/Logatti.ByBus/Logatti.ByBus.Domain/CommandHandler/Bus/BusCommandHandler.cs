using Logatti.ByBus.CrossCutting.Notifications;
using Logatti.ByBus.Domain.Entities;
using Logatti.ByBus.Domain.Interfaces.CommandHandlers;
using Logatti.ByBus.Domain.Interfaces.Repository;
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
        private readonly IEmpresaRepository _empresaRepository;
        private readonly ILinhaRepository _linhaRepository;
        private readonly IOnibusRepository _onibusRepository;
        private readonly ISegmentoRepository _segmentoRepository;
        private readonly IHorarioRepository _horarioRepository;
        private readonly ITipoDiaRepository _tipoDiaRepository;

        public BusCommandHandler(
            IMediator mediator,
            INotificationHandler notifications,
            IEmpresaRepository empresaRepository,
            ILinhaRepository linhaRepository,
            IOnibusRepository onibusRepository,
            ISegmentoRepository segmentoRepository,
            IHorarioRepository horarioRepository,
            ITipoDiaRepository tipoDiaRepository
            ) : base(mediator, notifications)
        {
            _empresaRepository = empresaRepository;
            _linhaRepository = linhaRepository;
            _onibusRepository = onibusRepository;
            _segmentoRepository = segmentoRepository;
            _horarioRepository = horarioRepository;
            _tipoDiaRepository = tipoDiaRepository;
        }

        public async Task<BusRouteResponse> Handle(BusRouteByIdCommand request, CancellationToken cancellationToken)
        {
            var a = _linhaRepository.Get();
            var b = _empresaRepository.Get();
            var c = _segmentoRepository.Get();
            var d = _onibusRepository.Get();
            var e = _horarioRepository.Get();
            var f = _tipoDiaRepository.Get();

            return new BusRouteResponse();
        }
    }
}
