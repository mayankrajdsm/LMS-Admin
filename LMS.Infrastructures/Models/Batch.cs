using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class Batch
{
    public Guid BatchId { get; set; }

    public string BatchCode { get; set; } = null!;

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }
}
