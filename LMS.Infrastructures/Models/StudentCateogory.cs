using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class StudentCateogory
{
    public Guid StudentCateogoryId { get; set; }

    public string StudentCateogoryName { get; set; } = null!;

    public int DiscountPer { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }
}
