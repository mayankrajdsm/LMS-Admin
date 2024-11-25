using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
