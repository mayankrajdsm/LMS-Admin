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
    public class StaffRepository: IStaffRepository
    {
        private readonly FunskoolsContext _context;
        public StaffRepository(FunskoolsContext context) => _context = context;
        public async Task<IEnumerable<Staff>> GetAllStaff() => await _context.Staff.ToListAsync();
        public async Task<Staff> GetStaffById(Guid id) => await _context.Staff.FindAsync(id);
        public async Task<Staff> GetLoginUser(string email) => await _context.Staff.FirstOrDefaultAsync(m => m.EmailId == email);
        public async Task<int> InsertStaff(Staff staff)
        {
            _context.Staff.Add(staff);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateStaff(Staff staff) => await _context.SaveChangesAsync();
        public async Task<int> DeleteStaff(Guid id)
        {
            var staff = await _context.Staff.FindAsync(id);
            _context.Staff.Remove(staff);
            return await _context.SaveChangesAsync();
        }
    }
}
