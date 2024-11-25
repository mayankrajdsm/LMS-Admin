using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class GenerateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
