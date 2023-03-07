using eMovieApp.Repository.Interfaces;

namespace eMovieApp.Service.Interfaces
{
    public interface IBaseService<T>
    {
        public IEnumerable<T> GetAll();
        public T Get(int id);
        public T Add(T item);
        public bool Delete(int id);
    }
}
