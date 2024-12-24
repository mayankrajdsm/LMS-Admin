using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface ISubscriptionPackageRepository
    {
        Task<IEnumerable<SubscriptionPackage>> GetSubscriptionPackages();
        Task<SubscriptionPackage> GetSubscriptionPackageById(Guid subscriptionPackageId);
        Task<int> InsertSubscriptionPackage(SubscriptionPackage subscriptionPackage);
        Task<int> UpdateSubscriptionPackage(SubscriptionPackage subscriptionPackage);
        Task<int> DeleteSubscriptionPackage(Guid subscriptionPackageId);
    }
}
