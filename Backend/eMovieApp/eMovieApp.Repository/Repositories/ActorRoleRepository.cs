using eMovieApp.Core.Models;
using eMovieApp.Repository.Interfaces;

namespace eMovieApp.Repository.Repositories
{
    public class ActorRoleRepository : Repository<ActorRole>, IActorRoleRepository
    {
        public ActorRoleRepository(eMovieAppContext context) : base(context)
        {
        }
    }
}
