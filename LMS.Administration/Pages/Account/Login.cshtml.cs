using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.Security.Claims;
using LMS.Administration.Middleware;
using LMS.Mapper.IService;

namespace LMS.Administration.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;
        private readonly IActiveUserService _activeUserService;
        private readonly IStaffService _staffService;
        private readonly Utility.EncryptionDecryption encryptionDecryption = new Utility.EncryptionDecryption();
        public LoginModel(ILogger<LoginModel> logger, IActiveUserService activeUserService, IStaffService staffService)
        {
            _logger = logger;
            _activeUserService = activeUserService;
            _staffService = staffService;
        }

        [BindProperty]
        public LoginInputModel Input { get; set; }

        public string ReturnUrl { get; set; }
        public string ErrorMessage { get; set; }
        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {
                var user = await _staffService.GetLoginUser(Input.Email);

                if (string.IsNullOrEmpty(user.StaffId))
                {
                    ErrorMessage = "Invalid login credentials.";
                    return Page();
                }

                bool isPasswordValid = encryptionDecryption.VerifyPassword(user, Input.Password);

                if (!isPasswordValid)
                {
                    ErrorMessage = "Password not correct.";
                    return Page();
                }
                else if (isPasswordValid)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, string.Concat(user.FirstName,user.MiddleName)),
                        new Claim(ClaimTypes.Surname,user.LastName),
                        new Claim(ClaimTypes.Role, user.RoleId),
                        new Claim(ClaimTypes.Sid, user.StaffId),
                        new Claim(ClaimTypes.Email, user.EmailId),
                    };
                    _activeUserService.SetUserId("12345");
                    // Create claims identity
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    // Sign in the user
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity));

                    return LocalRedirect(returnUrl);
                }
                // if (Input.Email!=null && Input.Password == "12345")
                // {
                //     var claims = new List<Claim>
                //     {
                //         new Claim(ClaimTypes.Name, Input.Email),
                //         new Claim("Id", "12345"),
                //         new Claim(ClaimTypes.Role, "Admin")
                //     };
                //     _activeUserService.SetUserId("12345");
                //     // Create claims identity
                //     var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                //     // Sign in the user
                //     await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                //         new ClaimsPrincipal(claimsIdentity));

                //     return LocalRedirect(returnUrl);
                // }
                // else
                // {
                //     // return Unauthorized();
                //     ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                // }
            }

            return Page();
        }
        public class LoginInputModel
        {
            [DisplayName("Email Id")]
            public string Email { get; set; }
            public string Password { get; set; }
            public bool RememberMe { get; set; }
        }
    }
}
