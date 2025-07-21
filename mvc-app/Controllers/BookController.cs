using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;


namespace mvc_app.Controllers
{
    public class BookController : Controller
    {
        // GET: BookController
        public ActionResult AllBooks()
        {
            var books = new Books();
            return View(books);
        }
         public ActionResult FaviouriteBook()
        {
            var books = new Books();
            return View(books);
        }

    }
}
