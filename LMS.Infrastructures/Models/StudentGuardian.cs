using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class StudentGuardian
{
    public Guid GuardianId { get; set; }

    public string? Name { get; set; }

    public string? Adhar { get; set; }

    public string? Relation { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Education { get; set; }

    public string? Occupation { get; set; }

    public long? AnnualIncome { get; set; }

    public string? OrganizationName { get; set; }

    public string? Designation { get; set; }

    public string? OfficeContact { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? OfficeAddress { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public int? Pincode { get; set; }

    public string? Country { get; set; }

    public string? Mobile { get; set; }

    public Guid? StudentId { get; set; }

    public virtual Student? Student { get; set; }
}
