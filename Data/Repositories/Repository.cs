using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext Context;
        protected readonly DbSet<T> Entities;

        public Repository(DbContext context)
        {
            Context = context;
            Entities = Context.Set<T>();
        }

        public T Get(int id)
        {
            return Entities.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Entities;
        }

        public void Add(T entity)
        {
            Entities.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            Entities.AddRange(entities);
        }

        public void Update(T entity)
        {
            Entities.Attach(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            T entity = Get(id);
            Delete(entity);
        }

        public void Delete(T entity)
        {
            Entities.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            Entities.RemoveRange(entities);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
