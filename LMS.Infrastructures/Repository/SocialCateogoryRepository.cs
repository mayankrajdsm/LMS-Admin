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
        private readonly TestContext _context;
        public SocialCateogoryRepository(TestContext context) => _context = context;
        public async Task<IEnumerable<SocialCateogory>> GetSocialCateogories() => await _context.SocialCateogories.ToListAsync();
        public async Task<SocialCateogory> GetSocialCateogoryById(Guid socialCateogoryId) => await _context.SocialCateogories.FindAsync(socialCateogoryId);
        public async Task<int> InsertSocialCateogory(SocialCateogory socialCateogory)
        {
            _context.SocialCateogories.Add(socialCateogory);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateSocialCateogory(SocialCateogory socialCateogory) => await _context.SaveChangesAsync();
        public async Task<int> DeleteSocialCateogory(Guid socialCateogoryId)
        {
            var socialCateogory = await _context.SocialCateogories.FindAsync(socialCateogoryId);
            _context.SocialCateogories.Remove(socialCateogory);
            return await _context.SaveChangesAsync();
        }
    }
}
