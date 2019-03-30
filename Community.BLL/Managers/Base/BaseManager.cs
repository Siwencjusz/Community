using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Community.DAL.Base.BaseRepository;

namespace Community.BLL.Managers.Entity
{
    public abstract class BaseManager <T> : IBaseManager<T> where T:DAL.Base.Entity.Entity
    {
        IBaseRepository<T> _repository;

        public BaseManager(IBaseRepository<T> repository )
        {
            _repository = repository;
        }

        public void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _repository.Add(entity);
            _repository.Save();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _repository.Delete(entity);
            _repository.Save();
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _repository.Edit(entity);
            _repository.Save();
        }
    }
}
