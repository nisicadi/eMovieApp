using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;
using eMovieApp.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eMovieApp.Api.Controllers
{
    [Route("api/Actor")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        IActorService actorService;
        public ActorController(IActorService actorService)
        {
            this.actorService = actorService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(actorService.GetAll());
        }

        [HttpPost]
        public IActionResult Post(ActorAddVM actor)
        {
            return Ok(actorService.Add(actor));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(actorService.Get(id));
        }

        //[HttpPut]
        //public IActionResult Update(Actor actor)
        //{
        //    return Ok(actorService.Update(actor));
        //}

        [HttpDelete]
        public IActionResult Delete(int id)
        {            
            return Ok(actorService.Delete(id));
        }
    }
}
