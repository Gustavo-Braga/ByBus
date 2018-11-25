using Logatti.ByBus.Domain.Entities;
using Logatti.ByBus.Domain.Interfaces.Repository;
using Logatti.ByBus.Infrastructure.Data.Command.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logatti.ByBus.Infrastructure.Data.Command.Repository
{
    public class EmpresaRepository : BaseRepository<Empresa, int>, IEmpresaRepository
    {
        public EmpresaRepository(ByBusContext dbContext) : base(dbContext)
        {
        }

        public void Create()
        {
            dbSet.Add(new Empresa("12345678901234", "fantasma"));
        }

        public Empresa Get(string id)
        {
            var teste = dbSet.FindAsync().GetAwaiter().GetResult();
            return teste;
        }

        Empresa IEmpresaRepository.GetBy()
        {
            throw new NotImplementedException();
        }
    }
}
