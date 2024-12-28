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
    public class SubscriptionPaymentRepository : ISubscriptionPaymentRepository
    {
        private readonly TestContext _context;
        public SubscriptionPaymentRepository(TestContext context) => _context = context;
        public async Task<IEnumerable<SubscriptionPayment>> GetSubscriptionPayments() => await _context.SubscriptionPayments.ToListAsync();
        public async Task<SubscriptionPayment> GetSubscriptionPaymentById(Guid subscriptionPaymentId) => await _context.SubscriptionPayments.FindAsync(subscriptionPaymentId);
        public async Task<int> InsertSubscriptionPayment(SubscriptionPayment subscriptionPayment)
        {
            _context.SubscriptionPayments.Add(subscriptionPayment);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateSubscriptionPayment(SubscriptionPayment subscriptionPayment) => await _context.SaveChangesAsync();
        public async Task<int> DeleteSubscriptionPayment(Guid subscriptionPaymentId)
        {
            var subscriptionPayment = await _context.SubscriptionPayments.FindAsync(subscriptionPaymentId);
            _context.SubscriptionPayments.Remove(subscriptionPayment);
            return await _context.SaveChangesAsync();
        }
    }
}
