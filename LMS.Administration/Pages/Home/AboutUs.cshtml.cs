using LMS.Administration.Middleware;
using LMS.Administration.Pages.Infrastructure;
using LMS.Mapper.IService;
using LMS.Mapper.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LMS.Admin.Views.Home
{
    public class AboutUsModel : PageModel
    {
        private readonly ILogger<AboutUsModel> _logger;
        private readonly IAboutUsService _aboutUsService;
        private readonly IActiveUserService _activeUserService;
        public AboutUsModel(ILogger<AboutUsModel> logger,
            IAboutUsService aboutUsService,
            IActiveUserService activeUserService)
        {
            _logger = logger;
            _aboutUsService = aboutUsService;
            _activeUserService = activeUserService;
        }
        [BindProperty]
        public AboutUs aboutUs { get; set; }
        public async Task<IActionResult> OnGet()
        {
            var existingAbout = _aboutUsService.GetBuildings().Result.FirstOrDefault();
            aboutUs.id = existingAbout.AboutUsId;
            aboutUs.heading = existingAbout.AboutUsTitle;
            aboutUs.message = existingAbout.AboutUsText;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(aboutUs.id))
                {
                    LMS.Mapper.BusinessObject.AboutU about = new Mapper.BusinessObject.AboutU();
                    about.AboutUsTitle = aboutUs.heading;
                    about.AboutUsText = aboutUs.message;
                    about.CreatedOn = DateTime.Now;
                    about.CreatedBy = _activeUserService.UserId;

                    int isSave = await _aboutUsService.InsertAboutUs(about);
                }
                else
                {
                    var existingAbout = await _aboutUsService.GetAboutUsById(aboutUs.id);
                    if (existingAbout != null)
                    {
                        existingAbout.AboutUsTitle = aboutUs.heading;
                        existingAbout.AboutUsText = aboutUs.message;
                        existingAbout.ModifiedBy = _activeUserService.UserId;
                        existingAbout.ModifiedOn = DateTime.Now;

                        int isSave = await _aboutUsService.UpdateAboutUs(existingAbout);

                        if (isSave > 0)
                        {

                        }
                    }
                }
                return Page();
            }
            return Page();
        }
    }
    public class AboutUs
    {
        public string id { get; set; }

        [Required]
        [DisplayName("Title")]
        public string heading { get; set; }
        [Required]
        [DisplayName("Content")]
        public string message { get; set; }
    }
}
