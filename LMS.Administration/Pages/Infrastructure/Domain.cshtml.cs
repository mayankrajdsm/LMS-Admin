using LMS.Administration.Pages.Staff;
using LMS.Mapper.BusinessObject;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace LMS.Administration.Pages.Infrastructure
{
    public class DomainModel : PageModel
    {
        private readonly ILogger<DomainModel> _logger;
        private readonly IDomainService _domainService;
        public DomainModel(ILogger<DomainModel> logger, IDomainService domainService)
        {
            _logger = logger;
            _domainService = domainService;
        }
        [BindProperty]
        public Domain domain { get; set; }
        public async Task<IActionResult> OnGet()
        {
            var existingDomain = await _domainService.GetDomain();
            domain.RegisteredName = existingDomain.RegisteredName;
            domain.Address1 = existingDomain.Address1;
            domain.Address2 = existingDomain.Address2;
            domain.CountryId = existingDomain.CountryId;
            domain.StateId = existingDomain.StateId;
            domain.CityId = existingDomain.CityId;
            domain.ContactPerson = existingDomain.ContactPerson;
            domain.ContactNo = existingDomain.ContactNo;
            domain.ContactEmail = existingDomain.ContactEmail;
            domain.Website = "";
            domain.FinancialYearStartDate = DateTime.Now;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                LMS.Mapper.BusinessObject.Domain domainUpdate = new LMS.Mapper.BusinessObject.Domain();
                domainUpdate.RegisteredName = domain.RegisteredName;
                domainUpdate.Address1 = domain.Address1;
                domainUpdate.Address2 = domain.Address2;
                domainUpdate.CountryId = domain.CountryId;
                domainUpdate.StateId = domain.StateId;
                domainUpdate.CityId = domain.CityId;
                domainUpdate.ContactPerson = domain.ContactPerson;
                domainUpdate.ContactNo = domain.ContactNo;
                domainUpdate.ContactEmail = domain.ContactEmail;

                int isSave = await _domainService.UpdateDomain(domainUpdate);

                if (isSave > 0)
                {

                }
                return Page();
            }
            return Page();
        }
    }
    public class Domain
    {
        [Required]
        [DisplayName("Registered Domain Name")]
        public string RegisteredName { get; set; } = null!;

        [Required]
        [DisplayName("Address 1")]
        public string Address1 { get; set; } = null!;

        [Required]
        [DisplayName("Address 2")]
        public string Address2 { get; set; } = null!;

        [Required]
        [DisplayName("Country")]
        public string CountryId { get; set; }
        public List<SelectListItem> lstCountry { get; set; }

        [Required]
        [DisplayName("State")]
        public string StateId { get; set; }
        public List<SelectListItem> lstState { get; set; }

        [Required]
        [DisplayName("City")]
        public string CityId { get; set; }
        public List<SelectListItem> lstCity { get; set; }

        [Required]
        [DisplayName("Contact Person ")]
        public string ContactPerson { get; set; } = null!;

        [Required]
        [DisplayName("Contact No")]
        [Phone(ErrorMessage = "Invalid Contact No")]
        public string ContactNo { get; set; } = null!;

        [Required]
        [DisplayName("Contact Email")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string ContactEmail { get; set; } = null!;

        [DisplayName("Website")]
        [Url(ErrorMessage = "Invalid website URL")]
        public string Website { get; set; } = null!;

        [Required]
        [DisplayName("Financial Year Start Date")]
        public DateTime? FinancialYearStartDate { get; set; } = null!;
    }
}
