using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the Books controller's index");
        }
        public IActionResult New()
        {
            return Content("This is the Books controller's new books page");
        }
        [ActionName("best-sellers")]
        public IActionResult bestsellers()
        {
            return Content("This is the Books controller's best sellers page");
        }
    }
}