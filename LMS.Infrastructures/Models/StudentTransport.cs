using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class StudentTransport
{
    public Guid TransportId { get; set; }

    public string? ModeOfTransport { get; set; }

    public int? RollNo { get; set; }

    public string? PickupPoint { get; set; }

    public Guid? StudentId { get; set; }

    public virtual Student? Student { get; set; }
}
