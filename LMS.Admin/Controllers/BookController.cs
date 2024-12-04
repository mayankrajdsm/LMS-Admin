using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService) 
        {
            _bookService = bookService;
        }
        public IActionResult Index()
        
        {
            IEnumerable<Book> books = new List<Book>();
             books = _bookService.GetAllBooks();
           

            
            return View(books);
        }
        [HttpPost]
        public IActionResult InsertBook(Book book)
        {
            try
            {
                book.BooksId = Guid.NewGuid();
                int effectedRows = _bookService.InsertBook(book);
               
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            return View();
           

        }
    }
}
