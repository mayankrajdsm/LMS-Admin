using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class State
{
    public Guid StateId { get; set; }

    public Guid CountryId { get; set; }

    public string StateName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual Country Country { get; set; } = null!;

    public virtual Staff CreatedByNavigation { get; set; } = null!;

    public virtual Staff? ModifiedByNavigation { get; set; }

    public virtual ICollection<Staff> StaffPermanentStates { get; set; } = new List<Staff>();

    public virtual ICollection<Staff> StaffPresentStates { get; set; } = new List<Staff>();
}
