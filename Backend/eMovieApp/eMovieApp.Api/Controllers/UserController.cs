using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;
using eMovieApp.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eMovieApp.Api.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(userService.GetAll());
        }

        [HttpPost]
        public IActionResult Post(UserAddVM user)
        {
            User newUser = new User()
            {
                Email = user.Email,
                Password = user.Password,
                Username = user.Username,
                UserRoleId = user.UserRoleId
            };

            return Ok(userService.Add(newUser));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(userService.Get(id));
        }

        [HttpPut]
        public IActionResult Update(int id, UserUpdateVM user)
        {
            return Ok(userService.Update(id, user));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {            
            return Ok(userService.Delete(id));
        }
    }
}
