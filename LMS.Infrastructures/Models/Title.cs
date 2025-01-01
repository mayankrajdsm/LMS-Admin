using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class Title
{
    public Guid TitleId { get; set; }

    public string TitleCode { get; set; } = null!;

    public string TitleName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
