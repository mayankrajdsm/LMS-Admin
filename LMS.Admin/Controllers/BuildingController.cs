using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class BuildingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
