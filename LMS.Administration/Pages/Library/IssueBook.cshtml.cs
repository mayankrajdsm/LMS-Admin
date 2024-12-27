using LMS.Administration.Middleware;
using LMS.Mapper.IService;
using LMS.Mapper.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LMS.Administration.Pages.Library
{
    public class IssueBookModel : PageModel
    {
        private readonly ILogger<IssueBookModel> _logger;
        private readonly IIssueBookStudentService _studentService;
        private readonly IActiveUserService _activeUserService;
        public IssueBookModel(ILogger<IssueBookModel> logger, IIssueBookStudentService studentService, IActiveUserService activeUserService)
        {
            _logger = logger;
            _studentService = studentService;
            _activeUserService = activeUserService;
        }
        public List<LMS.Mapper.BusinessObject.IssueBookStudent> issueBookStudents { get; set; }
        [BindProperty]
        public IssueBookStudent newIssueBookStudent { get; set; }
        [BindProperty]
        public IssueBookStudent editIssueBookStudent { get; set; }
        public async Task<IActionResult> OnGet()
        {
            issueBookStudents = await _studentService.GetIssueBookStudents();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                issueBookStudents = await _studentService.GetIssueBookStudents();
                return Page();
            }

            if (string.IsNullOrEmpty(newIssueBookStudent.IssueBookStudentId))
            {
                LMS.Mapper.BusinessObject.IssueBookStudent model = new Mapper.BusinessObject.IssueBookStudent();
                model.StudentId = newIssueBookStudent.StudentId;
                model.BookId = newIssueBookStudent.BookId;
                model.FromDate = newIssueBookStudent.FromDate;
                model.ToDate = newIssueBookStudent.ToDate;
                model.IsActive = newIssueBookStudent.IsActive;
                model.CreatedOn = DateTime.Now;
                model.CreatedBy = _activeUserService.UserId;
                int isSave = await _studentService.InsertIssueBookStudent(model);
            }
            else
            {
                var existingModel = await _studentService.GetIssueBookStudentByBookIdStudentId(newIssueBookStudent.IssueBookStudentId);
                if (existingModel != null)
                {
                    existingModel.StudentId = newIssueBookStudent.StudentId;
                    existingModel.BookId = newIssueBookStudent.BookId;
                    existingModel.FromDate = newIssueBookStudent.FromDate;
                    existingModel.ToDate = newIssueBookStudent.ToDate;
                    existingModel.IsActive = newIssueBookStudent.IsActive;
                    existingModel.ModifiedOn = DateTime.Now;
                    existingModel.ModifiedBy = _activeUserService.UserId;
                    int isUpdated = await _studentService.UpdateIssueBookStudent(existingModel);
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            var existingModel = await _studentService.GetIssueBookStudentByBookIdStudentId(id);
            if (existingModel == null)
            {
                return NotFound();
            }

            editIssueBookStudent.StudentId = existingModel.StudentId;
            editIssueBookStudent.BookId = existingModel.BookId;
            editIssueBookStudent.FromDate = existingModel.FromDate;
            editIssueBookStudent.ToDate = existingModel.ToDate;
            editIssueBookStudent.IsActive = existingModel.IsActive;

            issueBookStudents = await _studentService.GetIssueBookStudents();
            return Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            int isDeleted = await _studentService.DeleteIssueBookStudent(id);

            issueBookStudents = await _studentService.GetIssueBookStudents();
            return Page();
        }
    }
    public class IssueBookStudent
    {
        public string IssueBookStudentId { get; set; }

        [Required(ErrorMessage = "Student Required.")]
        [DisplayName("Student")]
        public string StudentId { get; set; }
        public List<SelectListItem> lstStudents { get; set; }

        [Required(ErrorMessage = "Book Required.")]
        [DisplayName("Book")]
        public string BookId { get; set; }
        public List<SelectListItem> lstBooks { get; set; }

        [Required(ErrorMessage = "From Date Time Required.")]
        [DisplayName("From Date Time")]
        public DateTime FromDate { get; set; }

        [Required(ErrorMessage = "To Date Time Required.")]
        [DisplayName("To Date Time")]
        public DateTime ToDate { get; set; }

        [Required(ErrorMessage = "Status Required.")]
        [DisplayName("Status")]
        public bool IsActive { get; set; }
    }
}
