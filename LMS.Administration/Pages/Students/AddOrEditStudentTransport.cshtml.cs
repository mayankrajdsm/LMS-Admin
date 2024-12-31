using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Students
{
    public class AddOrEditStudentTransportModel : PageModel
    {
        private readonly IStudentService _studentService;
        public AddOrEditStudentTransportModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [BindProperty(SupportsGet = true)]
        public Guid studentId { get; set; }
        public void OnGet()
        {
        }
        [BindProperty]
        public StudentTransport studentTransport { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page(); // Return the page with validation errors
            }

            studentTransport.StudentId = studentId;
            int result = _studentService.InsertStudentTransport(studentTransport).Result;

            return RedirectToPage("index"); // Redirect to the same page (or another page if needed)
        }
    }
}
