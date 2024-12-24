using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.BusinessObject
{
    public class SubscriptionPackage
    {
        public string SubscriptionPackageId { get; set; }

        public string SubscriptionPackageName { get; set; } = null!;

        public int SubscriptionPeriodMonths { get; set; }

        public decimal PriceMonth { get; set; }

        public int? DiscountPer { get; set; }

        public string Decription { get; set; } = null!;

        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string? ModifiedBy { get; set; }

        public List<SubscriptionsTransaction> SubscriptionsTransactions { get; set; } = new List<SubscriptionsTransaction>();
    }
}
