using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class Class
{
    public Guid ClassesId { get; set; }

    public string ClassesName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }
}
