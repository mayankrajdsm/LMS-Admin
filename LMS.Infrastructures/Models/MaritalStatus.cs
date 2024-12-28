using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class MaritalStatus
{
    public Guid MaritalStatusId { get; set; }

    public string MaritalStatusCode { get; set; } = null!;

    public string MaritalStatusName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }
}
