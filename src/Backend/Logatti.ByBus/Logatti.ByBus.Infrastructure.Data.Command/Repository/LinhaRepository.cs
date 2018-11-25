using Logatti.ByBus.Domain.Entities;
using Logatti.ByBus.Domain.Interfaces.Repository;
using Logatti.ByBus.Infrastructure.Data.Command.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logatti.ByBus.Infrastructure.Data.Command.Repository
{
    public class LinhaRepository : BaseRepository<Linha, int>, ILinhaRepository
    {
        public LinhaRepository(ByBusContext dbContext) : base(dbContext)
        {
        }

        public List<Linha> GetAll()
        {
            var a = dbSet.Include(x => x.Segmentos).ToList();
            return a;
        }
    }
}
