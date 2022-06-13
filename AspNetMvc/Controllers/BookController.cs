using AspNetMvc.Models.ORM;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Controllers
{
    public class BookController : Controller
    {
        SiemensContext siemensContext = new SiemensContext();
        public IActionResult Add()

        {

            return View();

        }
        [HttpPost]
        public IActionResult Add(Book book)
        {
            siemensContext.Books.Add(book);
            siemensContext.SaveChanges();

            return View();

        }
        public IActionResult List()
        {
            var books = siemensContext.Books.ToList();
            return View(books);
        }
    }
}