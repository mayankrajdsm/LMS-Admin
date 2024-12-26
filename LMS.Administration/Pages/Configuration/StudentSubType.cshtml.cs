using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LMS.Mapper.IService;
using LMS.Administration.Middleware;

namespace LMS.Administration.Pages.Configuration
{
    public class StudentTypeModel : PageModel
    {
        private readonly ILogger<StudentTypeModel> _logger;
        private readonly IStudentTypeService _studentTypeService;
        private readonly IActiveUserService _activeUserService;
        public StudentTypeModel(ILogger<StudentTypeModel> logger, IStudentTypeService studentTypeService, IActiveUserService activeUserService)
        {
            _logger = logger;
            _studentTypeService = studentTypeService;
            _activeUserService = activeUserService;
        }
        public List<LMS.Mapper.BusinessObject.StudentSubType> studentSubTypes { get; set; }
        [BindProperty]
        public StudentSubType newStudentType { get; set; }
        [BindProperty]
        public StudentSubType editStudentType { get; set; }
        public async Task<IActionResult> OnGet()
        {
            studentSubTypes = await _studentTypeService.GetStudentSubTypes();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                studentSubTypes = await _studentTypeService.GetStudentSubTypes();
                return Page();
            }

            if (string.IsNullOrEmpty(newStudentType.StudentSubTypeId))
            {
                LMS.Mapper.BusinessObject.StudentSubType studentSubType = new Mapper.BusinessObject.StudentSubType();
                studentSubType.StudentSubTypeName = newStudentType.StudentSubTypeName;
                studentSubType.DiscountPer = newStudentType.DiscountPer;
                studentSubType.IsActive = true;
                studentSubType.CreatedOn = DateTime.Now;
                studentSubType.CreatedBy = _activeUserService.UserId;
                int isSave = await _studentTypeService.InsertStudentSubType(socialCateogory);
            }
            else
            {
                var existingModel = await _studentTypeService.GetStudentSubTypeById(newStudentType.StudentSubTypeId);
                if (existingModel != null)
                {
                    existingModel.StudentSubTypeName = newStudentType.StudentSubTypeName;
                    existingModel.DiscountPer = newStudentType.DiscountPer;
                    existingModel.IsActive = newStudentType.IsActive;
                    existingModel.ModifiedOn = DateTime.Now;
                    existingModel.ModifiedBy = _activeUserService.UserId;
                    int isUpdated = await _studentTypeService.UpdateStudentSubType(existingModel);
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            var existingModel = await _studentTypeService.GetStudentSubTypeById(id);
            if (existingModel == null)
            {
                return NotFound();
            }

            editStudentType.SocialCateogoryName = existingModel.SocialCateogoryName;
            editStudentType.DiscountPer = existingModel.DiscountPer;
            editStudentType.IsActive = existingModel.IsActive;

            studentSubTypes = await _studentTypeService.GetStudentSubTypes();
            return Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            int isDeleted = await _studentTypeService.DeleteStudentSubType(id);

            studentSubTypes = await _studentTypeService.GetStudentSubTypes();

            return Page();
        }
    }
    public class StudentSubType
    {
        public string StudentSubTypeId { get; set; }
        [Required]
        [DisplayName("Name")]
        public string StudentSubTypeName { get; set; } = null!;
        [Required]
        [DisplayName("Discount")]
        public int DiscountPer { get; set; } = 0!;
        [DisplayName("Status")]
        public bool IsActive { get; set; }
    }
}
