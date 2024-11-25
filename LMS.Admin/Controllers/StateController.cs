using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class StateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
