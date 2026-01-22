using Ch4Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ch4Lab2.Controllers {
    public class CharacterController : Controller {
        private CharacterContext Context { get; set; }

        // Constructor method
        public CharacterController(CharacterContext context) {
            this.Context = context;
        } // end method

        [HttpGet]
        public IActionResult CharacterIndex() {
            // Querying the database to return ALL Ancestries ordered by name
            List<Character> characters = this.Context.Characters
                .Include(c => c.Ancestry) // when extracting properties from other classes make sure to add Include
                .Include(c => c.Class)
                .OrderBy(c => c.LastName).ToList();
           
            return View(characters);   // Passes movies list object to the view
        } // end method

        [HttpGet]
        public IActionResult Add() {
            ViewBag.Action = "Add";
            ViewBag.Classes = Context.Classes.OrderBy(c => c.Name).ToList();
            ViewBag.Ancestry = Context.Ancestors.OrderBy(a => a.Origin).ToList();
            return View("Edit", new Character()); // Creates a new Character object
        } // end method

        [HttpGet]
        public IActionResult Edit(int id) {
            // Edits exitsing Character objects
            ViewBag.Action = "Edit";
            ViewBag.Classes = Context.Classes.OrderBy(c => c.Name).ToList();
            ViewBag.Ancestry = Context.Ancestors.OrderBy(a => a.Origin).ToList();
            var characters = Context.Characters.Find(id); //Identified by PK id

            return View(characters); 
        } // end method

        [HttpPost]
        public IActionResult Edit(Character characters) {
            if (ModelState.IsValid) {
                if (characters.CharacterID == 0) { //Checks if its a new character
                    Context.Characters.Add(characters);
                } else {
                    Context.Characters.Update(characters); // else updates the changes
                } // end if

                Context.SaveChanges(); // saves changes

                return RedirectToAction("CharacterIndex", "Character"); // shows all characters
            } else {
                ViewBag.Action = (characters.CharacterID == 0) ? "Add" : "Edit";
                ViewBag.Classes = Context.Classes.OrderBy(c => c.Name).ToList();
                ViewBag.Ancestry = Context.Ancestors.OrderBy(a => a.Origin).ToList();

                return View(characters);
            } // end if
        } // end method

        [HttpGet]
        public IActionResult Delete(int id) {
            var characters = Context.Characters.Find(id);
            
            return View(characters);
        } // end method

        
        [HttpPost]
        public IActionResult Delete(Character characters) {
            // Delets character objects base on PK
            Context.Characters.Remove(characters);
            Context.SaveChanges();
            //Shows all characters
            return RedirectToAction("CharacterIndex", "Character");
        } // end method

    }

}


