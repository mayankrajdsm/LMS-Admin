using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class DomainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
