using eMovieApp.Service.Interfaces;
using eMovieApp.Core.Models;
using eMovieApp.Repository.Interfaces;

namespace eMovieApp.Service.Services
{
    public class UserRoleService : BaseService<UserRole>, IUserRoleService
    {
        IUserRoleRepository _repository;
        public UserRoleService(IUserRoleRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
