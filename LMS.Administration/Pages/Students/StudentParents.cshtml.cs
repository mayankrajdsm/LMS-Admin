using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Students
{
    public class StudentParentsModel : PageModel
    {
        private readonly IStudentService _studentService;
        public StudentParentsModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IEnumerable<StudentParent> StudentParents { get; set; }
        public void OnGet()
        {
            StudentParents = _studentService.GetAllStudentParent().Result;

        }
        [BindProperty]
        public StudentParent StudentParent { get; set; }
        //public IActionResult OnPost()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page(); // Return the page with validation errors
        //    }
        //    StudentParent.ParentsId = Guid.NewGuid();
        //    StudentParent.StudentId = new Guid("9454C4CB-1F43-42E3-B439-04C879701AA5");
        //    int result = _studentService.InsertStudentParents(StudentParent).Result;

        //    return RedirectToPage(); // Redirect to the same page (or another page if needed)
        //}
        public async Task<IActionResult> OnPostDeleteAsync(Guid ParentsId)
        {
            var student = await _studentService.DeleteStudentParents(ParentsId);
            return RedirectToPage();

        }
    }
}
