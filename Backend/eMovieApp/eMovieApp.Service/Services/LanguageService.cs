using eMovieApp.Core.Models;
using eMovieApp.Repository.Interfaces;
using eMovieApp.Service.Interfaces;

namespace eMovieApp.Service.Services
{
    public class LanguageService : BaseService<Language>, ILanguageService
    {
        ILanguageRepository _repository;
        public LanguageService(ILanguageRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
