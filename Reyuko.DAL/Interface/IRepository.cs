using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Reyuko.DAL.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> Query(string query, object[] parameters);

        TEntity Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void Remove(object id);
        void Remove(TEntity entity);
        void Remove(Func<TEntity, bool> where);
        void RemoveRange(IEnumerable<TEntity> entities);
        
        void Execute(string query, object[] parameters);
    }
}
