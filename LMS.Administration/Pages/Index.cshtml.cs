using LMS.Administration.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Admin.Views.Home
{
    [Authorize]
    //[ServiceFilter(typeof(CustomAuthFilter))]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
