using LMS.Mapper.BusinessObject;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using static LMS.Administration.Pages.Account.LoginModel;

namespace LMS.Administration.Pages.Staff
{
    public class StaffTypeModel : PageModel
    {
        //private readonly ILogger<StaffTypeModel> _logger;
        //private readonly IStaffTypeService _staffTypeService;

        //public StaffTypeModel(ILogger<StaffTypeModel> logger,
        //    IStaffTypeService staffTypeService)
        //{
        //    _logger = logger;
        //    _staffTypeService = staffTypeService;
        //}
        public List<StaffTypeCls> _lstStaffType { get; set; }

        public async Task OnGet()
        {
            
        }
    }
    public class StaffTypeCls
    {
        public string Id { get; set; }
        public string StaffTypeName { get; set; }
    }
}
