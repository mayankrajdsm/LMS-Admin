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
        private readonly TestContext _context;
        public AboutUsRepository(TestContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<AboutU>> GetAboutUs()
        {
            return await _context.AboutUs.ToListAsync();
        }
        public async Task<AboutU> GetAboutUsById(Guid aboutId)
        {
            return await _context.AboutUs.FindAsync(aboutId);
        }
        public async Task<int> InsertAboutUs(AboutU aboutUs)
        {
            _context.AboutUs.Add(aboutUs);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateAboutUs(AboutU aboutUs)
        {
            return await _context.SaveChangesAsync();
        }
    }
}
