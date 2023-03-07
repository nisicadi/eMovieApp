using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;

namespace eMovieApp.Service.Interfaces
{
    public interface IDirectorService : IBaseService<Director>
    {
        DirectorAddVM Add(DirectorAddVM director);
        DirectorGetVM Get(int id);
        List<DirectorGetVM> GetAll();
    }
}
