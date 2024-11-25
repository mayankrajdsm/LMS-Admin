using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class Domain
{
    public Guid DomainId { get; set; }

    public string RegisteredName { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public Guid CountryId { get; set; }

    public Guid StateId { get; set; }

    public Guid CityId { get; set; }

    public string ContactPerson { get; set; } = null!;

    public string ContactNo { get; set; } = null!;

    public string ContactEmail { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual ICollection<Building> Buildings { get; set; } = new List<Building>();
}
