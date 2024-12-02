using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToPage("/Book/Index"); ;
        }
    }
}
