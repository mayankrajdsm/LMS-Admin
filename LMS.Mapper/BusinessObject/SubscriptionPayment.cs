using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.BusinessObject
{
    public class SubscriptionPayment
    {
        public string PaymentId { get; set; }

        public string ReceiptNo { get; set; } = null!;

        public string StudentTeacher { get; set; } = null!;

        public string StudentTeacherId { get; set; }

        public string SubscriptionPakageId { get; set; }

        public decimal Rate { get; set; }

        public int Months { get; set; }

        public int? DiscountPer { get; set; }

        public string PaymentStatus { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string? ModifiedBy { get; set; }

        public PaymentStatus PaymentStatusNavigation { get; set; } = null!;

        public List<SubscriptionsTransaction> SubscriptionsTransactions { get; set; } = new List<SubscriptionsTransaction>();
    }
}
