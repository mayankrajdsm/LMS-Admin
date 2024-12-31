using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Students
{
    public class AddOrEditContactModel : PageModel
    {
        private readonly IStudentService _studentService;
        public AddOrEditContactModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [BindProperty(SupportsGet = true)]
        public Guid studentId { get; set; }
        public void OnGet()
        {
        }

        [BindProperty]
        public StudentContact studentContact { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page(); // Return the page with validation errors
            }
          
            studentContact.StudentId = studentId;
            int result = _studentService.InsertStudentContact(studentContact).Result;

            return RedirectToPage("AddOrEditStudentEducation",new { studentId= studentId }); // Redirect to the same page (or another page if needed)
        }
    }
}
