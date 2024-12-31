using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Students
{
    public class StudentGuardianModel : PageModel
    {
        private readonly IStudentService _studentService;
        public StudentGuardianModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IEnumerable<StudentGuardian> studentGuardians { get; set; }
        public void OnGet()
        {
            studentGuardians=_studentService.GetAllStudentGuardian().Result;
        }
        [BindProperty]
        public StudentGuardian studentGuardian { get; set; }
        //public IActionResult OnPost()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page(); // Return the page with validation errors
        //    }
        //    studentGuardian.GuardianId = Guid.NewGuid();
        //    studentGuardian.StudentId = new Guid("9454C4CB-1F43-42E3-B439-04C879701AA5");
        //    int result = _studentService.InsertStudentGuardian(studentGuardian).Result;

        //    return RedirectToPage(); // Redirect to the same page (or another page if needed)
        //}
        public async Task<IActionResult> OnPostDeleteAsync(Guid GuardianId)
        {
            var student = await _studentService.DeleteStudentGuardian(GuardianId);
            return RedirectToPage();

        }
    }
}
