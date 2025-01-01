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
    public class StatusRepository:IStatusRepository
    {
        private readonly FunskoolsContext _context;
        public StatusRepository(FunskoolsContext context) => _context = context;
        public async Task<IEnumerable<Status>> GetStatuses() => await _context.Statuses.ToListAsync();
        public async Task<Status> GetStatusById(Guid id) => await _context.Statuses.FindAsync(id);
        public async Task<int> InsertStatus(Status status)
        {
            _context.Statuses.Add(status);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateStatus(Status status) => await _context.SaveChangesAsync();
        public async Task<int> DeleteStatus(Guid id)
        {
            var status = await _context.Statuses.FindAsync(id);
            _context.Statuses.Remove(status);
            return await _context.SaveChangesAsync();
        }
    }
}
