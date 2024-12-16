using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class AboutU
{
    public Guid AboutUsId { get; set; }

    public string AboutUsTitle { get; set; } = null!;

    public string AboutUsText { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }
}
