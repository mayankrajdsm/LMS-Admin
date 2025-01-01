using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class StaffExperience
{
    public Guid StaffExperienceId { get; set; }

    public Guid StaffId { get; set; }

    public string Organization { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public DateTime From { get; set; }

    public DateTime To { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public virtual Staff CreatedByNavigation { get; set; } = null!;

    public virtual Staff Staff { get; set; } = null!;
}
