using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class SocialCategory
{
    public Guid SocialCategoryId { get; set; }

    public string SocialCategoryCode { get; set; } = null!;

    public string SocialCategoryName { get; set; } = null!;

    public int DiscountPer { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual Staff CreatedByNavigation { get; set; } = null!;

    public virtual Staff? ModifiedByNavigation { get; set; }

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
