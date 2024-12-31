using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LMS.Administration.Pages.Staff
{
    public class EmployeeModel : PageModel
    {
        public async Task<IActionResult> OnGet()
        {
            return Page();
        }
    }
}
