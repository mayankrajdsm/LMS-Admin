using LMS.Administration.Middleware;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;

namespace LMS.Administration.Pages.Staff
{
    public class _addEditLoginTypeModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ILoginTypeService _loginTypeService;
        private readonly IActiveUserService _activeUserService;

        public _addEditLoginTypeModel(ILogger<IndexModel> logger,
            ILoginTypeService loginTypeService,
            IActiveUserService activeUserService)
        {
            _logger = logger;
            _loginTypeService = loginTypeService;
            _activeUserService = activeUserService;
        }

        [BindProperty]
        public LoginInputModel Input { get; set; }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/Staff/Role");

            if (ModelState.IsValid)
            {
                var result = await _loginTypeService.InsertLoginType(Input.RoleName, Input.RoleKey, _activeUserService.UserId);
                if (result > 0)
                {
                    return LocalRedirect(returnUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid Inputs.");
                }
            }
            else
            {
                // return Unauthorized();
                ModelState.AddModelError(string.Empty, "Invalid Inputs.");
            }
            return Page();
        }
        public class LoginInputModel
        {
            [DisplayName("Role")]
            public string RoleName { get; set; }
            [DisplayName("Role Key")]
            public string RoleKey { get; set; }
        }
    }
}
