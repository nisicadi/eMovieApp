using eMovieApp.Core.Models;
using eMovieApp.DTO.ViewModels;
using eMovieApp.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eMovieApp.Api.Controllers
{
    [Route("api/Language")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        ILanguageService languageService;
        public LanguageController(ILanguageService languageService)
        {
            this.languageService = languageService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(languageService.GetAll());
        }

        [HttpPost]
        public IActionResult Post(LanguageAddVM language)
        {
            return Ok(languageService.Add(new Language() { LanguageName = language.LanguageName }));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(languageService.Get(id));
        }

        //[HttpPut]
        //public IActionResult Update(Language language)
        //{
        //    return Ok(languageService.Update(language));
        //}

        [HttpDelete]
        public IActionResult Delete(int id)
        {            
            return Ok(languageService.Delete(id));
        }
    }
}
