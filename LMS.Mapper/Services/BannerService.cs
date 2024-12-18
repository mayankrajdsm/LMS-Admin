using LMS.Infrastructures.Interface;
using LMS.Mapper.BusinessObject;
using LMS.Mapper.ConversionHelper;
using LMS.Mapper.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.Services
{
    public class BannerService: IBannerService
    {
        private readonly IBannerRepository _bannerRepository;
        public BannerService(IBannerRepository bannerRepository)
        {
            _bannerRepository = bannerRepository;
        }
        public async Task<List<Banner>> GetBanners()
        {
            List<Banner> banners = new List<Banner>();
            var existingBanners = await _bannerRepository.GetBanners();
            if (existingBanners != null)
            {
                foreach (var banner in existingBanners)
                {
                    banners.Add(banner.ToBusinessObject());
                }
            }
            return banners;
        }
        public async Task<Banner> GetBannerById(string id)
        {
            var banner = await _bannerRepository.GetBannerById(Guid.Parse(id));
            return banner.ToBusinessObject();
        }
        public async Task<int> InsertBanner(Banner banner)
        {
            return await _bannerRepository.InsertBanner(banner.ToEntityModel());
        }
        public async Task<int> DeleteBanner(string id)
        {
            return await _bannerRepository.DeleteBanner(Guid.Parse(id));
        }
    }
}
