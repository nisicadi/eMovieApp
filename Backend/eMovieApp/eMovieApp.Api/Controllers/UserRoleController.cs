using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;
using eMovieApp.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eMovieApp.Api.Controllers
{
    [Route("api/UserRole")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        IUserRoleService userRoleService;
        public UserRoleController(IUserRoleService userRoleService)
        {
            this.userRoleService = userRoleService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(userRoleService.GetAll());
        }

        [HttpPost]
        public IActionResult Post(UserRoleAddVM userRole)
        {
            return Ok(userRoleService.Add(new UserRole() { RoleName = userRole.RoleName }));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(userRoleService.Get(id));
        }

        //[HttpPut]
        //public IActionResult Update(UserRole userRole)
        //{
        //    return Ok(userRoleService.Update(userRole));
        //}

        [HttpDelete]
        public IActionResult Delete(int id)
        {            
            return Ok(userRoleService.Delete(id));
        }
    }
}
