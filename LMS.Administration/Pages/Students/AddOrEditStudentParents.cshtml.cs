using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Students
{
    public class AddOrEditStudentParentsModel : PageModel
    {
        private readonly IStudentService _studentService;
        public AddOrEditStudentParentsModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [BindProperty(SupportsGet = true)]
        public Guid studentId { get; set; }
        public void OnGet()
        {
        }
        [BindProperty]
        public StudentParent studentParent { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page(); // Return the page with validation errors
            }

            studentParent.StudentId = studentId;
            int result = _studentService.InsertStudentParents(studentParent).Result;

            return RedirectToPage("AddOrEditStudentTransport", new { studentId = studentId }); // Redirect to the same page (or another page if needed)
        }
    }
}
