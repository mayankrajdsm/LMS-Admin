using System;
using System.Collections.Generic;

namespace LMS.Mapper.BusinessObject
{
    public class Staff
    {
        public string StaffId { get; set; }

        public string? TitleId { get; set; }

        public string FirstName { get; set; } = null!;

        public string? MiddleName { get; set; }

        public string LastName { get; set; } = null!;

        public DateTime DoJ { get; set; }

        public string GenderId { get; set; }

        public DateTime DoB { get; set; }

        public string? DepartmentId { get; set; }

        public string? DesignationId { get; set; }

        public string? RoleId { get; set; }

        public decimal? SalaryOffered { get; set; }

        public string? Qualification { get; set; }

        public string? Experience { get; set; }

        public string? AreaOfSpecialization { get; set; }

        public string? BiometricIdentificationNumberId { get; set; }

        public DateTime? DateOfSuperannuation { get; set; }

        public DateTime? DateOfRegularAppointment { get; set; }

        public string? SocialCategoryId { get; set; }

        public string? Caste { get; set; }

        public string? LibraryCardNumber { get; set; }

        public string? ProfilePicture { get; set; }

        public int? AadharCardNo { get; set; }

        public string? MaritalStatusId { get; set; }

        public DateTime? MarriageAnniversary { get; set; }

        public string? SpouseName { get; set; }

        public string? PanCardNo { get; set; }

        public string? FatherName { get; set; }

        public string? MotherName { get; set; }

        public string? BloodGroupId { get; set; }

        public string? Nationality { get; set; }

        public string? EmployementTypeId { get; set; }

        public bool? OnlyViewingrights { get; set; }

        public int? Uannumber { get; set; }

        public string? ShiftInTime { get; set; }

        public string? ShiftOutTime { get; set; }

        public string? BankName { get; set; }

        public string? IfscCode { get; set; }

        public int? AccountNumber { get; set; }

        public int? Mobile { get; set; }

        public string? EmailId { get; set; }

        public string? AlternateEmailId { get; set; }

        public string? LinkedInProfile { get; set; }

        public string? PermanentAddress1 { get; set; }

        public string? PermanentAddress2 { get; set; }

        public string? PermanentCountryId { get; set; }

        public string? PermanentStateId { get; set; }

        public string? PermanentCityId { get; set; }

        public int? PermanentPincode { get; set; }

        public string? PresentAddress1 { get; set; }

        public string? PresentAddress2 { get; set; }

        public string? PresentCountryId { get; set; }

        public string? PresentStateId { get; set; }

        public string? PresentCityId { get; set; }

