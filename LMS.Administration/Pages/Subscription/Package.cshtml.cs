using LMS.Administration.Middleware;
using LMS.Administration.Pages.Library;
using LMS.Mapper.IService;
using LMS.Mapper.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LMS.Administration.Pages.Subscription
{
    public class PackageModel : PageModel
    {
        private readonly ILogger<PackageModel> _logger;
        private readonly ISubscriptionPackageService _subscriptionPackageService;
        private readonly IActiveUserService _activeUserService;
        public PackageModel(ILogger<PackageModel> logger, ISubscriptionPackageService subscriptionPackageService, IActiveUserService activeUserService)
        {
            _logger = logger;
            _subscriptionPackageService = subscriptionPackageService;
            _activeUserService = activeUserService;
        }
        public List<LMS.Mapper.BusinessObject.SubscriptionPackage> subscriptionPackages { get; set; }
        [BindProperty]
        public SubscriptionPackage newSubscriptionPackage { get; set; }
        [BindProperty]
        public SubscriptionPackage editSubscriptionPackage { get; set; }
        public async Task<IActionResult> OnGet()
        {
            subscriptionPackages = await _subscriptionPackageService.GetSubscriptionPackages();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                subscriptionPackages = await _subscriptionPackageService.GetSubscriptionPackages();
                return Page();
            }

            if (string.IsNullOrEmpty(newSubscriptionPackage.SubscriptionPackageId))
            {
                LMS.Mapper.BusinessObject.SubscriptionPackage model = new Mapper.BusinessObject.SubscriptionPackage();
                model.SubscriptionPackageName = newSubscriptionPackage.SubscriptionPackageName;
                model.SubscriptionPeriodMonths = newSubscriptionPackage.SubscriptionPeriodMonths;
                model.PriceMonth = newSubscriptionPackage.PriceMonth;
                model.DiscountPer = newSubscriptionPackage.DiscountPer;
                model.Decription = newSubscriptionPackage.Description;
                model.IsActive = newSubscriptionPackage.IsActive;
                model.CreatedOn = DateTime.Now;
                model.CreatedBy = _activeUserService.UserId;
                int isSave = await _subscriptionPackageService.InsertSubscriptionPackage(model);
            }
            else
            {
                var existingModel = await _subscriptionPackageService.GetSubscriptionPackageById(newSubscriptionPackage.SubscriptionPackageId);
                if (existingModel != null)
                {
                    existingModel.SubscriptionPackageName = newSubscriptionPackage.SubscriptionPackageName;
                    existingModel.SubscriptionPeriodMonths = newSubscriptionPackage.SubscriptionPeriodMonths;
                    existingModel.PriceMonth = newSubscriptionPackage.PriceMonth;
                    existingModel.DiscountPer = newSubscriptionPackage.DiscountPer;
                    existingModel.Decription = newSubscriptionPackage.Description;
                    existingModel.IsActive = newSubscriptionPackage.IsActive;
                    existingModel.ModifiedOn = DateTime.Now;
                    existingModel.ModifiedBy = _activeUserService.UserId;
                    int isUpdated = await _subscriptionPackageService.UpdateSubscriptionPackage(existingModel);
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            var existingModel = await _subscriptionPackageService.GetSubscriptionPackageById(id);
            if (existingModel == null)
            {
                return NotFound();
            }

            editSubscriptionPackage.SubscriptionPackageName = existingModel.SubscriptionPackageName;
            editSubscriptionPackage.SubscriptionPeriodMonths = existingModel.SubscriptionPeriodMonths;
            editSubscriptionPackage.PriceMonth = existingModel.PriceMonth;
            editSubscriptionPackage.DiscountPer = existingModel.DiscountPer;
            editSubscriptionPackage.Description = existingModel.Decription;
            editSubscriptionPackage.IsActive = existingModel.IsActive;

            subscriptionPackages = await _subscriptionPackageService.GetSubscriptionPackages();
            return Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            int isDeleted = await _subscriptionPackageService.DeleteSubscriptionPackage(id);

            subscriptionPackages = await _subscriptionPackageService.GetSubscriptionPackages();
            return Page();
        }
    }
    public class SubscriptionPackage
    {
        public string SubscriptionPackageId { get; set; }
        [Required(ErrorMessage = "Package Name Required.")]
        [DisplayName("Package Name")]
        public string SubscriptionPackageName { get; set; } = null!;
        [Required(ErrorMessage = "Subscription Period Required.")]
        [DisplayName("Subscription Period (Monthly)")]
        public int SubscriptionPeriodMonths { get; set; }
        [Required(ErrorMessage = "Subscription Price Required.")]
        [DisplayName("Subscription Price (Monthly)")]
        public decimal PriceMonth { get; set; }
        [DisplayName("Discount")]
        public int? DiscountPer { get; set; }
        [Required(ErrorMessage = "Description Required.")]
        [DisplayName("Description")]
        public string Description { get; set; } = null!;
        [Required(ErrorMessage = "Status Required.")]
        [DisplayName("Status")]
        public bool IsActive { get; set; }
    }
}
