using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
