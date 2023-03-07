using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;
using eMovieApp.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eMovieApp.Api.Controllers
{
    [Route("api/Movie")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        IMovieService movieService;
        public MovieController(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(movieService.GetAll());
        }

        [HttpPost]
        public IActionResult Post(MovieAddVM movie)
        {
            return Ok(movieService.Add(movie));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(movieService.Get(id));
        }

        //[HttpPut]
        //public IActionResult Update(Movie movie)
        //{
        //    return Ok(movieService.Update(movie));
        //}

        [HttpDelete]
        public IActionResult Delete(int id)
        {            
            return Ok(movieService.Delete(id));
        }
    }
}
