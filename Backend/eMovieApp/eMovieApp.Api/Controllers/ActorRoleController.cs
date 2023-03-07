using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;
using eMovieApp.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eMovieApp.Api.Controllers
{
    [Route("api/ActorRole")]
    [ApiController]
    public class ActorRoleController : ControllerBase
    {
        IActorRoleService actorRoleService;
        public ActorRoleController(IActorRoleService actorRoleService)
        {
            this.actorRoleService = actorRoleService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(actorRoleService.GetAll());
        }

        [HttpPost]
        public IActionResult Post(ActorRoleAddVM actorRole)
        {
            return Ok(actorRoleService.Add(new ActorRole() { RoleName = actorRole.RoleName }));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(actorRoleService.Get(id));
        }

        //[HttpPut]
        //public IActionResult Update(ActorRole actorRole)
        //{
        //    return Ok(actorRoleService.Update(actorRole));
        //}

        [HttpDelete]
        public IActionResult Delete(int id)
        {            
            return Ok(actorRoleService.Delete(id));
        }
    }
}
