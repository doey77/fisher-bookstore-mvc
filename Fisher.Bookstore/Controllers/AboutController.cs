using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the About controller's index");
        }
        public IActionResult History()
        {
            return Content("This is the About controller's history");
        }
        public IActionResult Location()
        {
            return Content("This is the About controller's location");
        }
    }
}