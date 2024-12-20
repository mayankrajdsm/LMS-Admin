using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class PaymentStatus
{
    public Guid PaymentStatusId { get; set; }

    public string PaymentStatusName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual ICollection<SubscriptionPayment> SubscriptionPayments { get; set; } = new List<SubscriptionPayment>();
}
