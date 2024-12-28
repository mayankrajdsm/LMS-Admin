using Microsoft.AspNetCore.Mvc.RazorPages;
using LMS.Admin.Models;
using LMS.Mapper.IService;
using entity = LMS.Infrastructures.Models;
using LMS.Infrastructures.Models;
using Microsoft.AspNetCore.Mvc.Razor;
using LMS.Mapper.Services;
using Microsoft.AspNetCore.Mvc;


namespace LMS.Admin.Views.Books
{
    public class IndexModel : PageModel
    {
        private readonly IBookService _bookService;
        public IndexModel(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IEnumerable<entity.Book> allbooks { get; set; }
        public void OnGet()
        {
        allbooks = _bookService.GetAllBooks();
           
        }
        [BindProperty]
        public entity.Book book { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page(); // Return the page with validation errors
            }
            book.BooksId = Guid.NewGuid();

            int result = _bookService.InsertBook(book);

            return RedirectToPage(); // Redirect to the same page (or another page if needed)
        }
    }
}
