using LMS.Infrastructures.Interface;
using LMS.Mapper.BusinessObject;
using LMS.Mapper.ConversionHelper;
using LMS.Mapper.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.Services
{
    public class SubscriptionsTransactionService : ISubscriptionsTransactionService
    {
        private readonly ISubscriptionsTransactionRepository _subscriptionsTransactionRepository;
        public SubscriptionsTransactionService(ISubscriptionsTransactionRepository subscriptionsTransactionRepository) => _subscriptionsTransactionRepository = subscriptionsTransactionRepository;
        public async Task<List<SubscriptionsTransaction>> GetSubscriptionsTransactions()
        {
            List<SubscriptionsTransaction> subscriptionsTransactions = new List<SubscriptionsTransaction>();
            var existingSubscriptionsTransaction = await _subscriptionsTransactionRepository.GetSubscriptionsTransactions();
            if (existingSubscriptionsTransaction != null)
            {
                foreach (var subscriptionsTransaction in existingSubscriptionsTransaction)
                {
                    subscriptionsTransactions.Add(subscriptionsTransaction.ToBusinessObject());
                }
            }
            return subscriptionsTransactions;
        }
        public async Task<SubscriptionsTransaction> GetSubscriptionsTransactionById(string id)
        {
            var subscriptionsTransaction = await _subscriptionsTransactionRepository.GetSubscriptionsTransactionById(Guid.Parse(id));
            return subscriptionsTransaction.ToBusinessObject();
        }
        public async Task<int> InsertSubscriptionsTransaction(SubscriptionsTransaction subscriptionsTransaction) => await _subscriptionsTransactionRepository.InsertSubscriptionsTransaction(subscriptionsTransaction.ToEntityModel());
        public async Task<int> UpdateSubscriptionsTransaction(SubscriptionsTransaction subscriptionsTransaction) => await _subscriptionsTransactionRepository.UpdateSubscriptionsTransaction(subscriptionsTransaction.ToEntityModel());
        public async Task<int> DeleteSubscriptionsTransaction(string id) => await _subscriptionsTransactionRepository.DeleteSubscriptionsTransaction(Guid.Parse(id));
    }
}
