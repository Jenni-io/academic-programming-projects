using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieList.Models;

namespace MovieList.Controllers {
    public class MovieController : Controller {
        // Auto-implemented property (private)
        private MovieContext Context { get; set; }

        // Constructor method
        public MovieController(MovieContext context) {
            this.Context = context;
        } // end method

        [HttpGet]
        public IActionResult MovieIndex() {
            // Querying the database to return ALL movies ordered by name

            List<Movie> movies = Context.Movies
                .Include(m => m.Genre)
                .OrderBy(m => m.Name)
                .ToList();

            return View(movies);    // Passes movies list object to the view
        } // end method

        [HttpGet]
        public IActionResult Add() {
            ViewBag.Action = "Add";
            ViewBag.Genres = Context.Genres.OrderBy(g => g.Name).ToList();
            return View("Edit", new Movie());
        } // end method

        [HttpGet]
        public IActionResult Edit(int id) {
            ViewBag.Action = "Edit";
            ViewBag.Genres = Context.Genres.OrderBy(g => g.Name).ToList();
            var movie = Context.Movies.Find(id);

            return View(movie);
        } // end method

        [HttpPost]
        public IActionResult Edit(Movie movie) {
            if (ModelState.IsValid) {
                if (movie.MovieId == 0) { 
                    Context.Movies.Add(movie);
                } else { 
                    Context.Movies.Update(movie);
                } // end if

                Context.SaveChanges();

                return View("Index", "Home");
            } else {
                ViewBag.Action = (movie.MovieId == 0) ? "Add" : "Edit";
                ViewBag.Genres = Context.Genres.OrderBy(g => g.Name).ToList();

                return View(movie);
            } // end if
        } // end method

        [HttpGet]
        public IActionResult Delete(int id) {
            var movie = Context.Movies.Find(id);

            return View(movie);
        } // end method

        [HttpPost]
        public IActionResult Delete(Movie movie) {
            Context.Movies.Remove(movie);
            Context.SaveChanges();

            return RedirectToAction("Index", "Home");
        } // end method
    } // end class
} // end namespace
