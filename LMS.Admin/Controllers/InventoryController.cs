using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
