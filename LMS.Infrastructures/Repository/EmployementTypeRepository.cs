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
    public class EmployementTypeRepository : IEmployementTypeRepository
    {
        private readonly FunskoolsContext _context;
        public EmployementTypeRepository(FunskoolsContext context) => _context = context;
        public async Task<IEnumerable<EmployementType>> GetEmployementTypes() => await _context.EmployementTypes.ToListAsync();
        public async Task<EmployementType> GetEmployementTypeById(Guid employementTypeId) => await _context.EmployementTypes.FindAsync(employementTypeId);
        public async Task<int> InsertEmployementType(EmployementType employementType)
        {
            _context.EmployementTypes.Add(employementType);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateEmployementType(EmployementType employementType)
        {
            return await _context.SaveChangesAsync();
        }
        public async Task<int> DeleteEmployementType(Guid employementTypeId)
        {
            var employementType = await _context.EmployementTypes.FindAsync(employementTypeId);
            _context.EmployementTypes.Remove(employementType);
            return await _context.SaveChangesAsync();
        }
    }
}
