﻿using Logatti.ByBus.Domain.Entities;
using Logatti.ByBus.Domain.Interfaces.Repository;
using Logatti.ByBus.Infrastructure.Data.Command.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logatti.ByBus.Infrastructure.Data.Command.Repository
{
    public class HorarioRepository : BaseRepository<Horario, int>, IHorarioRepository
    {
        public HorarioRepository(ByBusContext dbContext) : base(dbContext)
        {
        }
    }
}
