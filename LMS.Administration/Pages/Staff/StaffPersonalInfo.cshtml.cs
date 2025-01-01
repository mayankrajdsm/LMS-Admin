using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LMS.Administration.Pages.Staff
{
    public class StaffPersonalInfoModel : PageModel
    {
        public StaffPersonal staffPersonal { get; set; }
        public string ReturnUrl { get; set; }
        public async Task<IActionResult> OnGet()
        {
            //    staffGeneral.lstTitle = new List<SelectListItem>
            //     {
            //         new SelectListItem{Text = "Mr.", Value="1"},
            //         new SelectListItem{Text = "Ms.", Value="2"},
            //         new SelectListItem{Text = "Mrs.", Value="3"},
            //         new SelectListItem{Text = "Dr.", Value="4"},
            //     };
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                //batches = await _batchService.GetBatches();
                return Page();
            }

            //ReturnUrl ??= Url.Content($"~/Staff/StaffPersonalInfo/{staffPersonal.StaffId}");
            ReturnUrl ??= Url.Content($"~/Staff/StaffPersonalInfo");
            return LocalRedirect(ReturnUrl);
        }
    }
    public class StaffPersonal
    {
        public string StaffId { get; set; }

        [Required(ErrorMessage = "Profile Picture Required.")]
        [DisplayName("Profile Picture")]
        public string ProfilePicture { get; set; }

        [Required(ErrorMessage = "Aadhar Card No. Required.")]
        [DisplayName("Aadhar Card No.")]
        public string AadharCardNo { get; set; }

        [DisplayName("Marital Status")]
        public string MaritalStatus { get; set; }
        public List<SelectListItem> lstMaritalStatus { get; set; }

        [Required(ErrorMessage = "Pan Card No. Required.")]
        [DisplayName("Pan Card No.")]
        public string PanCardNo { get; set; }

        [Required(ErrorMessage = "Spouse Name Required.")]
        [DisplayName("Spouse Name")]
        public string SpouseName { get; set; }

        [Required(ErrorMessage = "Father's Name Required.")]
        [DisplayName("Father's Name")]
        public string FatherName { get; set; }

        [Required(ErrorMessage = "Mother's Name Required.")]
        [DisplayName("Mother's Name")]
        public string MotherName { get; set; }

        [Required(ErrorMessage = "Blood Group Required.")]
        [DisplayName("Blood Group")]
        public string BloodGroupId { get; set; }
        public List<SelectListItem> lstBloodGroup { get; set; }

        [Required(ErrorMessage = "Nationality Required.")]
        [DisplayName("Nationality")]
        public string Nationality { get; set; }
        public List<SelectListItem> lstNationality { get; set; }

        [Required(ErrorMessage = "Employement Type Required.")]
        [DisplayName("Employement Type")]
        public string EmployementTypeId { get; set; }
        public List<SelectListItem> lstEmployementType { get; set; }

        [Required(ErrorMessage = "Marriage Anniversary Required.")]
        [DisplayName("Marriage Anniversary")]
        public string MarriageAnniversary { get; set; }

        [DisplayName("Only Viewing rights")]
        public bool OnlyViewingrights { get; set; }

        [DisplayName("UAN Number")]
        public int UANNumber { get; set; }

        [Required(ErrorMessage = "Shift In Time Required.")]
        [DisplayName("Shift In Time")]
        public string ShiftInTime { get; set; }

        [Required(ErrorMessage = "Shift Out Time Required.")]
        [DisplayName("Shift Out Time")]
        public string ShiftOutTime { get; set; }

        [Required(ErrorMessage = "Bank Name Required.")]
        [DisplayName("BankName")]
        public string BankName { get; set; }
        //public List<SelectListItem> lstBanks { get; set; }

        [Required(ErrorMessage = "Ifsc Code Required.")]
        [DisplayName("Ifsc Code")]
        public string IfscCode { get; set; }

        [Required(ErrorMessage = "Account Number Required.")]
        [DisplayName("Account Number")]
        public string AccountNumber { get; set; }
    }
}
