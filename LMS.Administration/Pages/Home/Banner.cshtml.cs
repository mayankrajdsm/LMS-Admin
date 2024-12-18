using LMS.Administration.Middleware;
using LMS.Administration.Pages.Staff;
using LMS.Mapper.IService;
using LMS.Mapper.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Admin.Views.Home
{
    public class BannerModel : PageModel
    {
        private readonly ILogger<BannerModel> _logger;
        private readonly IBannerService _bannerService;
        private readonly IActiveUserService _activeUserService;
        public BannerModel(ILogger<BannerModel> logger, IBannerService bannerService, IActiveUserService activeUserService)
        {
            _logger = logger;
            _bannerService = bannerService;
            _activeUserService = activeUserService;
        }
        public List<LMS.Mapper.BusinessObject.Banner> lstBanner { get; set; }
        [BindProperty]
        public Banner addBanner { get; set; }
        public async Task<IActionResult> OnGet()
        {
            lstBanner = await _bannerService.GetBanners();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                lstBanner = await _bannerService.GetBanners();
                return Page();
            }

            if (string.IsNullOrEmpty(addBanner.Id))
            {
                LMS.Mapper.BusinessObject.Banner banner = new LMS.Mapper.BusinessObject.Banner();
                banner.BannerName = addBanner.Name;
                banner.IsActive = true;
                banner.CreatedOn = DateTime.Now;
                banner.CreatedBy = _activeUserService.UserId;
                int isSave = await _bannerService.InsertBanner(banner);

                if (isSave > 0)
                {

                }
            }

            return Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            int isDeleted = await _bannerService.DeleteBanner(id);
            return Page();
        }
    }
    public class Banner
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
