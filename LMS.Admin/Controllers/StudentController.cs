using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            IEnumerable<Student> result = _studentService.GetAllStudent().Result;
            return View(result);
        }
        public IActionResult StudentContact()
        {
            IEnumerable<StudentContact> contacts = _studentService.GetAllStudentContact().Result;
          
            return View(contacts);
        }
        public IActionResult InsertStudentContact(StudentContact studentContact) 
        {
            studentContact.StudentContactId = Guid.NewGuid();
            studentContact.StudentId = new Guid("9454C4CB-1F43-42E3-B439-04C879701AA5");
            int result=_studentService.InsertStudentContact(studentContact).Result;
            if (result > 0) 
            {
                return RedirectToAction("StudentContact");
            }
            return View(studentContact);
        }

        public IActionResult StudentEducation()
        {
             IEnumerable<StudentEducation> education = _studentService.GetAllStudentEducation().Result;
           
            return View(education);
        }
        public IActionResult InsertStudentEducation(StudentEducation studentEducation)
        {
            studentEducation.EducationId = Guid.NewGuid();
            studentEducation.StudentId = new Guid("9454C4CB-1F43-42E3-B439-04C879701AA5");
            int result=_studentService.InsertStudentEducation(studentEducation).Result;
            if (result > 0) 
            {
                return RedirectToAction("StudentEducation");
            }
            return View(studentEducation);
        }
        public IActionResult StudentGuardian()
        {
            IEnumerable<StudentGuardian> guardian =_studentService.GetAllStudentGuardian().Result;

            return View(guardian);
        }
        public IActionResult InsertStudentGuardian(StudentGuardian studentGuardian)
        {
            studentGuardian.GuardianId = Guid.NewGuid();
            studentGuardian.StudentId = new Guid("9454C4CB-1F43-42E3-B439-04C879701AA5");
            int result=_studentService.InsertStudentGuardian(studentGuardian).Result;
            if (result > 0) 
            {
                return RedirectToAction("StudentGuardian");
            }
            return View(studentGuardian);
        }
        public IActionResult StudentParents()
        {
             IEnumerable<StudentParent> Parents = _studentService.GetAllStudentParent().Result;

            return View(Parents);
        }
        public IActionResult InsertStudentParents(StudentParent studentContact)
        {
            studentContact.ParentsId = Guid.NewGuid();
            studentContact.StudentId= new Guid("9454C4CB-1F43-42E3-B439-04C879701AA5");
            int result=_studentService.InsertStudentParents(studentContact).Result;
            if (result > 0) 
            {
                return RedirectToAction("StudentParents");
            }
            return View(studentContact);
        }
        public IActionResult StudentTransport()
        {
            IEnumerable<StudentTransport> Transport = _studentService.GetAllStudentTransport().Result;

            return View(Transport);
        }
        public IActionResult InsertStudentTransport(StudentTransport studentTransport)
        {
            studentTransport.TransportId = Guid.NewGuid();
            studentTransport.TransportId = new Guid("9454C4CB-1F43-42E3-B439-04C879701AA5");
            int result=_studentService.InsertStudentTransport(studentTransport).Result;
            if (result > 0) 
            {
                return RedirectToAction("StudentTransport");
            }
            return View(studentTransport);
        }
    }
}
