using LMS.Administration.Middleware;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.StudentInfo
{
    public class SubjectModel : PageModel
    {
        private readonly ILogger<SubjectModel> _logger;
        private readonly IActiveUserService _activeUserService;
        public SubjectModel(ILogger<SubjectModel> logger, IActiveUserService activeUserService)
        {
            _logger = logger;
            _activeUserService = activeUserService;
        }

        [BindProperty]
        public Subject addSubject { get; set; }
        [BindProperty]
        public Subject editSubject { get; set; }
        public async Task<IActionResult> OnGet()
        {
            return Page();
        }
    }
    public class Subject
    {
        public string SubjectId { get; set; }

    }
}
