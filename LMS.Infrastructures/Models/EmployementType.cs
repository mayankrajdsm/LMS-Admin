using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class EmployementType
{
    public Guid EmployementTypeId { get; set; }

    public string EmployementTypeCode { get; set; } = null!;

    public string EmployementTypeName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual Staff CreatedByNavigation { get; set; } = null!;

    public virtual Staff? ModifiedByNavigation { get; set; }

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
