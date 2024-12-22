using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface ISubscriptionsTransactionService
    {
        Task<List<SubscriptionsTransaction>> GetSubscriptionsTransactions();
        Task<SubscriptionsTransaction> GetSubscriptionsTransactionById(string id);
        Task<int> InsertSubscriptionsTransaction(SubscriptionsTransaction subscriptionsTransaction);
        Task<int> UpdateSubscriptionsTransaction(SubscriptionsTransaction subscriptionsTransaction);
        Task<int> DeleteSubscriptionsTransaction(string id);
    }
}
