using LMS.Admin.Models;
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
            List<Books> books = new List<Books>();
            var result=_bookService.GetAllBooks();
            foreach (var item in result) 
            {
                Books book = new Books();
                book.AccessionNumber = item.AccessionNumber;
                book.AccessorDate = item.AccessorDate;
                book.Author = item.Author;
                book.Barcode = item.Barcode;
                book.BookNumber = item.BookNumber;
                book.BillDate = item.BillDate;
                book.BillNo = item.BillNo;
                book.BooksId = item.BooksId;
                book.ClassNo = item.ClassNo;
                book.CollectionNo = item.CollectionNo;
                book.Cost = item.Cost;
                book.CustomTags = item.CustomTags;
                book.Discount = item.Discount;
                book.Edition = item.Edition;
                book.Isbnnumber = item.Isbnnumber;
                book.IssueNo = item.IssueNo;
                book.Language = item.Language;
                book.Location = item.Location;
                book.MonthandYear = item.MonthandYear;
                book.NoofCopies = item.NoofCopies;
                book.OriginalAmount = item.OriginalAmount;
                book.Pages = item.Pages;
                book.Publisher = item.Publisher;
                book.PublisherLocation = item.PublisherLocation;
                book.RackNo = item.RackNo;
                book.Reference = item.Reference;
                book.Remarks = item.Remarks;
                book.Series = item.Series;
                book.ShelfNo = item.ShelfNo;
                book.Source = item.Source;
                book.SubjectCode = item.SubjectCode;
                book.Title = item.Title;
                book.VendorName = item.VendorName;
                book.VendorPlace = item.VendorPlace;
                book.Volume = item.Volume;
                book.WithdrawalOn = item.WithdrawalOn;
                book.Year = item.Year;
                books.Add(book);

            }
            
            return View(books);
        }
        [HttpPost]
        public int InsertBook(Books book) 
        {
            return 1;
        }
    }
}
