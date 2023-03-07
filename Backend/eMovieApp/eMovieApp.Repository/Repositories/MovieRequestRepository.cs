using eMovieApp.Core.Models;
using eMovieApp.Repository.Interfaces;

namespace eMovieApp.Repository.Repositories
{
    public class MovieRequestRepository : Repository<MovieRequest>, IMovieRequestRepository
    {
        public MovieRequestRepository(eMovieAppContext context) : base(context)
        {
        }

    }
}
