using Ch4Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ch4Lab2.Controllers {
    public class ClassController : Controller {

        // Auto-implemented property (private)
        private CharacterContext Context { get; set; }

        // Constructor method
        public ClassController(CharacterContext context) {
            this.Context = context;
        } // end method

        [HttpGet]
        public IActionResult ClassIndex() {
            // Querying the database to return ALL Classes ordered by name
            List<Class> classes = Context.Classes
                .OrderBy(a => a.Name)
                .ToList();

            return View(classes);    // Passes Class list object to the view
        } // end method

        [HttpGet]
        public IActionResult Add() {
            ViewBag.Action = "Add";
            ViewBag.Class = Context.Classes.OrderBy(c => c.Name).ToList();
            return View("Edit", new Class());
        } // end method

        [HttpGet]
        public IActionResult Edit(int id) {
            ViewBag.Action = "Edit";
            ViewBag.Class = Context.Classes.OrderBy(c => c.Name).ToList();
            var classes = Context.Classes.Find(id);

            return View(classes); // Passes Class list object to the view
        } // end method

        [HttpPost]
        public IActionResult Edit(Class classes) {
            if (ModelState.IsValid) {
                if (classes.ClassId == 0) {
                    Context.Classes.Add(classes);
                } else {
                    Context.Classes.Update(classes);
                } // end if

                Context.SaveChanges();

                return RedirectToAction("ClassIndex", "Classes");
            } else {
                ViewBag.Action = (classes.ClassId == 0) ? "Add" : "Edit";
                ViewBag.Class = Context.Classes.OrderBy(c => c.Name).ToList();

                return View(classes); // Passes Class list object to the view
            } // end if
        } // end method

        [HttpGet]
        public IActionResult Delete(int id) {
            var classes = Context.Classes.Find(id);

            return View(classes);
        } // end method

        // May need to change this
        [HttpPost]
        public IActionResult Delete(Class classes) {
            Context.Classes.Remove(classes);
            Context.SaveChanges();

            return RedirectToAction("ClassIndex", "Class");
        } // end method
    }
}
