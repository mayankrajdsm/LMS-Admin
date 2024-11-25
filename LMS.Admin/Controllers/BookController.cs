using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
