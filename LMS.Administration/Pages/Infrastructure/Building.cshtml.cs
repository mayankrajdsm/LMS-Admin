using LMS.Mapper.BusinessObject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Infrastructure
{
    public class BuildingModel : PageModel
    {

        public List<BuildingCls> buildings { get; set; }
        public void OnGet()
        {
        }
    }
    public class BuildingCls
    {
        public string Id { get; set; }
    }
}
