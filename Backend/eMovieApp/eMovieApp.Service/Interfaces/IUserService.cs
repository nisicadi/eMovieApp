using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;

namespace eMovieApp.Service.Interfaces
{
    public interface IUserService : IBaseService<User>
    {
        public List<UserGetVM> GetAll();
        public UserGetVM Get(int id);
        public UserAddVM Add(User user);
        public UserUpdateVM Update(int id, UserUpdateVM user);
    }
}
