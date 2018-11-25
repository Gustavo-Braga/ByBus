using Logatti.ByBus.Domain.Entities;
using Logatti.ByBus.Domain.Interfaces.Repository;
using Logatti.ByBus.Infrastructure.Data.Command.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logatti.ByBus.Infrastructure.Data.Command.Repository
{
    public class SegmentoRepository : BaseRepository<Segmento, int>, ISegmentoRepository
    {
        public SegmentoRepository(ByBusContext dbContext) : base(dbContext)
        {
        }
    }
}
