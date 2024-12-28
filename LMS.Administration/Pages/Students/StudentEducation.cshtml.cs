using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Students
{
    public class StudentEducationModel : PageModel
    {
        private readonly IStudentService _studentService;
        public StudentEducationModel(IStudentService studentService )
        {
            _studentService = studentService;
        }
        public IEnumerable<StudentEducation> studentEducations { get; set; }
        public void OnGet()
        {
            studentEducations=_studentService.GetAllStudentEducation().Result;
        }
        [BindProperty]
        public StudentEducation StudentEducation { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page(); // Return the page with validation errors
            }
            StudentEducation.EducationId = Guid.NewGuid();
            StudentEducation.StudentId = new Guid("9454C4CB-1F43-42E3-B439-04C879701AA5");// we have to get the student Id from the student 
            int result = _studentService.InsertStudentEducation(StudentEducation).Result;

            return RedirectToPage(); // Redirect to the same page (or another page if needed)
        }
    }
}
