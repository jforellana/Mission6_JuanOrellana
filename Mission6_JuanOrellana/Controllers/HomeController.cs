using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.R = _context.Ratings.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddMovies(NewMovie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return View("Confirmation", movie);
        }

        public IActionResult MList()
        {
            var lMovies = _context.Movies
                .Include(m => m.Rating)
                .ToList();

            return View(lMovies);
        }

        public IActionResult Edit(int id)
        {
            var movieToEdit = _context.Movies
                .Single(x => x.MovieID == id);
            ViewBag.R = _context.Ratings.ToList();

            return View("AddMovies", movieToEdit);
        }

        [HttpPost]
        public IActionResult Edit(NewMovie m) 
        {
            _context.Update(m);
            _context.SaveChanges();

            return RedirectToAction("MList");
        }

        public IActionResult Delete(int id)
        {
            var movieToDelete = _context.Movies
                .Where(x => x.MovieID == id)
                .FirstOrDefault();
            //return View(movieToDelete);
            return View(movieToDelete);
        } 

        [HttpPost]
        public IActionResult Delete(NewMovie model)
        {
            _context.Movies.Remove(model);
            _context.SaveChanges();

            return RedirectToAction("MList");
        }
    }
}
