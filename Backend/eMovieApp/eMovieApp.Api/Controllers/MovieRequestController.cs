using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;
using eMovieApp.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eMovieApp.Api.Controllers
{
    [Route("api/MovieRequest")]
    [ApiController]
    public class MovieRequestController : ControllerBase
    {
        IMovieRequestService movieRequestService;
        public MovieRequestController(IMovieRequestService movieRequestService)
        {
            this.movieRequestService = movieRequestService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(movieRequestService.GetAll());
        }

        [HttpPost]
        public IActionResult Post(MovieRequestAddVM movieRequest)
        {
            return Ok(movieRequestService.Add(movieRequest));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(movieRequestService.Get(id));
        }

        //[HttpPut]
        //public IActionResult Update(MovieRequest movieRequest)
        //{
        //    return Ok(movieRequestService.Update(movieRequest));
        //}

        [HttpDelete]
        public IActionResult Delete(int id)
        {            
            return Ok(movieRequestService.Delete(id));
        }
    }
}
