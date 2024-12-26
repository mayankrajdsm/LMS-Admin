using LMS.Administration.Middleware;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LMS.Administration.Pages.Configuration
{
    public class StudentCategoryModel : PageModel
    {
        private readonly ILogger<StudentCategoryModel> _logger;
        private readonly IStudentCateogoryService _studentCateogoryService;
        private readonly IActiveUserService _activeUserService;
        public StudentCategoryModel(ILogger<StudentCategoryModel> logger, IStudentCateogoryService studentCateogoryService, IActiveUserService activeUserService)
        {
            _logger = logger;
            _studentCateogoryService = studentCateogoryService;
            _activeUserService = activeUserService;
        }
        public List<LMS.Mapper.BusinessObject.StudentCateogory> studentCategories { get; set; }
        [BindProperty]
        public StudentCategory newStudentCategory { get; set; }
        [BindProperty]
        public StudentCategory editStudentCategory { get; set; }
        public async Task<IActionResult> OnGet()
        {
            studentCategories = await _studentCateogoryService.GetSocialCateogories();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                studentCategories = await _studentCateogoryService.GetSocialCateogories();
                return Page();
            }

            if (string.IsNullOrEmpty(newStudentCategory.StudentCategoryId))
            {
                LMS.Mapper.BusinessObject.StudentCateogory model = new Mapper.BusinessObject.StudentCateogory();
                model.StudentCateogoryName = newStudentCategory.StudentCategoryName;
                model.DiscountPer = newStudentCategory.DiscountPer;
                model.IsActive = true;
                model.CreatedOn = DateTime.Now;
                model.CreatedBy = _activeUserService.UserId;
                int isSave = await _studentCateogoryService.InsertStudentCateogory(model);
            }
            else
            {
                var existingModel = await _studentCateogoryService.GetStudentCateogoryById(newStudentCategory.StudentCategoryId);
                if (existingModel != null)
                {
                    existingModel.StudentCateogoryName = newStudentCategory.StudentCategoryName;
                    existingModel.DiscountPer = newStudentCategory.DiscountPer;
                    existingModel.IsActive = newStudentCategory.IsActive;
                    existingModel.ModifiedOn = DateTime.Now;
                    existingModel.ModifiedBy = _activeUserService.UserId;
                    int isUpdated = await _studentCateogoryService.UpdateStudentCateogory(existingModel);
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            var existingModel = await _studentCateogoryService.GetStudentCateogoryById(id);
            if (existingModel == null)
            {
                return NotFound();
            }

            editStudentCategory.StudentCategoryId = existingModel.StudentCateogoryName;
            editStudentCategory.DiscountPer = existingModel.DiscountPer;
            editStudentCategory.IsActive = existingModel.IsActive;

            return Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            int isDeleted = await _studentCateogoryService.DeleteStudentCateogory(id);

            studentCategories = await _studentCateogoryService.GetSocialCateogories();
            return Page();
        }
    }
    public class StudentCategory
    {
        public string StudentCategoryId { get; set; }
        [Required]
        [DisplayName("Name")]
        public string StudentCategoryName { get; set; } = null!;
        [Required]
        [DisplayName("Discount")]
        public int DiscountPer { get; set; } = 0!;
        [DisplayName("Status")]
        public bool IsActive { get; set; }
    }
}
