using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LMS.Administration.Pages.Staff
{
    public class StaffGeneralInfoModel : PageModel
    {
        public StaffGeneral staffGeneral { get; set; }
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

            //ReturnUrl ??= Url.Content($"~/Staff/StaffPersonalInfo/{staffGeneral.Id}");
            ReturnUrl ??= Url.Content($"~/Staff/StaffPersonalInfo");
            return LocalRedirect(ReturnUrl);
        }
    }
    public class StaffGeneral
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Title Required.")]
        [DisplayName("Title")]
        public string Title { get; set; }
        public List<SelectListItem> lstTitle { get; set; }

        [Required(ErrorMessage = "First Name Required.")]
        [DisplayName("First Name")]
        public required string FirstName { get; set; }

        [DisplayName("Middle Name")]
        public required string MiddleName { get; set; }

        [Required(ErrorMessage = "Last Name Required.")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of Joining Required.")]
        [DisplayName("Date of Joining")]
        public string DoJ { get; set; }

        [Required(ErrorMessage = "Gender Required.")]
        [DisplayName("Gender")]
        public string GenderId { get; set; }
        public List<SelectListItem> lstGender { get; set; }

        [Required(ErrorMessage = "Date of Birth Required.")]
        [DisplayName("Date of Birth")]
        public string DoB { get; set; }

        [Required(ErrorMessage = "Department Required.")]
        [DisplayName("Department")]
        public string DepartmentId { get; set; }
        public List<SelectListItem> lstDepartment { get; set; }

        [Required(ErrorMessage = "Designation Required.")]
        [DisplayName("Designation")]
        public string DesignationId { get; set; }
        public List<SelectListItem> lstDesignation { get; set; }

        [Required(ErrorMessage = "Role Required.")]
        [DisplayName("Role")]
        public string RoleId { get; set; }
        public List<SelectListItem> lstRole { get; set; }

        [Required(ErrorMessage = "Salary Offered Required.")]
        [DisplayName("Salary Offered")]
        public string SalaryOffered { get; set; }

        [Required(ErrorMessage = "Qualification Required.")]
        [DisplayName("Qualification")]
        public string Qualification { get; set; }

        [Required(ErrorMessage = "Experience Required.")]
        [DisplayName("Experience")]
        public string Experience { get; set; }

        [Required(ErrorMessage = "Area Of Specialization Required.")]
        [DisplayName("Area Of Specialization")]
        public string AreaOfSpecialization { get; set; }

        [Required(ErrorMessage = "Biometric identification number Required.")]
        [DisplayName("Biometric identification number")]
        public string BiometricIdentificationNumberId { get; set; }

        [Required(ErrorMessage = "Date Of Superannuation Required.")]
        [DisplayName("Date Of Superannuation")]
        public string DateOfSuperannuation { get; set; }

        [Required(ErrorMessage = "Date Of Regular Appointment Required.")]
        [DisplayName("Date Of Regular Appointment")]
        public string DateOfRegularAppointment { get; set; }

        [Required(ErrorMessage = "Social Category Required.")]
        [DisplayName("Social Category")]
        public string SocialCategoryId { get; set; }
        public List<SelectListItem> lstSocialCategory { get; set; }

        [Required(ErrorMessage = "Caste Required.")]
        [DisplayName("Caste")]
        public string Caste { get; set; }

        [DisplayName("Library Card Number")]
        public string LibraryCardNumber { get; set; }
    }
}
