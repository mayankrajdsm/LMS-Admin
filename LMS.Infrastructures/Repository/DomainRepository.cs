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
    public class DomainRepository : IDomainRepository
    {
        private readonly TestContext _lMSDbContext;
        public DomainRepository(TestContext lMSDbContext)
        {
            _lMSDbContext = lMSDbContext;
        }
        public async Task<IEnumerable<Domain>> GetDomains()
        {
            return _lMSDbContext.Domains.ToList();
        }
        public async Task<Domain> GetDomainsById(Guid domainId)
        {
            return await _lMSDbContext.Domains.FindAsync(domainId);
        }
        public async Task<int> InsertDomain(Domain domain)
        {
            _lMSDbContext.Domains.Add(domain);
            return await _lMSDbContext.SaveChangesAsync();
        }
        public async Task<int> UpdateDomain(Domain domain)
        {
            return await _lMSDbContext.SaveChangesAsync();
        }
        public async Task<int> DeleteDomain(Guid domainId)
        {
            var existingDomain = await _lMSDbContext.Domains.FindAsync(domainId);
            _lMSDbContext.Domains.Remove(existingDomain);
            return await _lMSDbContext.SaveChangesAsync();
        }
    }
}
