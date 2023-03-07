using eMovieApp.Core.Models;
using eMovieApp.Repository.Interfaces;

namespace eMovieApp.Repository.Repositories
{
    public class DirectorRepository : Repository<Director>, IDirectorRepository
    {
        public DirectorRepository(eMovieAppContext context) : base(context)
        {
        }

    }
}
