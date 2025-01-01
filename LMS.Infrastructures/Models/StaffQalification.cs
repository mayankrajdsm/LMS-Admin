using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class StaffQalification
{
    public Guid StaffQalificationId { get; set; }

    public Guid StaffId { get; set; }

    public string Qualification { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Board { get; set; } = null!;

    public int PassingYear { get; set; }

    public int Percentage { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public virtual Staff Staff { get; set; } = null!;
}
