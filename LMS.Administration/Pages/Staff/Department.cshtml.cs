using LMS.Administration.Middleware;
using LMS.Mapper.IService;
using LMS.Mapper.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Staff
{
    public class DepartmentModel : PageModel
    {
        private readonly ILogger<DepartmentModel> _logger;
        private readonly IDepartmentService _departmentService;
        private readonly IActiveUserService _activeUserService;
        public DepartmentModel(ILogger<DepartmentModel> logger, IDepartmentService departmentService,
            IActiveUserService activeUserService)
        {
            _logger = logger;
            _departmentService = departmentService;
            _activeUserService = activeUserService;
        }
        public List<LMS.Mapper.BusinessObject.Department> departments { get; set; }
        [BindProperty]
        public Department addDepartment { get; set; }
        [BindProperty]
        public Department editDepartment { get; set; }
        public async Task<IActionResult> OnGet()
        {
            departments = await _departmentService.GetDepartments();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                departments = await _departmentService.GetDepartments();
                return Page();
            }

            if (string.IsNullOrEmpty(addDepartment.DepartmentId))
            {
                LMS.Mapper.BusinessObject.Department department = new LMS.Mapper.BusinessObject.Department();
                department.DepartmentName = addDepartment.DepartmentName;
                department.IsActive = true;
                department.CreatedOn = DateTime.Now;
                department.CreatedBy = _activeUserService.UserId;
                int isSave = await _departmentService.InsertDepartment(department);
            }
            else
            {
                var existingDepartment = await _departmentService.GetDepartmentById(addDepartment.DepartmentId);
                if (existingDepartment != null)
                {
                    existingDepartment.DepartmentName = addDepartment.DepartmentName;
                    existingDepartment.ModifiedOn = DateTime.Now;
                    existingDepartment.ModifiedBy = _activeUserService.UserId;
                    int isUpdated = await _departmentService.UpdateDepartment(existingDepartment);
                }
            }

            return Page();
        }
        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            var existingDepartment = await _departmentService.GetDepartmentById(id);
            if (existingDepartment == null)
            {
                return NotFound();
            }

            editDepartment.DepartmentId = editDepartment.DepartmentId;
            editDepartment.DepartmentName = editDepartment.DepartmentName;
            editDepartment.IsActive = editDepartment.IsActive;

            departments = await _departmentService.GetDepartments();
            return Page();
        }
    }
    public class Department
    {
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool IsActive { get; set; }
    }
}
