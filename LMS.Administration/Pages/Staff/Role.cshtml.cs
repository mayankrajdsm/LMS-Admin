using LMS.Infrastructures.Interface;
using LMS.Mapper.BusinessObject;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LMS.Administration.Pages.Staff
{
    public class RoleModel : PageModel
    {
        private readonly ILogger<RoleModel> _logger;
        private readonly ILoginTypeService _loginTypeService;
        public RoleModel(ILogger<RoleModel> logger, ILoginTypeService loginTypeService)
        {
            _logger = logger;
            _loginTypeService = loginTypeService;
        }
        public List<LoginType> _loginTypes { get; set; }
        [BindProperty]
        public Role NewItem { get; set; }
        [BindProperty]
        public Role EditItem { get; set; }
        public async Task<IActionResult> OnGet()
        {
            _loginTypes = await _loginTypeService.GetLoginTypes();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            //    // Add a new item
            if (!ModelState.IsValid)
            {
                _loginTypes = await _loginTypeService.GetLoginTypes();
                return Page();
            }

            //    if (NewItem.Id == 0)
            //    {
            //        // Create new item
            //        _dbContext.Items.Add(NewItem);
            //    }
            //    else
            //    {
            //        // Edit existing item
            //        var existingItem = await _dbContext.Items.FindAsync(NewItem.Id);
            //        if (existingItem != null)
            //        {
            //            existingItem.Name = NewItem.Name;
            //            existingItem.Description = NewItem.Description;
            //        }
            //    }

            //    await _dbContext.SaveChangesAsync();
            return RedirectToPage();
        }

        //public async Task<IActionResult> OnGetEditAsync(int id)
        //{
        //    // Load the item to edit
        //    var item = await _dbContext.Items.FindAsync(id);
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }

        //    EditItem = item;
        //    Items = await _dbContext.Items.ToListAsync();
        //    return Page();
        //}

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
        public string LoginTypeName { get; set; }
        public string LoginTypeKey { get; set; }
    }
}
