using eMovieApp.Core.Models;
using eMovieApp.Repository.Interfaces;

namespace eMovieApp.Repository.Repositories
{
    public class LanguageRepository : Repository<Language>, ILanguageRepository
    {
        public LanguageRepository(eMovieAppContext context) : base(context)
        {
        }

    }
}
