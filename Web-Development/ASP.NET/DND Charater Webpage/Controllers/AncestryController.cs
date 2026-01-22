using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ch4Lab2.Models;
using Humanizer.Localisation;

namespace Ch4Lab2.Controllers
{
    public class AncestryController : Controller
    {
        // Auto-implemented property (private)
        private CharacterContext Context { get; set; }

        // Constructor method
        public AncestryController(CharacterContext context) {
            this.Context = context;
        } // end method

        [HttpGet]
        public IActionResult AncestryIndex() {
            // Querying the database to return ALL Ancestries ordered by name
            List<Ancestry> ancestry = Context.Ancestors
                .OrderBy(a => a.Origin)
                .ToList();

            return View(ancestry);    // Passes ancestry list object to the view
        } // end method

        [HttpGet]
        public IActionResult Add() {
            ViewBag.Action = "Add";
            ViewBag.Ancestry = Context.Ancestors.OrderBy(a => a.Origin).ToList();
            return View("Edit", new Ancestry()); // creates new ancestry object
        } // end method

        [HttpGet]
        public IActionResult Edit(int id) {
            ViewBag.Action = "Edit";
            ViewBag.Ancestry = Context.Ancestors.OrderBy(a => a.Origin).ToList();
            var ancestry = Context.Ancestors.Find(id);
            // edit existing record
            return View(ancestry);
        } // end method

        [HttpPost]
        public IActionResult Edit(Ancestry ancestry) {
            // creates a new ancestry if ID is 0
            if (ModelState.IsValid) {
                if (ancestry.AncestryId == 0) {
                    Context.Ancestors.Add(ancestry);
                } else {
                    Context.Ancestors.Update(ancestry);
                } // end if

                Context.SaveChanges();

                return RedirectToAction("AncestryIndex", "Ancestry");
            } else {
                ViewBag.Action = (ancestry.AncestryId == 0) ? "Add" : "Edit";
                ViewBag.Ancestry = Context.Ancestors.OrderBy(a => a.Origin).ToList();

                return View(ancestry);
            } // end if
        } // end method

        [HttpGet]
        public IActionResult Delete(int id) {
            var ancestry = Context.Ancestors.Find(id);

            return View(ancestry);
        } // end method

        // May need to change this
        [HttpPost]
        public IActionResult Delete(Ancestry ancestry) {
            Context.Ancestors.Remove(ancestry);
            Context.SaveChanges();

            return RedirectToAction("AncestryIndex", "Ancestry");
        } // end method

    }
}
