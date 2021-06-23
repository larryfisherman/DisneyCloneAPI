using DisneyClone.Models;
using DisneyClone.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyClone.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService _moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MovieDto>> GetAllMovies()
        {
            var movies = _moviesService.GetAllMovies();

            return Ok(movies);
        }

        [HttpPost]
        public ActionResult CreateMovie([FromBody] MovieDto dto)
        {
            var id = _moviesService.Create(dto);
            return Created($"/api/restaurant/{id}", null);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            _moviesService.Delete(id);
            return Ok("Movie removed");
        }
    }
}
