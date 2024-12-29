using LMS.Administration.Middleware;
using LMS.Infrastructures.Interface;
using LMS.Mapper.BusinessObject;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LMS.Administration.Pages.Staff
{
    public class RoleModel : PageModel
    {
        private readonly ILogger<RoleModel> _logger;
        private readonly ILoginTypeService _loginTypeService;
        private readonly IActiveUserService _activeUserService;
        public RoleModel(ILogger<RoleModel> logger, ILoginTypeService loginTypeService, IActiveUserService activeUserService)
        {
            _logger = logger;
            _loginTypeService = loginTypeService;
            _activeUserService = activeUserService;
        }
        public List<LoginType> _loginTypes { get; set; }
        [BindProperty]
        public Role addRole { get; set; }
        [BindProperty]
        public Role editRole { get; set; }
        public async Task<IActionResult> OnGet()
        {
            _loginTypes = await _loginTypeService.GetLoginTypes();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                _loginTypes = await _loginTypeService.GetLoginTypes();
                return Page();
            }

            if (string.IsNullOrEmpty(addRole.LoginTypeId))
            {
                LMS.Mapper.BusinessObject.LoginType loginType = new LMS.Mapper.BusinessObject.LoginType();
                loginType.LoginTypeName = addRole.LoginTypeName;
                loginType.LoginTypeKey = addRole.LoginTypeKey;
                loginType.IsActive = true;
                loginType.CreatedOn = DateTime.Now;
                loginType.CreatedBy = _activeUserService.UserId;
                int isSave = await _loginTypeService.InsertLoginType(loginType);
            }
            else
            {
                var existingRole = await _loginTypeService.GetLoginTypeById(addRole.LoginTypeId);
                if (existingRole != null)
                {
                    existingRole.LoginTypeName = addRole.LoginTypeName;
                    existingRole.LoginTypeKey = addRole.LoginTypeKey;
                    existingRole.ModifiedOn = DateTime.Now;
                    existingRole.ModifiedBy = _activeUserService.UserId;
                    int isUpdated = await _loginTypeService.UpdateLoginType(existingRole);
                }
            }

            return Page();
        }
        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            var existingRole = await _loginTypeService.GetLoginTypeById(id);
            if (existingRole == null)
            {
                return NotFound();
            }

            editRole.LoginTypeId = existingRole.LoginTypeId;
            editRole.LoginTypeName = existingRole.LoginTypeName;
            editRole.LoginTypeKey = existingRole.LoginTypeKey;
            _loginTypes = await _loginTypeService.GetLoginTypes();
            return Page();
        }

        //public async Task<IActionResult> OnPostDeleteAsync(int id)
        //{
        //    // Delete the selected item
        //    var item = await _dbContext.Items.FindAsync(id);
        //    if (item != null)
        //    {
        //        _dbContext.Items.Remove(item);
        //        await _dbContext.SaveChangesAsync();
        //    }

        //    return RedirectToPage();
        //}
    }
    public class Role
    {
        public string LoginTypeId { get; set; }

        [Required(ErrorMessage = "Role name required.")]
        [DisplayName("Role Name")]
        public string LoginTypeName { get; set; }

        [Required(ErrorMessage = "Role key required.")]
        [DisplayName("Role Key")]
        public string LoginTypeKey { get; set; }

        [Required(ErrorMessage = "menus required.")]
        [DisplayName("Menus")]
        public string[] MenuIds { get; set; }
        public List<SelectListItem> lstMenus { get; set; }
    }
}
