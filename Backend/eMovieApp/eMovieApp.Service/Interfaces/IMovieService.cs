using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;

namespace eMovieApp.Service.Interfaces
{
    public interface IMovieService : IBaseService<Movie>
    {
        MovieAddVM Add(MovieAddVM movie);
        MovieGetVM Get(int id);
        List<MovieGetVM> GetAll();
    }
}
