using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the Authors controller's index");
        }
        public IActionResult Featured()
        {
            return Content("This is the Authors controller's featured authors page");
        }
    }
}