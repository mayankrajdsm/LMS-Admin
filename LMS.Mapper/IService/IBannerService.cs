using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IBannerService
    {
        Task<List<Banner>> GetBanners();
        Task<Banner> GetBannerById(string id);
        Task<int> InsertBanner(Banner banner);
        Task<int> DeleteBanner(string id);
    }
}
