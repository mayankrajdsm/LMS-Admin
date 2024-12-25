using LMS.Administration.Middleware;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LMS.Administration.Pages.Configuration
{
    public class GenderModel : PageModel
    {
        private readonly ILogger<GenderModel> _logger;
        private readonly IGenderService _genderService;
        private readonly IActiveUserService _activeUserService;
        public GenderModel(IGenderService genderService, ILogger<GenderModel> logger, IActiveUserService activeUserService)
        {
            _genderService = genderService;
            _logger = logger;
            _activeUserService = activeUserService;
        }
        public List<LMS.Mapper.BusinessObject.Gender> genders { get; set; }
        [BindProperty]
        public Gender newGender { get; set; }
        [BindProperty]
        public Gender editGender { get; set; }
        public async Task<IActionResult> OnGet()
        {
            genders = await _genderService.GetGenders();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                genders = await _genderService.GetGenders();
                return Page();
            }

            if (string.IsNullOrEmpty(newGender.GenderId))
            {
                LMS.Mapper.BusinessObject.Gender gender = new Mapper.BusinessObject.Gender();
                gender.GenderCode = newGender.GenderCode;
                gender.GenderName = newGender.GenderName;
                gender.IsActive = true;
                gender.CreatedOn = DateTime.Now;
                gender.CreatedBy = _activeUserService.UserId;
                int isSave = await _genderService.InsertGender(gender);
            }
            else
            {
                var existingGender = await _genderService.GetGenderById(newGender.GenderId);
                if (existingGender != null)
                {
                    existingGender.GenderCode = newGender.GenderCode;
                    existingGender.GenderName = newGender.GenderName;
                    existingGender.IsActive = newGender.IsActive;
                    existingGender.ModifiedOn = DateTime.Now;
                    existingGender.ModifiedBy = _activeUserService.UserId;
                    int isUpdated = await _genderService.UpdateGender(existingGender);
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            var existingGender = await _genderService.GetGenderById(newGender.GenderId);
            if (existingGender == null)
            {
                return NotFound();
            }

            editGender.GenderCode = existingGender.GenderCode;
            editGender.GenderName = existingGender.GenderName;
            editGender.IsActive = existingGender.IsActive;

            genders = await _genderService.GetGenders();
            return Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            int isDeleted = await _genderService.DeleteGender(id);
            return Page();
        }
    }
    public class Gender
    {
        public string GenderId { get; set; }
        [Required]
        [DisplayName("Gender Code")]
        public string GenderCode { get; set; } = null!;
        [Required]
        [DisplayName("Gender Name")]
        public string GenderName { get; set; }
        public bool IsActive { get; set; }
    }
}
