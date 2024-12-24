using LMS.Administration.Middleware;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
        public EmployementType newEmployementType { get; set; }
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
                int isSave = await _employementTypeService.InsertEmployementType(batch);
            }
            else
            {
                var existingEmployementType = await _batchService.GetBatchById(newEmployementType.BatchId);
                if (existingEmployementType != null)
                {
                    existingEmployementType.EmployementTypeCode = newBuilding.EmployementTypeCode;
                    existingEmployementType.EmployementTypeName = newBuilding.EmployementTypeName;
                    existingEmployementType.IsActive = newBuilding.IsActive;
                    existingEmployementType.ModifiedOn = DateTime.Now;
                    existingEmployementType.ModifiedBy = _activeUserService.UserId;
                    int isUpdated = await _employementTypeService.UpdateEmployementType(existingBatch);
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            var existingEmployementType = await _employementTypeService.GetEmployementTypeById(newEmployementType.BatchId);
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
        public DateTime EmployementTypeName { get; set; }
        public string IsActive { get; set; }
    }
}
