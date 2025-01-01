using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class SubscriptionsTransaction
{
    public Guid SubscriptionsTransactionStudentId { get; set; }

    public string StudentTeacher { get; set; } = null!;

    public Guid StudentTeacherId { get; set; }

    public Guid SubscriptionPakageId { get; set; }

    public Guid PaymentId { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual Staff CreatedByNavigation { get; set; } = null!;

    public virtual Staff? ModifiedByNavigation { get; set; }

    public virtual SubscriptionPayment Payment { get; set; } = null!;

    public virtual Student StudentTeacherNavigation { get; set; } = null!;

    public virtual SubscriptionPackage SubscriptionPakage { get; set; } = null!;
}
