using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class StudentContact
{
    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? City { get; set; }

    public string? District { get; set; }

    public string? State { get; set; }

    public int? PinCode { get; set; }

    public string? Country { get; set; }

    public long? Mobile { get; set; }

    public long? FatherMobile { get; set; }

    public long? MotherMobile { get; set; }

    public string? Email { get; set; }

    public string? AlternateEmail { get; set; }

    public Guid? StudentId { get; set; }

    public virtual Student? Student { get; set; }
}
