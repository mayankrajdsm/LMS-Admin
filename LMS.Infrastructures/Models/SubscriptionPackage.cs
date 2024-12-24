using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class SubscriptionPackage
{
    public Guid SubscriptionPackageId { get; set; }

    public string SubscriptionPackageName { get; set; } = null!;

    public int SubscriptionPeriodMonths { get; set; }

    public decimal PriceMonth { get; set; }

    public int? DiscountPer { get; set; }

    public string Decription { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual ICollection<SubscriptionsTransaction> SubscriptionsTransactions { get; set; } = new List<SubscriptionsTransaction>();
}
