using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface ISubscriptionPaymentRepository
    {
        Task<IEnumerable<SubscriptionPayment>> GetSubscriptionPayments();
        Task<SubscriptionPayment> GetSubscriptionPaymentById(Guid subscriptionPaymentId);
        Task<int> InsertSubscriptionPayment(SubscriptionPayment subscriptionPayment);
        Task<int> UpdateSubscriptionPayment(SubscriptionPayment subscriptionPayment);
        Task<int> DeleteSubscriptionPayment(Guid subscriptionPaymentId);
    }
}
