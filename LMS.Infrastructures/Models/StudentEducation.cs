using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class StudentEducation
{
    public Guid EducationId { get; set; }

    public string? SchoolName { get; set; }

    public string? SchoolAddress { get; set; }

    public string? SchoolAffiliatedTo { get; set; }

    public string? Class { get; set; }

    public DateOnly? Year { get; set; }

    public int? Marks { get; set; }

    public decimal? Percentage { get; set; }

    public Guid? StudentId { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Staff? CreatedByNavigation { get; set; }

    public virtual Staff? ModifiedByNavigation { get; set; }

    public virtual Student? Student { get; set; }
}
