using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Students
{
    public class AddOrEditStudentGuardianModel : PageModel
    {
        private readonly IStudentService _studentService;
        public AddOrEditStudentGuardianModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [BindProperty(SupportsGet = true)]
        public Guid studentId { get; set; }
        public void OnGet()
        {
        }
        [BindProperty]
        public StudentGuardian studentGuardian { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page(); // Return the page with validation errors
            }

            studentGuardian.StudentId = studentId;
            int result = _studentService.InsertStudentGuardian(studentGuardian).Result;

            return RedirectToPage("AddOrEditStudentParents", new { studentId = studentId }); // Redirect to the same page (or another page if needed)
        }
    }
}
