using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface ISubscriptionPakageService
    {
       Task<List<SubscriptionPakage>> GetSubscriptionPakages();
       Task<SubscriptionPakage> GetSubscriptionPakageById(string id);
       Task<int> InsertSubscriptionPakage(SubscriptionPakage subscriptionPakage);
       Task<int> UpdateSubscriptionPakage(SubscriptionPakage subscriptionPakage);
       Task<int> DeleteSubscriptionPakage(string id);
    }
}
