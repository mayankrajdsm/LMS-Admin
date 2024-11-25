using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class UploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
