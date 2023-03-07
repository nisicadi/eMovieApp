using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;
using eMovieApp.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eMovieApp.Api.Controllers
{
    [Route("api/Director")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        IDirectorService directorService;
        public DirectorController(IDirectorService directorService)
        {
            this.directorService = directorService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(directorService.GetAll());
        }

        [HttpPost]
        public IActionResult Post(DirectorAddVM director)
        {
            return Ok(directorService.Add(director));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(directorService.Get(id));
        }

        //[HttpPut]
        //public IActionResult Update(Director director)
        //{
        //    return Ok(directorService.Update(director));
        //}

        [HttpDelete]
        public IActionResult Delete(int id)
        {            
            return Ok(directorService.Delete(id));
        }
    }
}
