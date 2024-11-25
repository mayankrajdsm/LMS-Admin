using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class Country
{
    public Guid CountryId { get; set; }

    public string CountryName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual ICollection<State> States { get; set; } = new List<State>();
}
