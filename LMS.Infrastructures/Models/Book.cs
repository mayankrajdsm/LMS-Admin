using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class Book
{
    public Guid BooksId { get; set; }

    public Guid ClassesId { get; set; }

    public string BooksName { get; set; } = null!;

    public string AuthorName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual Class Classes { get; set; } = null!;
}
