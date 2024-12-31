using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LMS.Administration.Pages.Students
{
    public class StudentTransportModel : PageModel
    {
        private readonly IStudentService _studentService;
        public StudentTransportModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IEnumerable<StudentTransport> studentTransports { get; set; }
        public void OnGet()
        {
            studentTransports = _studentService.GetAllStudentTransport().Result;
        }
        [BindProperty]
        public StudentTransport studentTransport { get; set; }
        //public IActionResult OnPost()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page(); // Return the page with validation errors
        //    }
        //    studentTransport.TransportId = Guid.NewGuid();
        //    studentTransport.StudentId = new Guid("9454C4CB-1F43-42E3-B439-04C879701AA5");
        //    int result= _studentService.InsertStudentTransport(studentTransport).Result;

        //    return RedirectToPage(); // Redirect to the same page (or another page if needed)
        //}
        public async Task<IActionResult> OnPostDeleteAsync(Guid TransportId)
        {
            var student = await _studentService.DeleteStudentTransport(TransportId);
            return RedirectToPage();

        }
    }
}
