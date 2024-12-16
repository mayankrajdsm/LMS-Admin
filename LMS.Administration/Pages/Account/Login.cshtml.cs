using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.Security.Claims;

namespace LMS.Administration.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(ILogger<LoginModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public LoginInputModel Input { get; set; }

        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {
                if (Input.Email == "admin@test.com" && Input.Password == "12345")
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, Input.Email),
                        new Claim("Id", "12345"),
                        new Claim(ClaimTypes.Role, "Admin")
                    };

                    // Create claims identity
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    // Sign in the user
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity));

                    return LocalRedirect(returnUrl);
                }
                else
                {
                    // return Unauthorized();
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }
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
