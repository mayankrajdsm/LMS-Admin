using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Repository
{
    public class SubscriptionsTransactionRepository: ISubscriptionsTransactionRepository
    {
        private readonly FunskoolsContext _context;
        public SubscriptionsTransactionRepository(FunskoolsContext context) => _context = context;
        public async Task<IEnumerable<SubscriptionsTransaction>> GetSubscriptionsTransactions() => await _context.SubscriptionsTransactions.ToListAsync();
        public async Task<SubscriptionsTransaction> GetSubscriptionsTransactionById(Guid subscriptionsTransactionId) => await _context.SubscriptionsTransactions.FindAsync(subscriptionsTransactionId);
        public async Task<int> InsertSubscriptionsTransaction(SubscriptionsTransaction subscriptionsTransaction)
        {
            _context.SubscriptionsTransactions.Add(subscriptionsTransaction);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateSubscriptionsTransaction(SubscriptionsTransaction subscriptionsTransaction) => await _context.SaveChangesAsync();
        public async Task<int> DeleteSubscriptionsTransaction(Guid subscriptionsTransactionId)
        {
            var subscriptionsTransaction = await _context.SubscriptionsTransactions.FindAsync(subscriptionsTransactionId);
            _context.SubscriptionsTransactions.Remove(subscriptionsTransaction);
            return await _context.SaveChangesAsync();
        }
    }
}
