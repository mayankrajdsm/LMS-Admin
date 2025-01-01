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
    public class BannerRepository: IBannerRepository
    {
        private readonly FunskoolsContext _context;
        public BannerRepository(FunskoolsContext context) => _context = context;
        public async Task<IEnumerable<Banner>> GetBanners() => await _context.Banners.ToListAsync();
        public async Task<Banner> GetBannerById(Guid bannerId) => await _context.Banners.FindAsync(bannerId);
        public async Task<int> InsertBanner(Banner banner)
        {
            _context.Banners.Add(banner);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> DeleteBanner(Guid bannerId)
        {
            var existingBanner = await _context.Banners.FindAsync(bannerId);
            _context.Banners.Remove(existingBanner);
            return await _context.SaveChangesAsync();
        }
    }
}
