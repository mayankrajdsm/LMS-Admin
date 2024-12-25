using LMS.Administration.Middleware;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LMS.Administration.Pages.Configuration
{
    public class EmployementTypeModel : PageModel
    {
        private readonly ILogger<EmployementTypeModel> _logger;
        private readonly IEmployementTypeService _employementTypeService;
        private readonly IActiveUserService _activeUserService;
        public EmployementTypeModel(IEmployementTypeService employementTypeService, ILogger<EmployementTypeModel> logger, IActiveUserService activeUserService)
        {
            _employementTypeService = employementTypeService;
            _logger = logger;
            _activeUserService = activeUserService;
        }
        public List<LMS.Mapper.BusinessObject.EmployementType> employementTypes { get; set; }
        [BindProperty]
        public EmployementType newEmployementType { get; set; }
        [BindProperty]
        public EmployementType editEmployementType { get; set; }
        public async Task<IActionResult> OnGet()
        {
            employementTypes = await _employementTypeService.GetEmployementTypes();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                employementTypes = await _employementTypeService.GetEmployementTypes();
                return Page();
            }

            if (string.IsNullOrEmpty(newEmployementType.EmployementTypeId))
            {
                LMS.Mapper.BusinessObject.EmployementType employementType = new Mapper.BusinessObject.EmployementType();
                employementType.EmployementTypeCode = newEmployementType.EmployementTypeCode;
                employementType.EmployementTypeName = newEmployementType.EmployementTypeName;
                employementType.IsActive = true;
                employementType.CreatedOn = DateTime.Now;
                employementType.CreatedBy = _activeUserService.UserId;
                int isSave = await _employementTypeService.InsertEmployementType(employementType);
            }
            else
            {
                var existingEmployementType = await _employementTypeService.GetEmployementTypeById(newEmployementType.EmployementTypeId);
                if (existingEmployementType != null)
                {
                    existingEmployementType.EmployementTypeCode = newEmployementType.EmployementTypeCode;
                    existingEmployementType.EmployementTypeName = newEmployementType.EmployementTypeName;
                    existingEmployementType.IsActive = newEmployementType.IsActive;
                    existingEmployementType.ModifiedOn = DateTime.Now;
                    existingEmployementType.ModifiedBy = _activeUserService.UserId;
                    int isUpdated = await _employementTypeService.UpdateEmployementType(existingEmployementType);
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            var existingEmployementType = await _employementTypeService.GetEmployementTypeById(newEmployementType.EmployementTypeId);
            if (existingEmployementType == null)
            {
                return NotFound();
            }

            editEmployementType.EmployementTypeCode = existingEmployementType.EmployementTypeCode;
            editEmployementType.EmployementTypeName = existingEmployementType.EmployementTypeName;
            editEmployementType.IsActive = existingEmployementType.IsActive;

            employementTypes = await _employementTypeService.GetEmployementTypes();
            return Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            int isDeleted = await _employementTypeService.DeleteEmployementType(id);

            employementTypes = await _employementTypeService.GetEmployementTypes();
            return Page();
        }
    }
    public class EmployementType
    {
        public string EmployementTypeId { get; set; }
        [Required]
        [DisplayName("Employement Type Code")]
        public string EmployementTypeCode { get; set; } = null!;
        [Required]
        [DisplayName("Employement Type Name")]
        public string EmployementTypeName { get; set; }
        public bool IsActive { get; set; }
    }
}
