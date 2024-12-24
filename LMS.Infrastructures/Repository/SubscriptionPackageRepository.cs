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
        public async Task<IEnumerable<SubscriptionPackage>> GetSubscriptionPackages() => await _context.SubscriptionPackages.ToListAsync();
        public async Task<SubscriptionPackage> GetSubscriptionPackageById(Guid subscriptionPackageId) => await _context.SubscriptionPackages.FindAsync(subscriptionPackageId);
        public async Task<int> InsertSubscriptionPackage(SubscriptionPackage subscriptionPackage)
        {
            _context.SubscriptionPackages.Add(subscriptionPackage);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateSubscriptionPackage(SubscriptionPackage subscriptionPackage) => await _context.SaveChangesAsync();
        public async Task<int> DeleteSubscriptionPackage(Guid subscriptionPackageId)
        {
            var subscriptionPackage = await _context.SubscriptionPackages.FindAsync(subscriptionPackageId);
            _context.SubscriptionPackages.Remove(subscriptionPackage);
            return await _context.SaveChangesAsync();
        }
    }
}
