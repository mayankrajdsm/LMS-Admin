using LMS.Administration.Middleware;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using LMS.Mapper.Services;

namespace LMS.Administration.Pages.Configuration
{
    public class SocialCategoryModel : PageModel
    {
        private readonly ILogger<SocialCategoryModel> _logger;
        private readonly ISocialCateogoryService _socialCateogoryService;
        private readonly IActiveUserService _activeUserService;
        public SocialCategoryModel(ILogger<SocialCategoryModel> logger, ISocialCateogoryService socialCateogoryService, IActiveUserService activeUserService)
        {
            _logger = logger;
            _socialCateogoryService = socialCateogoryService;
            _activeUserService = activeUserService;
        }
        public List<LMS.Mapper.BusinessObject.SocialCateogory> socialCateogories { get; set; }
        [BindProperty]
        public SocialCateogory newSocialCateogory { get; set; }
        [BindProperty]
        public SocialCateogory editSocialCateogory { get; set; }
        public async Task<IActionResult> OnGet()
        {
            socialCateogories = await _socialCateogoryService.GetSocialCateogories();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                socialCateogories = await _socialCateogoryService.GetSocialCateogories();
                return Page();
            }

            if (string.IsNullOrEmpty(newSocialCateogory.SocialCateogoryId))
            {
                LMS.Mapper.BusinessObject.SocialCateogory socialCateogory = new Mapper.BusinessObject.SocialCateogory();
                socialCateogory.SocialCateogoryCode = newSocialCateogory.SocialCateogoryCode;
                socialCateogory.SocialCateogoryName = newSocialCateogory.SocialCateogoryName;
                socialCateogory.DiscountPer = newSocialCateogory.DiscountPer;
                socialCateogory.IsActive = true;
                socialCateogory.CreatedOn = DateTime.Now;
                socialCateogory.CreatedBy = _activeUserService.UserId;
                int isSave = await _socialCateogoryService.InsertSocialCateogory(socialCateogory);
            }
            else
            {
                var existingSocialCateogory = await _socialCateogoryService.GetSocialCateogoryById(newSocialCateogory.SocialCateogoryId);
                if (existingSocialCateogory != null)
                {
                    existingSocialCateogory.SocialCateogoryCode = newSocialCateogory.SocialCateogoryCode;
                    existingSocialCateogory.SocialCateogoryName = newSocialCateogory.SocialCateogoryName;
                    existingSocialCateogory.DiscountPer = newSocialCateogory.DiscountPer;
                    existingSocialCateogory.IsActive = newSocialCateogory.IsActive;
                    existingSocialCateogory.ModifiedOn = DateTime.Now;
                    existingSocialCateogory.ModifiedBy = _activeUserService.UserId;
                    int isUpdated = await _socialCateogoryService.UpdateSocialCateogory(existingSocialCateogory);
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            var existingSocialCateogory = await _socialCateogoryService.GetSocialCateogoryById(id);
            if (existingSocialCateogory == null)
            {
                return NotFound();
            }

            editSocialCateogory.SocialCateogoryCode = existingSocialCateogory.SocialCateogoryCode;
            editSocialCateogory.SocialCateogoryName = existingSocialCateogory.SocialCateogoryName;
            editSocialCateogory.DiscountPer = existingSocialCateogory.DiscountPer;
            editSocialCateogory.IsActive = existingSocialCateogory.IsActive;

            socialCateogories = await _socialCateogoryService.GetSocialCateogories();
            return Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            int isDeleted = await _socialCateogoryService.DeleteSocialCateogory(id);

            socialCateogories = await _socialCateogoryService.GetSocialCateogories();
            return Page();
        }
    }
    public class SocialCateogory
    {
        public string SocialCateogoryId { get; set; }
        [Required]
        [DisplayName("Code")]
        public string SocialCateogoryCode { get; set; } = null!;
        [Required]
        [DisplayName("Name")]
        public string SocialCateogoryName { get; set; } = null!;
        [Required]
        [DisplayName("Discount")]
        public int DiscountPer { get; set; } = 0!;
        [DisplayName("Status")]
        public bool IsActive { get; set; }
    }
}
