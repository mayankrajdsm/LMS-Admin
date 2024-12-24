using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class SubscriptionPayment
{
    public Guid PaymentId { get; set; }

    public string ReceiptNo { get; set; } = null!;

    public string StudentTeacher { get; set; } = null!;

    public Guid StudentTeacherId { get; set; }

    public Guid SubscriptionPakageId { get; set; }

    public decimal Rate { get; set; }

    public int Months { get; set; }

    public int? DiscountPer { get; set; }

    public Guid PaymentStatus { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual PaymentStatus PaymentStatusNavigation { get; set; } = null!;

    public virtual ICollection<SubscriptionsTransaction> SubscriptionsTransactions { get; set; } = new List<SubscriptionsTransaction>();
}
