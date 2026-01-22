using System.Diagnostics;
using Ch4Lab2.Models;
using Microsoft.AspNetCore.Mvc;

// DO NOT DELETE IS NEEDED STARTS THE PROGRAM
namespace Ch4Lab2.Controllers {
    public class HomeController : Controller {
        // This property is used to communicate with the database
        private CharacterContext Context { get; set; }

        public HomeController(CharacterContext context) {
            this.Context = context;
        } // end method

        public IActionResult Index() {

            List<Character> characters = this.Context.Characters.OrderBy(c => c.LastName).ToList();
            return View(characters);
        } // end method
    } // end class
} // end namespace
