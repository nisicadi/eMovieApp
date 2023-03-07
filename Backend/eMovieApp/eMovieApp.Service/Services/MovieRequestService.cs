using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;
using eMovieApp.Repository.Interfaces;
using eMovieApp.Service.Interfaces;

namespace eMovieApp.Service.Services
{
    public class MovieRequestService : BaseService<MovieRequest>, IMovieRequestService
    {
        IMovieRequestRepository _repository;
        public MovieRequestService(IMovieRequestRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public MovieRequestGetVM Get(int id)
        {
            var movie = _repository.Get(id);

            MovieRequestGetVM response = new MovieRequestGetVM()
            {
                DirectorId = movie.DirectorId,
                Title = movie?.Title,
                LanguageId = movie.LanguageId,
                ReleaseDate = movie?.ReleaseDate
            };

            return response;
        }

        public List<MovieRequestGetVM> GetAll()
        {
            var list = _repository.GetAll().OrderBy(x => x.Title).ToList();

            List<MovieRequestGetVM> response = new List<MovieRequestGetVM>();

            foreach (var movie in list)
            {
                response.Add(new MovieRequestGetVM()
                {
                    DirectorId = movie.DirectorId,
                    Title = movie?.Title,
                    LanguageId = movie.LanguageId,
                    ReleaseDate = movie?.ReleaseDate
                });
            }

            return response;
        }

        public MovieRequestAddVM Add(MovieRequestAddVM movie)
        {
            MovieRequest newMovie = new MovieRequest()
            {
                MovieId = 0,
                DirectorId = movie.DirectorId,
                Title = movie?.Title,
                LanguageId = movie.LanguageId,
                ReleaseDate = movie?.ReleaseDate
            };

            _repository.Add(newMovie);

            return movie;
        }
    }
}
