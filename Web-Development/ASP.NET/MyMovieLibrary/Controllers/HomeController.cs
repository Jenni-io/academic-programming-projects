using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieList.Models;

namespace MovieList.Controllers
{
    public class HomeController : Controller
    {
        // Auto-implemented property (private)
        private MovieContext Context { get; set; }

        // Constructor method
        public HomeController(MovieContext context) {
            this.Context = context;
        } // end method

        public IActionResult Index() {
            // Querying the database to return ALL movies ordered by name
            
            List<Movie> movies = Context.Movies
                .Include(m => m.Genre)
                .OrderBy(m => m.Name)
                .ToList();

            return View(movies);    // Passes movies list object to the view
        } // end method
    } // end class
} // end namespace