using LMS.Administration.Middleware;
using LMS.Infrastructures.Models;
using LMS.Mapper.BusinessObject;
using LMS.Mapper.IService;
using LMS.Mapper.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using static LMS.Administration.Pages.Account.LoginModel;

namespace LMS.Administration.Pages.Staff
{
    public class StaffTypeModel : PageModel
    {
        private readonly ILogger<StaffTypeModel> _logger;
        private readonly IStaffTypeService _staffTypeService;
        private readonly IActiveUserService _activeUserService;
        public StaffTypeModel(ILogger<StaffTypeModel> logger,
            IStaffTypeService staffTypeService,
            IActiveUserService activeUserService)
        {
            _logger = logger;
            _staffTypeService = staffTypeService;
            _activeUserService = activeUserService;
        }
        [BindProperty]
        public List<LMS.Mapper.BusinessObject.StaffType> _lstStaffType { get; set; }

        public Designation newDesignation { get; set; }
        public Designation editDesignation { get; set; }
        public async Task<IActionResult> OnGet()
        {
            _lstStaffType = await _staffTypeService.GetStaffTypes();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                _lstStaffType = await _staffTypeService.GetStaffTypes();
                return Page();
            }

            if (string.IsNullOrEmpty(newDesignation.DesignationId))
            {
                LMS.Mapper.BusinessObject.StaffType staffType = new LMS.Mapper.BusinessObject.StaffType();
                staffType.StaffTypeName = newDesignation.DesignationName;
                staffType.IsActive = true;
                staffType.CreatedOn = DateTime.Now;
                staffType.CreatedBy = _activeUserService.UserId;
                int isSave = await _staffTypeService.InsertStaffType(staffType);
            }
            else
            {
                var existingStaffType = await _staffTypeService.GetStaffTypeById(newDesignation.DesignationId);
                if (existingStaffType != null)
                {
                    existingStaffType.StaffTypeName = newDesignation.DesignationName;
                    existingStaffType.ModifiedOn = DateTime.Now;
                    existingStaffType.ModifiedBy = _activeUserService.UserId;
                    int isUpdated = await _staffTypeService.UpdateStaffType(existingStaffType);
                }
            }

            return Page();
        }
        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            var existingStaffType = await _staffTypeService.GetStaffTypeById(newDesignation.DesignationId);
            if (existingStaffType == null)
            {
                return NotFound();
            }

            editDesignation.DesignationId = existingStaffType.StaffTypeId;
            editDesignation.DesignationName = existingStaffType.StaffTypeName;

            _lstStaffType = await _staffTypeService.GetStaffTypes();
            return Page();
        }
    }
    public class Designation
    {
        public string DesignationId { get; set; }
        public string DesignationName { get; set; }
    }
}
