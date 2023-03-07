using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;

namespace eMovieApp.Service.Interfaces
{
    public interface IActorService : IBaseService<Actor>
    {
        ActorAddVM Add(ActorAddVM actor);
        ActorGetVM Get(int id);
        List<ActorGetVM> GetAll();
    }
}
