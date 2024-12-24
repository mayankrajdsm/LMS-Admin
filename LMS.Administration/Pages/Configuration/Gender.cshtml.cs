using LMS.Administration.Middleware;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
        public Gender newGender { get; set; }
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
                LMS.Mapper.BusinessObject.Gender Gender = new Mapper.BusinessObject.Gender();
                Gender.GenderCode = newGender.GenderCode;
                Gender.GenderName = newGender.GenderName;
                Gender.IsActive = true;
                Gender.CreatedOn = DateTime.Now;
                Gender.CreatedBy = _activeUserService.UserId;
                int isSave = await _genderService.InsertGender(batch);
            }
            else
            {
                var existingGender = await _batchService.GetBatchById(newGender.BatchId);
                if (existingGender != null)
                {
                    existingGender.GenderCode = newBuilding.GenderCode;
                    existingGender.GenderName = newBuilding.GenderName;
                    existingGender.IsActive = newBuilding.IsActive;
                    existingGender.ModifiedOn = DateTime.Now;
                    existingGender.ModifiedBy = _activeUserService.UserId;
                    int isUpdated = await _genderService.UpdateGender(existingBatch);
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            var existingGender = await _genderService.GetGenderById(newGender.BatchId);
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
        public DateTime GenderName { get; set; }
        public string IsActive { get; set; }
    }
}
