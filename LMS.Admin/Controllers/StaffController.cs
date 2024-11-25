using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
