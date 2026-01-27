using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieList.Models;

namespace MovieList.Controllers {
    public class GenreController : Controller {
        // Auto-implemented property (private)
        private MovieContext Context { get; set; }

        // Constructor method
        public GenreController(MovieContext context) {
            this.Context = context;
        } // end method

        [HttpGet]
        public IActionResult GenreIndex() {
            // Querying the database to return ALL movies ordered by name

            List<Genre> genre = Context.Genres
                .OrderBy(g => g.Name)
                .ToList();

            return View(genre);    // Passes movies list object to the view
        } // end method

        [HttpGet]
        public IActionResult Add() {
            ViewBag.Action = "Add";
            ViewBag.Genres = Context.Genres.OrderBy(g => g.Name).ToList();
            return View("Edit", new Genre());
        } // end method

        [HttpGet]
        public IActionResult Edit(int id) {
            ViewBag.Action = "Edit";
            ViewBag.Genres = Context.Genres.OrderBy(g => g.Name).ToList();
            var genre = Context.Genres.Find(id);

            return View(genre);
        } // end method

        [HttpPost]
        public IActionResult Edit(Genre genre) {
            if (ModelState.IsValid) {
                if (genre.GenreId == 0) {
                    Context.Genres.Add(genre);
                } else {
                    Context.Genres.Update(genre);
                } // end if

                Context.SaveChanges();

                return RedirectToAction("GenreIndex", "Genre");
            } else {
                ViewBag.Action = (genre.GenreId == 0) ? "Add" : "Edit";
                ViewBag.Genres = Context.Genres.OrderBy(g => g.Name).ToList();

                return View(genre);
            } // end if
        } // end method

        [HttpGet]
        public IActionResult Delete(int id) {
            var genre = Context.Genres.Find(id);

            return View(genre);
        } // end method

        // May need to change this
        [HttpPost]
        public IActionResult Delete(Genre genre) {
            Context.Genres.Remove(genre);
            Context.SaveChanges();

            return RedirectToAction("GenreIndex", "Genre");
        } // end method
    } // end class
} // end namespace
