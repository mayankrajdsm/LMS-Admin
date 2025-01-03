using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using LMS.Admin.Views.Home;
using LMS.Administration.Middleware;
using LMS.Administration.Utility;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMS.Administration.Pages.Generate
{
    public class BarcodeModel : PageModel
    {
        private readonly ILogger<BarcodeModel> _logger;
        private readonly IBarcodeService _barcodeService;
        private readonly IActiveUserService _activeUserService;
        public BarcodeModel(ILogger<BarcodeModel> logger,
            IBarcodeService barcodeService,
            IActiveUserService activeUserService)
        {
            _logger = logger;
            _barcodeService = barcodeService;
            _activeUserService = activeUserService;
        }
        [BindProperty]
        public Barcode addBarcode { get; set; }
        public async Task<IActionResult> OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                LMS.Mapper.BusinessObject.Barcode barcode = new Mapper.BusinessObject.Barcode();
                barcode.Code = GenerateBarcode.GetBarcode(addBarcode.Item);
                barcode.CreatedOn = DateTime.Now;
                barcode.CreatedBy = _activeUserService.UserId;

                int isSave = await _barcodeService.InsertBarcode(barcode);
                return Page();
            }
            return Page();
        }
    }
    public class Barcode
    {
        [Required]
        [DisplayName("From")]
        public string From { get; set; }
        [Required]
        [DisplayName("To")]
        public string To { get; set; }
        [Required]
        [DisplayName("Item")]
        public string Item { get; set; }
    }
}
