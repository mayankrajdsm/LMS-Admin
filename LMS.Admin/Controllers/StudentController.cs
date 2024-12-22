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
           // IEnumerable<StudentContact> contacts = new List<StudentContact>();//_studentService.GetAllStudentContact().Result;
            IEnumerable<StudentContact> result = new List<StudentContact>() {  new StudentContact
            {
                StudentContactId = Guid.NewGuid(),
                Address1 = "123 Main St",
                Address2 = "Apt 1A",
                Address3 = null,
                City = "Springfield",
                District = "Central",
                State = "California",
                PinCode = 12345,
                Country = "USA",
                Mobile = 9876543210,
                FatherMobile = 9876501234,
                MotherMobile = 9876512345,
                Email = "student1@example.com",
                AlternateEmail = "student1.alt@example.com",
                StudentId = Guid.NewGuid()
            },
            };
            return View(result);
        }
        public IActionResult InsertStudentContact(StudentContact studentContact) 
        {
            return View(studentContact);
        }

        public IActionResult StudentEducation()
        {
             IEnumerable<StudentEducation> education = _studentService.GetAllStudentEducation().Result;
           
            return View();
        }
        public IActionResult InsertStudentEducation(StudentEducation studentContact)
        {
            return View(studentContact);
        }
        public IActionResult StudentGuardian()
        {
            IEnumerable<StudentGuardian> guardian =_studentService.GetAllStudentGuardian().Result;

            return View();
        }
        public IActionResult InsertStudentGuardian(StudentGuardian studentContact)
        {
            return View(studentContact);
        }
        public IActionResult StudentParents()
        {
             IEnumerable<StudentParent> contacts = _studentService.GetAllStudentParent().Result;

            return View();
        }
        public IActionResult InsertStudentParents(StudentParent studentContact)
        {
            return View(studentContact);
        }
        public IActionResult StudentTransport()
        {
            IEnumerable<StudentTransport> contacts = _studentService.GetAllStudentTransport().Result;

            return View();
        }
        public IActionResult InsertStudentTransport(StudentTransport studentTransport)
        {
            return View(studentTransport);
        }
    }
}
