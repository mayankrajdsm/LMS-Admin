using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LMS.Administration.Pages.Staff
{
    public class StaffContactModel : PageModel
    {
        public StaffContact staffContact { get; set; }
        public void OnGet()
        {
        }
    }

    public class StaffContact
    {
        public string StaffId { get; set; }

        [Required(ErrorMessage = "Mobile Required.")]
        [DisplayName("Mobile")]
        public int Mobile { get; set; }

        [Required(ErrorMessage = "Email Id Required.")]
        [DisplayName("Email Id")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Alternate Email Id Required.")]
        [DisplayName("Alternate Email Id")]
        public string AlternateEmailId { get; set; }

        [DisplayName("LinkedIn Profile")]
        public string LinkedInProfile { get; set; }

        [Required(ErrorMessage = "Address1 Required.")]
        [DisplayName("Address Line 1")]
        public string PermanentAddress1 { get; set; }

        [Required(ErrorMessage = "Address2 Required.")]
        [DisplayName("Address Line 2")]
        public string PermanentAddress2 { get; set; }

        [Required(ErrorMessage = "Country Required.")]
        [DisplayName("Country")]
        public string PermanentCountryId { get; set; }
        public List<SelectListItem> lstPermanentCountry { get; set; }

        [Required(ErrorMessage = "State Required.")]
        [DisplayName("State")]
        public string PermanentStateId { get; set; }
        public List<SelectListItem> lstPermanentState { get; set; }

        [Required(ErrorMessage = "City Required.")]
        [DisplayName("City")]
        public string PermanentCityId { get; set; }
        public List<SelectListItem> lstPermanentCity { get; set; }

        [Required(ErrorMessage = "Pincode Required.")]
        [DisplayName("Pincode")]
        public int PermanentPincode { get; set; }

        [Required(ErrorMessage = "Address1 Required.")]
        [DisplayName("Address Line 1")]
        public string PresentAddress1 { get; set; }

        [Required(ErrorMessage = "Address2 Required.")]
        [DisplayName("Address Line 2")]
        public string PresentAddress2 { get; set; }

        [Required(ErrorMessage = "Country Required.")]
        [DisplayName("Country")]
        public string PresentCountryId { get; set; }
        public List<SelectListItem> lstPresentCountry { get; set; }

        [Required(ErrorMessage = "State Required.")]
        [DisplayName("State")]
        public string PresentStateId { get; set; }
        public List<SelectListItem> lstPresentState { get; set; }

        [Required(ErrorMessage = "City Required.")]
        [DisplayName("City")]
        public string PresentCityId { get; set; }
        public List<SelectListItem> lstPresentCity { get; set; }

        [Required(ErrorMessage = "Pincode Required.")]
        [DisplayName("Pincode")]
        public int PresentPincode { get; set; }
    }
}
