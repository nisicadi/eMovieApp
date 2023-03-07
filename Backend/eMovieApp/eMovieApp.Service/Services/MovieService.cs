using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;
using eMovieApp.Repository.Interfaces;
using eMovieApp.Service.Interfaces;

namespace eMovieApp.Service.Services
{
    public class MovieService : BaseService<Movie>, IMovieService
    {
        IMovieRepository _repository;
        public MovieService(IMovieRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public MovieGetVM Get(int id)
        {
            var movie = _repository.Get(id);

            MovieGetVM response = new MovieGetVM()
            {
                DirectorId = movie.DirectorId,
                Title = movie?.Title,
                LanguageId = movie.LanguageId,
                ReleaseDate = movie?.ReleaseDate
            };

            return response;
        }

        public List<MovieGetVM> GetAll()
        {
            var list = _repository.GetAll().OrderBy(x => x.Title).ToList();

            List<MovieGetVM> response = new List<MovieGetVM>();

            foreach (var movie in list)
            {
                response.Add(new MovieGetVM()
                {
                    DirectorId = movie.DirectorId,
                    Title = movie?.Title,
                    LanguageId = movie.LanguageId,
                    ReleaseDate = movie?.ReleaseDate
                });
            }

            return response;
        }

        public MovieAddVM Add(MovieAddVM movie)
        {
            Movie newMovie = new Movie()
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
