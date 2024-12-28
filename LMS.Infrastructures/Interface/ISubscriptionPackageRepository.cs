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
        Task<IEnumerable<SubscriptionPakage>> GetSubscriptionPakages();
        Task<SubscriptionPakage> GetSubscriptionPakageById(Guid subscriptionPakageId);
        Task<int> InsertSubscriptionPakage(SubscriptionPakage subscriptionPakage);
        Task<int> UpdateSubscriptionPakage(SubscriptionPakage subscriptionPakage);
        Task<int> DeleteSubscriptionPakage(Guid subscriptionPakageId);
    }
}
