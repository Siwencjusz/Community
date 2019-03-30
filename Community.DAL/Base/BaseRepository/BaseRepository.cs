using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Community.DAL.Base.BaseRepository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T:Entity.Entity
    {
        // ReSharper disable once InconsistentNaming
        protected DbContext _entities;

        // ReSharper disable once InconsistentNaming
        protected readonly IDbSet<T> _dbset;

        // ReSharper disable once PublicConstructorInAbstractClass
        public BaseRepository(DbContext context)
        {
            _entities = context;
            _dbset = context.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbset.AsEnumerable<T>();
        }

        public virtual IEnumerable<T> GetBy(Expression<Func<T, bool>> predicate )
        {
            IEnumerable<T> query= _dbset.Where(predicate).AsEnumerable();
            return query;
        }

        public virtual T Add(T entity)
        {
            return _dbset.Add(entity);
        }

        public virtual T Delete(T entity)
        {
            return _dbset.Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }

    }
}
