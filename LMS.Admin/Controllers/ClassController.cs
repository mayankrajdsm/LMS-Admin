using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
        public IActionResult InsertClass(Class classes) 
        {
            classes.ClassesId=Guid.NewGuid();
            classes.CreatedBy=Guid.NewGuid();
            classes.ModifiedBy=Guid.NewGuid();
            int result=_classService.InsertCalss(classes).Result;
            if (result > 0)
            {
                TempData["inserted"] = true;
                return RedirectToAction("Index");
            }
            return View();


        }
    }
}
