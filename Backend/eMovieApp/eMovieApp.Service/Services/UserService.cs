using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;
using eMovieApp.Service.Interfaces;
using System.Security.Cryptography;
using System.Text;
using eMovieApp.Repository.Interfaces;

namespace eMovieApp.Service.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        IUserRepository _repository;
        public UserService(IUserRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public UserGetVM Get(int id)
        {
            var user = _repository.Get(id);

            UserGetVM response = new UserGetVM()
            {
                UserId = user.UserId,
                UserRoleId = user.UserRoleId,
                Username = user.Username,
                Email = user.Email
            };

            return response;
        }

        public List<UserGetVM> GetAll()
        {
            var list = _repository.GetAll().OrderBy(x => x.Username).ToList();

            List<UserGetVM> response = new List<UserGetVM>();

            foreach (var vm in list) 
            { 
                response.Add(new UserGetVM()
                { 
                    UserId= vm.UserId,
                    UserRoleId = vm.UserRoleId,
                    Username = vm.Username,
                    Email= vm.Email                    
                });
            }

            return response;
        }

        public UserAddVM Add(User user)
        {
            SHA256 hash = SHA256.Create();
            var password = user.Password;
            var passwordByte = Encoding.Default.GetBytes(password);
            var passwordHash = hash.ComputeHash(passwordByte);

            user.Password = Convert.ToHexString(passwordHash);

            User newUser = _repository.Add(user);
            UserAddVM response = new UserAddVM()
            {
                Username = newUser.Username,
                UserRoleId = newUser.UserRoleId,
                Email = newUser.Email,
                Password = newUser.Password
            };

            return response;
        }

        public UserUpdateVM Update(int id, UserUpdateVM user)
        {
            return _repository.Update(id, user);
        }
    }
}
