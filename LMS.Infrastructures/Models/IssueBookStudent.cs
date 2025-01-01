using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class IssueBookStudent
{
    public Guid IssueBookStudentId { get; set; }

    public Guid StudentId { get; set; }

    public Guid BookId { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public Guid BuildingId { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Building Building { get; set; } = null!;

    public virtual Staff CreatedByNavigation { get; set; } = null!;

    public virtual Staff? ModifiedByNavigation { get; set; }

    public virtual Student Student { get; set; } = null!;
}
