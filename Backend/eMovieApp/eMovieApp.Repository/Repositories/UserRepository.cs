using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;
using eMovieApp.Repository.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace eMovieApp.Repository.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(eMovieAppContext context) : base(context)
        {
        }

        public UserUpdateVM Update(int id, UserUpdateVM user)
        {
            var oldUser = _dbSet.Find(id) as User;

            if (oldUser != null) 
            { 
                oldUser.Username = string.IsNullOrWhiteSpace(user?.Username) ? oldUser.Username : user.Username;
                oldUser.Email = string.IsNullOrWhiteSpace(user?.Email) ? oldUser.Email : user.Email;

                if(!string.IsNullOrEmpty(user?.Password)) 
                {
                    SHA256 hash = SHA256.Create();
                    var password = user.Password;
                    var passwordByte = Encoding.Default.GetBytes(password);
                    var passwordHash = hash.ComputeHash(passwordByte);

                    oldUser.Password = Convert.ToHexString(passwordHash);
                    user.Password = oldUser.Password;
                }
                _context.SaveChanges();

                return user;
            }

            throw new ArgumentException("User not found!");
        }
    }
}
