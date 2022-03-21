using Microsoft.AspNetCore.Mvc;

namespace ASPNET_TEST.Controllers
{
    public class BookController : Controller
    {
        public IActionResult List(Models.Book book = null )
        {
            if (book.Title == null)
            {
                List<Models.Book> books = new List<Models.Book>()
            {
                new Models.Book() { Title ="Hey" , pageNumber = 3 },
                new Models.Book() { Title ="Book2" , pageNumber = 4 }
            };
                return View(books);
            }
            else
            {
                return View(new List<Models.Book>() { book});
            }
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Models.Book book)
        {
            return RedirectToAction("List",book);
        }

        
    }
}
