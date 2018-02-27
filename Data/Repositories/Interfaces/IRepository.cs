using System;
using System.Collections.Generic;

namespace Data.Repositories.Interfaces
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Delete(int id);
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
        void SaveChanges();
    }
}