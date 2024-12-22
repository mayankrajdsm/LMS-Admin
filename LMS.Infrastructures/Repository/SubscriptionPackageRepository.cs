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
    public class SubscriptionPackageRepository: ISubscriptionPackageRepository
    {
        private readonly TestContext _context;
        public SubscriptionPackageRepository(TestContext context) => _context = context;
        public async Task<IEnumerable<SubscriptionPakage>> GetSubscriptionPakages() => await _context.SubscriptionPakages.ToListAsync();
        public async Task<SubscriptionPakage> GetSubscriptionPakageById(Guid subscriptionPakageId) => await _context.SubscriptionPakages.FindAsync(subscriptionPakageId);
        public async Task<int> InsertSubscriptionPakage(SubscriptionPakage subscriptionPakage)
        {
            _context.SubscriptionPakages.Add(subscriptionPakage);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateSubscriptionPakage(SubscriptionPakage subscriptionPakage) => await _context.SaveChangesAsync();
        public async Task<int> DeleteSubscriptionPakage(Guid subscriptionPakageId)
        {
            var subscriptionPakage = await _context.SubscriptionPakages.FindAsync(subscriptionPakageId);
            _context.SubscriptionPakages.Remove(subscriptionPakage);
            return await _context.SaveChangesAsync();
        }
    }
}
