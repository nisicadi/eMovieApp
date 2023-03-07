using eMovieApp.Service.Interfaces;
using eMovieApp.Core.Models;
using eMovieApp.Repository.Interfaces;

namespace eMovieApp.Service.Services
{
    public class ActorRoleService : BaseService<ActorRole>, IActorRoleService
    {
        IActorRoleRepository _repository;
        public ActorRoleService(IActorRoleRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
