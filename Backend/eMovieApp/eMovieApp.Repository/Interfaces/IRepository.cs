namespace eMovieApp.Repository.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        T Add(T item);

        public bool Delete(int id);
    }
}
