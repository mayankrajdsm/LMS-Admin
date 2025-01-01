using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class LoginType
{
    public Guid LoginTypeId { get; set; }

    public string LoginTypeName { get; set; } = null!;

    public string LoginTypeKey { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual Staff CreatedByNavigation { get; set; } = null!;

    public virtual Staff? ModifiedByNavigation { get; set; }

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
