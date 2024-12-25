using LMS.Administration.Middleware;
using LMS.Mapper.IService;
using LMS.Mapper.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LMS.Administration.Pages.Configuration
{
    public class MaritalStatusModel : PageModel
    {
        private readonly ILogger<MaritalStatusModel> _logger;
        private readonly IMaritalStatusService _maritalStatusService;
        private readonly IActiveUserService _activeUserService;
        public MaritalStatusModel(ILogger<MaritalStatusModel> logger, IMaritalStatusService maritalStatusService, IActiveUserService activeUserService)
        {
            _logger = logger;
            _maritalStatusService = maritalStatusService;
            _activeUserService = activeUserService;
        }
        public List<LMS.Mapper.BusinessObject.MaritalStatus> maritalStatuses { get; set; }
        [BindProperty]
        public MaritalStatus newMaritalStatus { get; set; }
        [BindProperty]
        public MaritalStatus editMaritalStatus { get; set; }
        public async Task<IActionResult> OnGet()
        {
            maritalStatuses = await _maritalStatusService.GetMaritalStatusList();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                maritalStatuses = await _maritalStatusService.GetMaritalStatusList();
                return Page();
            }

            if (string.IsNullOrEmpty(newMaritalStatus.MaritalStatusId))
            {
                LMS.Mapper.BusinessObject.MaritalStatus maritalStatus = new Mapper.BusinessObject.MaritalStatus();
                maritalStatus.MaritalStatusCode = newMaritalStatus.MaritalStatusCode;
                maritalStatus.MaritalStatusName = newMaritalStatus.MaritalStatusName;
                maritalStatus.IsActive = true;
                maritalStatus.CreatedOn = DateTime.Now;
                maritalStatus.CreatedBy = _activeUserService.UserId;
                int isSave = await _maritalStatusService.InsertMaritalStatus(maritalStatus);
            }
            else
            {
                var existingMaritalStatus = await _maritalStatusService.GetMaritalStatusById(newMaritalStatus.MaritalStatusId);
                if (existingMaritalStatus != null)
                {
                    existingMaritalStatus.MaritalStatusCode = newMaritalStatus.MaritalStatusCode;
                    existingMaritalStatus.MaritalStatusName = newMaritalStatus.MaritalStatusCode;
                    existingMaritalStatus.IsActive = newMaritalStatus.IsActive;
                    existingMaritalStatus.ModifiedOn = DateTime.Now;
                    existingMaritalStatus.ModifiedBy = _activeUserService.UserId;
                    int isUpdated = await _maritalStatusService.UpdateMaritalStatus(existingMaritalStatus);
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            var existingMaritalStatus = await _maritalStatusService.GetMaritalStatusById(id);
            if (existingMaritalStatus == null)
            {
                return NotFound();
            }

            editMaritalStatus.MaritalStatusCode = existingMaritalStatus.MaritalStatusCode;
            editMaritalStatus.MaritalStatusName = existingMaritalStatus.MaritalStatusName;
            editMaritalStatus.IsActive = existingMaritalStatus.IsActive;

            maritalStatuses = await _maritalStatusService.GetMaritalStatusList();
            return Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            int isDeleted = await _maritalStatusService.DeleteMaritalStatus(id);
            maritalStatuses = await _maritalStatusService.GetMaritalStatusList();
            return Page();
        }
    }
    public class MaritalStatus
    {
        public string MaritalStatusId { get; set; }
        [Required]
        [DisplayName("Code")]
        public string MaritalStatusCode { get; set; } = null!;
        [Required]
        [DisplayName("Name")]
        public string MaritalStatusName { get; set; }
        [DisplayName("Status")]
        public bool IsActive { get; set; }
    }
}
