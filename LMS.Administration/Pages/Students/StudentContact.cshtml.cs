using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Students
{
    public class StudentContactModel : PageModel
    {
        private readonly IStudentService _studentService;
        public StudentContactModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IEnumerable<StudentContact> studentContacts {  get; set; }
        public void OnGet()
        {
            studentContacts=_studentService.GetAllStudentContact().Result;

        }
        [BindProperty]
        public StudentContact studentContact { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page(); // Return the page with validation errors
            }
            //studentContact.StudentContactId = Guid.NewGuid();
            studentContact.StudentId = new Guid("9454C4CB-1F43-42E3-B439-04C879701AA5");// we have to get the student Id from the student 
            int result = _studentService.InsertStudentContact(studentContact).Result;

            return RedirectToPage(); // Redirect to the same page (or another page if needed)
        }
        public async Task<IActionResult> OnPostDeleteAsync(Guid StudentContactId)
        {
            var student = await _studentService.DeleteStudentContact(StudentContactId);
            return RedirectToPage();

        }
    }
}
