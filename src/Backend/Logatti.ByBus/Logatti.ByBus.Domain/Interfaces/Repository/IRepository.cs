using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logatti.ByBus.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity, TId> where TEntity : class
    {
        void Create(TEntity obj);
        void Update(TEntity obj);
        void Remove<TEntityIdType>(TEntityIdType id);
        TEntity Get(TId id);
        IQueryable<TEntity> Get();
        int SaveChanges();
    }
}
