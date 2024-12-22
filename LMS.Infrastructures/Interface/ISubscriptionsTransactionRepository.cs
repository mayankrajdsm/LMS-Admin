using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface ISubscriptionsTransactionRepository
    {
        Task<IEnumerable<SubscriptionsTransaction>> GetSubscriptionsTransactions();
        Task<SubscriptionsTransaction> GetSubscriptionsTransactionById(Guid subscriptionsTransactionId);
        Task<int> InsertSubscriptionsTransaction(SubscriptionsTransaction subscriptionsTransaction);
        Task<int> UpdateSubscriptionsTransaction(SubscriptionsTransaction subscriptionsTransaction);
        Task<int> DeleteSubscriptionsTransaction(Guid subscriptionsTransactionId);
    }
}
