using eMovieApp.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eMovieApp.Repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly eMovieAppContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(eMovieAppContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public T Add(T item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
            return item;
        }

        public T Get(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public bool Delete(int id)
        {
            try
            {
                T item = _dbSet.Find(id);
                _dbSet.Remove(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
