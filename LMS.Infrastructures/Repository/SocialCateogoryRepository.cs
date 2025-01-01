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
    public class SocialCateogoryRepository: ISocialCateogoryRepository
    {
        private readonly FunskoolsContext _context;
        public SocialCateogoryRepository(FunskoolsContext context) => _context = context;
        public async Task<IEnumerable<SocialCategory>> GetSocialCateogories() => await _context.SocialCategories.ToListAsync();
        public async Task<SocialCategory> GetSocialCateogoryById(Guid socialCateogoryId) => await _context.SocialCategories.FindAsync(socialCateogoryId);
        public async Task<int> InsertSocialCateogory(SocialCategory socialCateogory)
        {
            _context.SocialCategories.Add(socialCateogory);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateSocialCateogory(SocialCategory socialCateogory) => await _context.SaveChangesAsync();
        public async Task<int> DeleteSocialCateogory(Guid socialCateogoryId)
        {
            var socialCateogory = await _context.SocialCategories.FindAsync(socialCateogoryId);
            _context.SocialCategories.Remove(socialCateogory);
            return await _context.SaveChangesAsync();
        }
    }
}
