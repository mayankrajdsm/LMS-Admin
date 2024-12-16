using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Infrastructure
{
    public class InventoryModel : PageModel
    {
        public List<InventoryCls> inventoryCls { get; set; }
        public void OnGet()
        {
        }
    }
    public class InventoryCls
    {
        public string Id { get; set; }
    }
}
