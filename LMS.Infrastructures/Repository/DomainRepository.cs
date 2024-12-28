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
        private readonly TestContext _context;
        public DomainRepository(TestContext context) => _context = context;
        public async Task<IEnumerable<Domain>> GetDomains() => _context.Domains.ToList();
        public async Task<Domain> GetDomainsById(Guid domainId) => await _context.Domains.FindAsync(domainId);
        public async Task<int> InsertDomain(Domain domain)
        {
            _context.Domains.Add(domain);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateDomain(Domain domain) => await _context.SaveChangesAsync();
        public async Task<int> DeleteDomain(Guid domainId)
        {
            var existingDomain = await _context.Domains.FindAsync(domainId);
            _context.Domains.Remove(existingDomain);
            return await _context.SaveChangesAsync();
        }
    }
}
