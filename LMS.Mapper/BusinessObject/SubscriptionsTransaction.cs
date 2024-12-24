using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.BusinessObject
{
    public class SubscriptionsTransaction
    {
        public string SubscriptionsTransactionStudentId { get; set; }

        public string StudentTeacher { get; set; } = null!;

        public string StudentTeacherId { get; set; }

        public string SubscriptionPakageId { get; set; }

        public string PaymentId { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime ValidTo { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string? ModifiedBy { get; set; }

        public SubscriptionPayment Payment { get; set; } = null!;

        public Student Student { get; set; } = null!;

        public SubscriptionPackage SubscriptionPakage { get; set; } = null!;
    }
}
