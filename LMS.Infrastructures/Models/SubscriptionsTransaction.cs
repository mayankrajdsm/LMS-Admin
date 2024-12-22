using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class SubscriptionsTransaction
{
    public Guid SubscriptionsTransactionStudentId { get; set; }

    public string StudentTeacherId { get; set; } = null!;

    public Guid StudentId { get; set; }

    public Guid SubscriptionPakageId { get; set; }

    public Guid PaymentId { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public SubscriptionPayment Payment { get; set; } = null!;

    public Student Student { get; set; } = null!;

    public SubscriptionPakage SubscriptionPakage { get; set; } = null!;
}
