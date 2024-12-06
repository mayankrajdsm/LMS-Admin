using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassService _classService;
        public ClassController(IClassService classService)
        {
            _classService = classService;
        }
        public IActionResult Index()
        {
            IEnumerable<Class> result= _classService.GetAllClass().Result;
            return View(result);
        }
    }
}
