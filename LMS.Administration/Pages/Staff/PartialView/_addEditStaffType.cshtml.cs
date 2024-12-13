using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.Security.Claims;
using LMS.Mapper.IService;
using LMS.Administration.Middleware;

namespace LMS.Administration.Pages.Staff.PartialView
{
    public class _addEditStaffTypeModel : PageModel
    {
        private readonly ILogger<_addEditStaffTypeModel> _logger;
        private readonly IStaffTypeService _staffTypeService;
        private readonly IActiveUserService _activeUserService;
        public _addEditStaffTypeModel(ILogger<_addEditStaffTypeModel> logger,
            IStaffTypeService staffTypeService,
            IActiveUserService activeUserService)
        {
            _logger = logger;
            _staffTypeService = staffTypeService;
            _activeUserService = activeUserService;
        }
        [BindProperty]
        public LoginInputModel Input { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/Staff/StaffType");

            if (ModelState.IsValid)
            {
                var result = await _staffTypeService.InsertStaffType(Input.StaffTypeName, _activeUserService.UserId);
                if (result > 0)
                {
                    return LocalRedirect(returnUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }
            }
            else
            {
                // return Unauthorized();
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }
            return Page();
        }
        public class LoginInputModel
        {
            [DisplayName("Staff Type")]
            public string StaffTypeName { get; set; }
        }
    }
}
