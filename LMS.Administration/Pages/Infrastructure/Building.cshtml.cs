using LMS.Mapper.BusinessObject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Infrastructure
{
    public class BuildingModel : PageModel
    {

        public List<LMS.Mapper.BusinessObject.Building> buildings { get; set; }
        public void OnGet()
        {
        }
    }
}