        public int? PresentPincode { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string? ModifiedBy { get; set; }

        public string? BuildingId { get; set; }

        public string? Password { get; set; }

        public List<AboutU> AboutUCreatedByNavigations { get; set; } = new List<AboutU>();

        public List<AboutU> AboutUModifiedByNavigations { get; set; } = new List<AboutU>();

        public List<Banner> BannerCreatedByNavigations { get; set; } = new List<Banner>();

        public List<Banner> BannerModifiedByNavigations { get; set; } = new List<Banner>();

        public List<Barcode> BarcodeCreatedByNavigations { get; set; } = new List<Barcode>();

        public List<Barcode> BarcodeModifiedByNavigations { get; set; } = new List<Barcode>();

        public List<Batch> BatchCreatedByNavigations { get; set; } = new List<Batch>();

        public List<Batch> BatchModifiedByNavigations { get; set; } = new List<Batch>();

        public BloodGroup? BloodGroup { get; set; }

        public List<BloodGroup> BloodGroupCreatedByNavigations { get; set; } = new List<BloodGroup>();

        public List<BloodGroup> BloodGroupModifiedByNavigations { get; set; } = new List<BloodGroup>();

        // public List<Book> BookCreatedByNavigations { get; set; } = new List<Book>();

        // public List<Book> BookModifiedByNavigations { get; set; } = new List<Book>();

        public Building? Building { get; set; }

        public List<Building> BuildingCreatedByNavigations { get; set; } = new List<Building>();

        public List<Building> BuildingModifiedByNavigations { get; set; } = new List<Building>();

        public List<City> CityCreatedByNavigations { get; set; } = new List<City>();

        public List<City> CityModifiedByNavigations { get; set; } = new List<City>();

        // public List<Class> ClassCreatedByNavigations { get; set; } = new List<Class>();

        // public List<Class> ClassModifiedByNavigations { get; set; } = new List<Class>();

        public List<ContactU> ContactUCreatedByNavigations { get; set; } = new List<ContactU>();

        public List<ContactU> ContactUModifiedByNavigations { get; set; } = new List<ContactU>();

        public List<Country> CountryCreatedByNavigations { get; set; } = new List<Country>();

        public List<Country> CountryModifiedByNavigations { get; set; } = new List<Country>();

        public Department? Department { get; set; }

        public List<Department> DepartmentCreatedByNavigations { get; set; } = new List<Department>();

        public List<Department> DepartmentModifiedByNavigations { get; set; } = new List<Department>();

        public StaffType? Designation { get; set; }

        public List<Domain> Domains { get; set; } = new List<Domain>();

        public EmployementType? EmployementType { get; set; }

        public List<EmployementType> EmployementTypeCreatedByNavigations { get; set; } = new List<EmployementType>();

        public List<EmployementType> EmployementTypeModifiedByNavigations { get; set; } = new List<EmployementType>();

        public List<Gender> GenderCreatedByNavigations { get; set; } = new List<Gender>();

        public List<Gender> GenderModifiedByNavigations { get; set; } = new List<Gender>();

        public List<Staff> InverseModifiedByNavigation { get; set; } = new List<Staff>();

        public List<IssueBookStudent> IssueBookStudentCreatedByNavigations { get; set; } = new List<IssueBookStudent>();

        public List<IssueBookStudent> IssueBookStudentModifiedByNavigations { get; set; } = new List<IssueBookStudent>();

        public List<LoginType> LoginTypeCreatedByNavigations { get; set; } = new List<LoginType>();

        public List<LoginType> LoginTypeModifiedByNavigations { get; set; } = new List<LoginType>();

        public MaritalStatus? MaritalStatus { get; set; }

        public List<MaritalStatus> MaritalStatusCreatedByNavigations { get; set; } = new List<MaritalStatus>();

        public List<MaritalStatus> MaritalStatusModifiedByNavigations { get; set; } = new List<MaritalStatus>();

        public Staff? ModifiedByNavigation { get; set; }

        public Country? NationalityNavigation { get; set; }

        public List<PaymentStatus> PaymentStatusCreatedByNavigations { get; set; } = new List<PaymentStatus>();

        public List<PaymentStatus> PaymentStatusModifiedByNavigations { get; set; } = new List<PaymentStatus>();

        public Country? PermanentCountry { get; set; }

        public State? PermanentState { get; set; }

        public City? PresentCity { get; set; }

        public Country? PresentCountry { get; set; }

        public State? PresentState { get; set; }

        public LoginType? Role { get; set; }

        public SocialCategory? SocialCategory { get; set; }

        public List<SocialCategory> SocialCategoryCreatedByNavigations { get; set; } = new List<SocialCategory>();

        public List<SocialCategory> SocialCategoryModifiedByNavigations { get; set; } = new List<SocialCategory>();

        // public List<StaffExperience> StaffExperienceCreatedByNavigations { get; set; } = new List<StaffExperience>();

        // public List<StaffExperience> StaffExperienceStaffs { get; set; } = new List<StaffExperience>();

        // public List<StaffQalification> StaffQalifications { get; set; } = new List<StaffQalification>();

        // public List<StaffType> StaffTypeCreatedByNavigations { get; set; } = new List<StaffType>();

        // public List<StaffType> StaffTypeModifiedByNavigations { get; set; } = new List<StaffType>();

        // public List<State> StateCreatedByNavigations { get; set; } = new List<State>();

        // public List<State> StateModifiedByNavigations { get; set; } = new List<State>();

        // public List<Status> StatusCreatedByNavigations { get; set; } = new List<Status>();

        // public List<Status> StatusModifiedByNavigations { get; set; } = new List<Status>();

        // public List<StudentCategory> StudentCategoryCreatedByNavigations { get; set; } = new List<StudentCategory>();

        // public List<StudentCategory> StudentCategoryModifiedByNavigations { get; set; } = new List<StudentCategory>();

        // public List<Student> StudentCreatedByNavigations { get; set; } = new List<Student>();

        // public List<StudentEducation> StudentEducationCreatedByNavigations { get; set; } = new List<StudentEducation>();

        // public List<StudentEducation> StudentEducationModifiedByNavigations { get; set; } = new List<StudentEducation>();

        // public List<StudentGuardian> StudentGuardianCreatedByNavigations { get; set; } = new List<StudentGuardian>();

        // public List<StudentGuardian> StudentGuardianModifiedByNavigations { get; set; } = new List<StudentGuardian>();

        // public List<Student> StudentModifiedByNavigations { get; set; } = new List<Student>();

        // public List<StudentParent> StudentParentCreatedByNavigations { get; set; } = new List<StudentParent>();

        // public List<StudentParent> StudentParentModifiedByNavigations { get; set; } = new List<StudentParent>();

        // public List<StudentSeatBooking> StudentSeatBookingCreatedByNavigations { get; set; } = new List<StudentSeatBooking>();

        // public List<StudentSeatBooking> StudentSeatBookingModifiedByNavigations { get; set; } = new List<StudentSeatBooking>();

        // public List<StudentSubType> StudentSubTypeCreatedByNavigations { get; set; } = new List<StudentSubType>();

        // public List<StudentSubType> StudentSubTypeModifiedByNavigations { get; set; } = new List<StudentSubType>();

        // public List<StudentTransport> StudentTransportCreatedByNavigations { get; set; } = new List<StudentTransport>();

        // public List<StudentTransport> StudentTransportModifiedByNavigations { get; set; } = new List<StudentTransport>();

        // public List<Subject> SubjectCreatedByNavigations { get; set; } = new List<Subject>();

        // public List<Subject> SubjectExamHeadNavigations { get; set; } = new List<Subject>();

        // public List<Subject> SubjectModifiedByNavigations { get; set; } = new List<Subject>();

        // public List<SubscriptionPackage> SubscriptionPackageCreatedByNavigations { get; set; } = new List<SubscriptionPackage>();

        // public List<SubscriptionPackage> SubscriptionPackageModifiedByNavigations { get; set; } = new List<SubscriptionPackage>();

        // public List<SubscriptionPayment> SubscriptionPaymentCreatedByNavigations { get; set; } = new List<SubscriptionPayment>();

        // public List<SubscriptionPayment> SubscriptionPaymentModifiedByNavigations { get; set; } = new List<SubscriptionPayment>();

        // public List<SubscriptionsTransaction> SubscriptionsTransactionCreatedByNavigations { get; set; } = new List<SubscriptionsTransaction>();

        // public List<SubscriptionsTransaction> SubscriptionsTransactionModifiedByNavigations { get; set; } = new List<SubscriptionsTransaction>();

        // public Title? Title { get; set; }
    }
}