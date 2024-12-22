using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface ISubscriptionPaymentService
    {
        Task<List<SubscriptionPayment>> GetSubscriptionPayments();
        Task<SubscriptionPayment> GetSubscriptionPakageById(string id);
        Task<int> InsertSubscriptionPayment(SubscriptionPayment subscriptionPayment);
        Task<int> UpdateSubscriptionPayment(SubscriptionPayment subscriptionPayment);
        Task<int> DeleteSubscriptionPayment(string id);
    }
}
