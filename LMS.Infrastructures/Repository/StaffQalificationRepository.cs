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
    public class StaffQalificationRepository: IStaffQalificationRepository
    {
        private readonly FunskoolsContext _context;
        public StaffQalificationRepository(FunskoolsContext context) => _context = context;
        public async Task<IEnumerable<StaffQalification>> GetStaffQalifications() => await _context.StaffQalifications.ToListAsync();
        public async Task<StaffQalification> GetStaffQalificationById(Guid id) => await _context.StaffQalifications.FindAsync(id);
        public async Task<int> InsertStaffQalification(StaffQalification staffQalification)
        {
            _context.StaffQalifications.Add(staffQalification);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateStaffQalification(StaffQalification staffQalification) => await _context.SaveChangesAsync();
        public async Task<int> DeleteStaffQalification(Guid id)
        {
            var staffQalification = await _context.StaffQalifications.FindAsync(id);
            _context.StaffQalifications.Remove(staffQalification);
            return await _context.SaveChangesAsync();
        }
    }
}
