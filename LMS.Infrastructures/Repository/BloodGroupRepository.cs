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
    public class BloodGroupRepository: IBloodGroupRepository
    {
        private readonly FunskoolsContext _context;
        public BloodGroupRepository(FunskoolsContext context) => _context = context;
        public async Task<IEnumerable<BloodGroup>> GetBloodGroups() => await _context.BloodGroups.ToListAsync();
        public async Task<BloodGroup> GetBloodGroupById(Guid id) => await _context.BloodGroups.FindAsync(id);
        public async Task<int> InsertBloodGroup(BloodGroup bloodGroup)
        {
            _context.BloodGroups.Add(bloodGroup);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateBloodGroup(BloodGroup bloodGroup)
        {
            return await _context.SaveChangesAsync();
        }
        public async Task<int> DeleteBloodGroup(Guid bloodGroupId)
        {
            var bloodGroup = await _context.BloodGroups.FindAsync(bloodGroupId);
            _context.BloodGroups.Remove(bloodGroup);
            return await _context.SaveChangesAsync();
        }
    }
    }