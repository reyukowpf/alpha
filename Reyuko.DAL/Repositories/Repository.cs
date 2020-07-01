using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Reyuko.DAL.Interface;

namespace Reyuko.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public TEntity Get(int id)
        {
            // Here we are working with a DbContext, not PlutoContext. So we don't have DbSets 
            // such as Courses or Authors, and we need to use the generic Set() method to access them.
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            // Note that here I've repeated Context.Set<TEntity>() in every method and this is causing
            // too much noise. I could get a reference to the DbSet returned from this method in the 
            // constructor and store it in a private field like _entities. This way, the implementation
            // of our methods would be cleaner:
            // 
            // _entities.ToList();
            // _entities.Where();
            // _entities.SingleOrDefault();
            // 
            // I didn't change it because I wanted the code to look like the videos. But feel free to change
            // this on your own.
            return _context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().SingleOrDefault(predicate);
        }

        public virtual IEnumerable<TEntity> Query(string sql, object[] parameters)
        {
            return _context.Database.SqlQuery<TEntity>(sql, parameters);
        }

        public TEntity Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return entity;
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }

        public virtual void Update(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Remove(object id)
        {
            TEntity entityToDelete = _context.Set<TEntity>().Find(id);
            Remove(entityToDelete);
        }
        public void Remove(TEntity entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
                _context.Set<TEntity>().Attach(entity);
            _context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }

        public virtual void Remove(Func<TEntity, bool> where)
        {
            List<TEntity> entitiesToDelete = _context.Set<TEntity>().Where(where).ToList();
            if (entitiesToDelete != null && entitiesToDelete.Count() > 0)
            {
                foreach (TEntity entityToDelete in entitiesToDelete)
                {
                    Remove(entityToDelete);
                }
            }
        }

        public virtual void Execute(string sql, object[] parameters)
        {
            _context.Database.ExecuteSqlCommand(sql, parameters);
        }

    }
}
