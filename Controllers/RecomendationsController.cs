using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ColmSheehan.Models;

namespace ColmSheehan.Controllers
{
    public class RecomendationsController : Controller
    {
        public IActionResult Index()
        {
           ViewBag.recommendations = DB.recommendations;
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Recommendation rec)
        {
            if (ModelState.IsValid)
            {
                DB.recommendations.Add(rec);
                return View("Thanks", rec);
            }
            else
            {
                
                return View(rec);
            }
        }
    }
}