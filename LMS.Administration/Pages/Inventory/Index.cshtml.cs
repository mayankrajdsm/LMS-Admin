//using LMS.Admin.Models;
using LMS.Mapper.RequestObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LMS.Infrastructures.Models;

namespace LMS.Admin.Views.Inventory
{
    public class IndexModel : PageModel
    {
        [BindProperty] // Automatically binds form inputs to this property
        public UserInputModel UserInput { get; set; }

        public string Message { get; set; } = string.Empty;
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Message = "Validation failed!";
                return Page();
            }

            // Process the data (e.g., save to database)
            Message = $"Data Received: {UserInput.Name}, {UserInput.Email}";
            return Page(); // Reload the page or redirect if necessary
        }
    }
    
}
