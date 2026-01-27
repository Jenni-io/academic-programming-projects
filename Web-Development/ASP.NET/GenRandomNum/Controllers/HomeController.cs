using GenRandomNum.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GenRandomNum.Controllers { 

    public class HomeController : Controller
    {
            [HttpGet]
            public IActionResult Index()
            {
                ViewBag.NumToGen = "0";
                NumToGenerate.numbers.Clear();
             return View();
            }
            [HttpPost]


            public IActionResult Index(NumToGenerate model)
            {
                if (ModelState.IsValid)
                {
                    ViewBag.NumToGen = model.GetRandomNumFromRange();
                
            }
                else {

                    ViewBag.NumToGen = "0";

                return View(model);
            }

            
            return View(model);
            }
    }
}

