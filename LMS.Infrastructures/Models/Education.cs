using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class Education
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

    public virtual Student? Student { get; set; }
}
