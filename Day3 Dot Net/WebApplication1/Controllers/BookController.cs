using WebApplication1.Models;
using WebApplication1.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly BooksService bookService;
        public BookController(BooksService book)
        {
            this.bookService = book;
        }

        [HttpPost]
        [Route("Add")]
        public ActionResult AddBook(Book book)
        {
            this.bookService.AddBook(book);
            return Ok("Book Created");
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult GetAll()
        {
            return Ok(this.bookService.GetAll());
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult GetById(int id)
        {
            var res = this.bookService.GetBookById(id);
            if (res != null) { return Ok(res); }
            return NotFound("Book not found");
        }
    }
}
