using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class Designation
{
    public Guid DesignationId { get; set; }

    public string DesignationName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }
}
