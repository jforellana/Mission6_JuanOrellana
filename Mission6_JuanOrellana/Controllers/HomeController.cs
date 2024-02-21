using Microsoft.AspNetCore.Mvc;
using Mission6_JuanOrellana.Models;
using System.Diagnostics;

namespace Mission6_JuanOrellana.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext _context;
        public HomeController(MoviesContext allmovies)
        {
            _context = allmovies;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        public IActionResult AddMovies()
        {
            ViewBag.Ratings = _context.Ratings
                .OrderBy(x => x.RatingName)
                .ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddMovies(NewMovie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return View("Confirmation", movie);
        }

        public IActionResult Table()
        {
            var movieList = _context.Movies
                .ToList();

            return View(movieList);
        }
    }
}
