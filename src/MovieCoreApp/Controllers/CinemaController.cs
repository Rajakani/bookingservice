using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MovieCoreApp.Models;
using MovieCoreApp.Repository.Interfaces;
using Microsoft.AspNetCore.Cors;

namespace MovieCoreApp.Controllers
{
    [Route("api/[controller]")]
    public class CinemaController : Controller
    {
        public CinemaController(ICinemaRepository cinemas)
        {
            Cinemas = cinemas;
        }
        public ICinemaRepository Cinemas { get; set; }

        [HttpGet]
        public IEnumerable<Cinema> GetCinemas()
        {
            return Cinemas.GetCinemas();
        }

        [HttpGet("{id}", Name = "getmovies")]
        public ICollection<Movie> GetMovies(long id)
        {
            var movieList = Cinemas.GetMovies(id);
            return movieList;    
        }
    }
}