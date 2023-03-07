using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;

namespace eMovieApp.Service.Interfaces
{
    public interface IMovieRequestService : IBaseService<MovieRequest>
    {
        MovieRequestAddVM Add(MovieRequestAddVM movie);
        MovieRequestGetVM Get(int id);
        List<MovieRequestGetVM> GetAll();
    }
}
