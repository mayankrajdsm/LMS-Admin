using LMS.Infrastructures.Interface;
using LMS.Mapper.BusinessObject;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Staff
{
    public class RoleModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ILoginTypeService _loginTypeService;
        public RoleModel(ILogger<IndexModel> logger, ILoginTypeService loginTypeService)
        {
            _logger = logger;
            _loginTypeService = loginTypeService;
        }
        public List<LoginType> _loginTypes { get; set; }
        public async Task OnGet()
        {
            _loginTypes = await _loginTypeService.GetLoginTypes();
        }
    }
}
