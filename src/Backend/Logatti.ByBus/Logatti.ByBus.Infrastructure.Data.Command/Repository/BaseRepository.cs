using Logatti.ByBus.Domain.Interfaces.Repository;
using Logatti.ByBus.Infrastructure.Data.Command.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logatti.ByBus.Infrastructure.Data.Command.Repository
{
    public class BaseRepository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : class
    {
        private readonly ByBusContext dbContext;
        protected readonly DbSet<TEntity> dbSet;

        public BaseRepository(ByBusContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<TEntity>();
        }

        public void Create(TEntity obj)
        {
            dbSet.Add(obj);
        }

        public TEntity Get(TId id)
        {
            return dbSet.Find(id);
        }

        public IQueryable<TEntity> Get()
        {
            return dbSet;
        }

        public void Remove<TEntityIdType>(TEntityIdType id)
        {
            dbSet.Remove(dbSet.Find(id));
        }

        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            dbSet.Update(obj);
        }
    }
}
