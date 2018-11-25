using Logatti.ByBus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logatti.ByBus.Domain.Interfaces.Repository
{
    public interface IEmpresaRepository:IRepository<Empresa,string>
    {
        void Create();
        Empresa GetBy();
    }
}
