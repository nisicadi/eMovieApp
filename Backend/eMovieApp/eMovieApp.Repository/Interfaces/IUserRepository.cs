using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;

namespace eMovieApp.Repository.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        public UserUpdateVM Update(int id, UserUpdateVM user);
    }
}
