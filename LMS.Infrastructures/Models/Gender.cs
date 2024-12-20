using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class Gender
{
    public Guid GenderId { get; set; }

    public string GenderCode { get; set; } = null!;

    public string GenderName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }
}
