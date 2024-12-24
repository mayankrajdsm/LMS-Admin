using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface ISubscriptionPackageService
    {
        Task<List<SubscriptionPackage>> GetSubscriptionPackages();
        Task<SubscriptionPackage> GetSubscriptionPackageById(string id);
        Task<int> InsertSubscriptionPackage(SubscriptionPackage subscriptionPackage);
        Task<int> UpdateSubscriptionPackage(SubscriptionPackage subscriptionPackage);
        Task<int> DeleteSubscriptionPackage(string id);
    }
}
