using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ColmSheehan.Controllers
{
    [Route("/Review")]
    public class ReviewController : Controller
    {
        [Route("Home")]
        [Route("Casa")]

        public IActionResult Index()
        {
            return View();
        }
        [Route("Details/{id?}/{title?}")]
        public IActionResult Details(int id, string title)
        {
            ViewBag.ReviewId = id;
            ViewBag.ReviewTitle = title;
            return View();
        }
    }
}