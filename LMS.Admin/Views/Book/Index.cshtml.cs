using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LMS.Admin.Models;

namespace LMS.Admin.Views.Book
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
            
        }
        public IList<Books> allbooks { get; set; }
        public void OnGet()
        {

            var date = new DateTime(2024, 02, 10);
            List<Books> books = new List<Books>();
            books.Add(new Books
            {
                AccessionNumber = 1,
                Author = "author1",
                Barcode = "barcode1",
                BookNumber = 1121,
                BillDate = date,
                BillNo = 121,
                BooksId = new Guid(),
                ClassNo = 122,
                CollectionNo = 121,
                Cost = 1212,
                CustomTags = "customerTags1",
                Discount = 111,
                Edition = "edition1",
                Isbnnumber = 1112,
                IssueNo = 33,
                Language = "en",
                Location = "India",
                MonthandYear = "feb2024",
                NoofCopies = 12,
                OriginalAmount = 1121,
                Pages = "page1",
                Publisher = "publisher1",
                PublisherLocation = "india",
                RackNo = 11,
                Reference = "reference1",
                Remarks = "remark1",
                Series = "series1",
                ShelfNo = 1212,
                Source = "source1",
                SubjectCode = 121,
                Title = "Title1",
                VendorName = "vendor1",
                VendorPlace = "Delhi",
                Volume = "volume1",
                WithdrawalOn = new DateTime(2024, 12, 12),
                Year = 2024
            });
            books.Add(new Books
            {
                AccessionNumber = 1,
                Author = "author1",
                Barcode = "barcode1",
                BookNumber = 1121,
                BillDate = date,
                BillNo = 121,
                BooksId = new Guid(),
                ClassNo = 122,
                CollectionNo = 121,
                Cost = 1212,
                CustomTags = "customerTags1",
                Discount = 111,
                Edition = "edition1",
                Isbnnumber = 1112,
                IssueNo = 33,
                Language = "en",
                Location = "India",
                MonthandYear = "feb2024",
                NoofCopies = 12,
                OriginalAmount = 1121,
                Pages = "page1",
                Publisher = "publisher1",
                PublisherLocation = "india",
                RackNo = 11,
                Reference = "reference1",
                Remarks = "remark1",
                Series = "series1",
                ShelfNo = 1212,
                Source = "source1",
                SubjectCode = 121,
                Title = "Title1",
                VendorName = "vendor1",
                VendorPlace = "Delhi",
                Volume = "volume1",
                WithdrawalOn = new DateTime(2024, 12, 12),
                Year = 2024
            });
            allbooks = books.ToList();
        }
    }
}
