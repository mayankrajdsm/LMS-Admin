using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using entities=LMS.Infrastructures.Models;

namespace LMS.Administration.Pages.Students
{
    public class IndexModel : PageModel
    {
        public readonly IStudentService _studentService;

        public IndexModel(IStudentService studentService)
        {
            
            _studentService = studentService;
        }
        public IEnumerable<entities.Student> students { get; set; }
        public void OnGet()
        {
            var result=_studentService.GetAllStudent().Result;
            students = result;
        }
        [BindProperty]
        public entities.Student student { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page(); // Return the page with validation errors
            }
            student.StudentId = Guid.NewGuid();
           
            int result = _studentService.InsertStudent(student).Result;

            return RedirectToPage("AddOrEditContact",new {studentid = student.StudentId }); // Redirect to the same page (or another page if needed)
        }
        public async Task<IActionResult> OnPostDeleteAsync(Guid StudentId)
        {
            var student = await _studentService.DeleteStudent(StudentId);
            return RedirectToPage();
           
        }
    }
}
