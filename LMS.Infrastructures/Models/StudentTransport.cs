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

    public Guid? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Staff? CreatedByNavigation { get; set; }

    public virtual Staff? ModifiedByNavigation { get; set; }

    public virtual Student? Student { get; set; }
}
