namespace LMS.Admin.Models
{
    public class Books
    {
        public Guid BooksId { get; set; }

        public int AccessionNumber { get; set; }

        public DateTime AccessorDate { get; set; }

        public string Barcode { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string Author { get; set; } = null!;

        public int Year { get; set; }

        public string Edition { get; set; } = null!;

        public string Publisher { get; set; } = null!;

        public string PublisherLocation { get; set; } = null!;

        public string Volume { get; set; } = null!;

        public string VendorName { get; set; } = null!;

        public string VendorPlace { get; set; } = null!;

        public int OriginalAmount { get; set; }

        public int Cost { get; set; }

        public decimal Discount { get; set; }

        public int BillNo { get; set; }

        public int NoofCopies { get; set; }

        public DateTime BillDate { get; set; }

        public int ClassNo { get; set; }

        public int BookNumber { get; set; }

        public int CollectionNo { get; set; }

        public long Isbnnumber { get; set; }

        public string Location { get; set; } = null!;

        public int RackNo { get; set; }

        public int ShelfNo { get; set; }

        public string Language { get; set; } = null!;

        public string Series { get; set; } = null!;

        public int IssueNo { get; set; }

        public DateTime WithdrawalOn { get; set; }

        public string CustomTags { get; set; } = null!;

        public string Remarks { get; set; } = null!;

        public int SubjectCode { get; set; }

        public string Pages { get; set; } = null!;

        public string MonthandYear { get; set; } = null!;

        public string Source { get; set; } = null!;

        public string Reference { get; set; } = null!;
    }
}
