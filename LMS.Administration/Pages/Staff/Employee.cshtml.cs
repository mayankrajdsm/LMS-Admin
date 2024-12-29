using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LMS.Administration.Pages.Staff
{
    public class EmployeeModel : PageModel
    {
        public void OnGet()
        {
        }
    }
    public class StaffGeneral
    {
        public string? Id { get; set; }

        [Required(ErrorMessage = "Title Required.")]
        [DisplayName("Title")]
        public required string Title { get; set; }
        public List<SelectListItem>? lstTitle { get; set; }

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
        public DateTime DoJ { get; set; }

        [Required(ErrorMessage = "Gender Required.")]
        [DisplayName("Gender")]
        public string GenderId { get; set; }
        public List<SelectListItem> lstGender { get; set; }

        [Required(ErrorMessage = "Date of Birth Required.")]
        [DisplayName("Date of Birth")]
        public DateTime DoB { get; set; }

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
        public decimal SalaryOffered { get; set; }

        [Required(ErrorMessage = "Qualification Required.")]
        [DisplayName("Qualification")]
        public string Qualification { get; set; }

        [Required(ErrorMessage = "Experience Required.")]
        [DisplayName("Experience")]
        public string Experience { get; set; }

        [Required(ErrorMessage = "Area Of Specialization Required.")]
        [DisplayName("Area Of Specialization")]
        public string AreaOfSpecialization { get; set; }

        [Required(ErrorMessage = "Marriage Anniversary Required.")]
        [DisplayName("Marriage Anniversary")]
        public DateTime MarriageAnniversary { get; set; }

        [Required(ErrorMessage = "Date Of Superannuation Required.")]
        [DisplayName("Date Of Superannuation")]
        public DateTime DateOfSuperannuation { get; set; }

        [Required(ErrorMessage = "Date Of Regular Appointment Required.")]
        [DisplayName("Date Of Regular Appointment")]
        public DateTime DateOfRegularAppointment { get; set; }

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
        public DateTime SpouseName { get; set; }

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

        [Required(ErrorMessage = "Biometric identification number Required.")]
        [DisplayName("Biometric identification number")]
        public string BiometricIdentificationNumberId { get; set; }

        [DisplayName("Only Viewing rights")]
        public bool OnlyViewingrights { get; set; }

        [DisplayName("UAN Number")]
        public int UANNumber { get; set; }

        [Required(ErrorMessage = "Shift In Time Required.")]
        [DisplayName("Shift In Time")]
        public TimeOnly ShiftInTime { get; set; }

        [Required(ErrorMessage = "Shift Out Time Required.")]
        [DisplayName("Shift Out Time")]
        public TimeOnly ShiftOutTime { get; set; }

        [Required(ErrorMessage = "Bank Name Required.")]
        [DisplayName("BankName")]
        public string BankName { get; set; }
        public List<SelectListItem> lstBanks { get; set; }

        [Required(ErrorMessage = "Ifsc Code Required.")]
        [DisplayName("Ifsc Code")]
        public string IfscCode { get; set; }
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
    public class StaffQalification
    {
        public string Qualification { get; set; }
        public string Subject { get; set; }
        public string Board { get; set; }
        public int PassingYear { get; set; }
        public int Percentage { get; set; }
    }
    public class StaffExperience
    {
        public string Organization { get; set; }
        public string Designation { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
