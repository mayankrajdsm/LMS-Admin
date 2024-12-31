using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Students
{
    public class AddOrEditStudentEducationModel : PageModel
    {
        private readonly IStudentService _studentService;
        public AddOrEditStudentEducationModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [BindProperty(SupportsGet = true)]
        public Guid studentId { get; set; }
        public void OnGet()
        {
        }
        [BindProperty]
        public StudentEducation StudentEducation { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page(); // Return the page with validation errors
            }

            StudentEducation.StudentId = studentId;
            int result = _studentService.InsertStudentEducation(StudentEducation).Result;

            return RedirectToPage("AddOrEditStudentGuardian", new { studentId = studentId }); // Redirect to the same page (or another page if needed)
        }

    }
}
