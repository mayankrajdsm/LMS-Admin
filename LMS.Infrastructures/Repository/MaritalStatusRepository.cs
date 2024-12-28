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
    public class MaritalStatusRepository: IMaritalStatusRepository
    {
        private readonly TestContext _context;

        public MaritalStatusRepository(TestContext context) => _context = context;
        public async Task<IEnumerable<MaritalStatus>> GetMaritalStatus() => await _context.MaritalStatuses.ToListAsync();
        public async Task<MaritalStatus> GetMaritalStatusById(Guid maritalStatusId) => await _context.MaritalStatuses.FindAsync(maritalStatusId);
        public async Task<int> InsertMaritalStatus(MaritalStatus maritalStatus)
        {
            _context.MaritalStatuses.Add(maritalStatus);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateMaritalStatus(MaritalStatus maritalStatus) => await _context.SaveChangesAsync();
        public async Task<int> DeleteMaritalStatus(Guid maritalStatusId)
        {
            var maritalStatus = await _context.MaritalStatuses.FindAsync(maritalStatusId);
            _context.MaritalStatuses.Remove(maritalStatus);
            return await _context.SaveChangesAsync();
        }
    }
}
