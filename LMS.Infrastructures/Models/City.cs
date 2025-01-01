using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class City
{
    public Guid CityId { get; set; }

    public Guid StateId { get; set; }

    public string CityName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual Staff CreatedByNavigation { get; set; } = null!;

    public virtual Staff? ModifiedByNavigation { get; set; }

    public virtual ICollection<Staff> StaffPermanentCities { get; set; } = new List<Staff>();

    public virtual ICollection<Staff> StaffPresentCities { get; set; } = new List<Staff>();

    public virtual State State { get; set; } = null!;
}
