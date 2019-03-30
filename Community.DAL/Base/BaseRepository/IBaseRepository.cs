using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Community.DAL.Base.BaseRepository
{
    public interface IBaseRepository<T> where T:Entity.Entity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetBy(Expression<Func<T, bool>> predicate);
        T Add(T entity);
        T Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}
