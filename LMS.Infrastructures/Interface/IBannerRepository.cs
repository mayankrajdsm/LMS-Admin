using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IBannerRepository
    {
        Task<IEnumerable<Banner>> GetBanners();
        Task<Banner> GetBannerById(Guid bannerId);
        Task<int> InsertBanner(Banner banner);
        Task<int> DeleteBanner(Guid bannerId);
    }
}
