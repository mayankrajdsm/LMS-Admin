using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
