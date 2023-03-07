using eMovieApp.Repository.Interfaces;
using eMovieApp.Service.Interfaces;

namespace eMovieApp.Service.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        IRepository<T> _repository;
        public BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual T Get(int id)
        {
            return _repository.Get(id);
        }

        public virtual T Add(T item)
        {
            return _repository.Add(item);
        }

        public virtual bool Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}
