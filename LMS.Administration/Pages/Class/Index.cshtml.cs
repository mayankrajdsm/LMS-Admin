using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using LMS.Mapper.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entity=LMS.Infrastructures.Models;

namespace LMS.Administration.Pages.Class
{
    public class IndexModel : PageModel
    {
        private readonly IClassService _classService;
        public IndexModel(IClassService classService)
        {
            _classService = classService;
        }
        public IEnumerable<Entity.Class> classes { get; set; }
        public void OnGet()
        {
            classes = _classService.GetAllClass().Result;
        }
        [BindProperty]
        public Entity.Class Postclass { get; set; }
        public IActionResult OnPost()
        {
            Postclass.ClassesId = Guid.NewGuid();
            Postclass.CreatedBy = new Guid("9454C4CB-1F43-42E3-B439-04C879701AA5");
            Postclass.ModifiedBy = new Guid("9454C4CB-1F43-42E3-B439-04C879701AA5");
            if (!ModelState.IsValid)
            {
                return Page(); // Return the page with validation errors
            }
           

            int result = _classService.InsertCalss(Postclass).Result;
            

            return RedirectToPage(); // Redirect to the same page (or another page if needed)
        }
    }
}