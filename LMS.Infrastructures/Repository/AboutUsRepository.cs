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
    public class AboutUsRepository: IAboutUsRepository
    {
        private readonly FunskoolsContext _context;
        public AboutUsRepository(FunskoolsContext context) => _context = context;
        public async Task<IEnumerable<AboutU>> GetAboutUs() => await _context.Aboutus.ToListAsync();
        public async Task<AboutU> GetAboutUsById(Guid aboutId) => await _context.Aboutus.FindAsync(aboutId);
        public async Task<int> InsertAboutUs(AboutU aboutUs)
        {
            _context.Aboutus.Add(aboutUs);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateAboutUs(AboutU aboutUs) => await _context.SaveChangesAsync();
    }
}
