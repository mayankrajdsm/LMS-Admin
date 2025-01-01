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
    public class StaffExperienceRepository: IStaffExperienceRepository
    {
        private readonly FunskoolsContext _context;
        public StaffExperienceRepository(FunskoolsContext context) => _context = context;
        public async Task<IEnumerable<StaffExperience>> GetStaffExperiences() => await _context.StaffExperiences.ToListAsync();
        public async Task<StaffExperience> GetStaffExperienceById(Guid id) => await _context.StaffExperiences.FindAsync(id);
        public async Task<int> InsertStaffExperience(StaffExperience staffExperience)
        {
            _context.StaffExperiences.Add(staffExperience);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateStaffExperience(StaffExperience staffExperience) => await _context.SaveChangesAsync();
        public async Task<int> DeleteStaffExperience(Guid id)
        {
            var staffExperience = await _context.StaffExperiences.FindAsync(id);
            _context.StaffExperiences.Remove(staffExperience);
            return await _context.SaveChangesAsync();
        }
    }
}
