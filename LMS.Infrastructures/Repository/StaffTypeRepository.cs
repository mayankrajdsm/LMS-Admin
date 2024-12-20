using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Repository
{
    public class StaffTypeRepository : IStaffTypeRepository
    {
        private readonly TestContext _context;
        public StaffTypeRepository(TestContext context) => _context = context;
        public async Task<IEnumerable<StaffType>> GetStaffTypes() => _context.StaffTypes.ToList();
        public async Task<StaffType> GetStaffTypeById(Guid staffType) => await _context.StaffTypes.FindAsync(staffType);
        public async Task<int> InsertStaffType(StaffType staffType)
        {
            _context.StaffTypes.Add(staffType);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateStaffType(StaffType staffType) => await _context.SaveChangesAsync();
    }
}
