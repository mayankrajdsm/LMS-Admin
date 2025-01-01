using System;
using System.Collections.Generic;

namespace LMS.Infrastructures.Models;

public partial class Staff
{
    public Guid StaffId { get; set; }

    public Guid? TitleId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public DateTime DoJ { get; set; }

    public Guid GenderId { get; set; }

    public DateTime DoB { get; set; }

    public Guid? DepartmentId { get; set; }

    public Guid? DesignationId { get; set; }

    public Guid? RoleId { get; set; }

    public decimal? SalaryOffered { get; set; }

    public string? Qualification { get; set; }

    public string? Experience { get; set; }

    public string? AreaOfSpecialization { get; set; }

    public string? BiometricIdentificationNumberId { get; set; }

    public DateTime? DateOfSuperannuation { get; set; }

    public DateTime? DateOfRegularAppointment { get; set; }

    public Guid? SocialCategoryId { get; set; }

    public string? Caste { get; set; }

    public string? LibraryCardNumber { get; set; }

    public string? ProfilePicture { get; set; }

    public int? AadharCardNo { get; set; }

    public Guid? MaritalStatusId { get; set; }

    public DateTime? MarriageAnniversary { get; set; }

    public string? SpouseName { get; set; }

    public string? PanCardNo { get; set; }

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public Guid? BloodGroupId { get; set; }

    public Guid? Nationality { get; set; }

    public Guid? EmployementTypeId { get; set; }

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

    public Guid? PermanentCountryId { get; set; }

    public Guid? PermanentStateId { get; set; }

    public Guid? PermanentCityId { get; set; }

    public int? PermanentPincode { get; set; }

    public string? PresentAddress1 { get; set; }

    public string? PresentAddress2 { get; set; }

    public Guid? PresentCountryId { get; set; }

    public Guid? PresentStateId { get; set; }

    public Guid? PresentCityId { get; set; }

    public int? PresentPincode { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedBy { get; set; }

    public Guid? BuildingId { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<AboutU> AboutUCreatedByNavigations { get; set; } = new List<AboutU>();

    public virtual ICollection<AboutU> AboutUModifiedByNavigations { get; set; } = new List<AboutU>();

    public virtual ICollection<Banner> BannerCreatedByNavigations { get; set; } = new List<Banner>();

    public virtual ICollection<Banner> BannerModifiedByNavigations { get; set; } = new List<Banner>();

    public virtual ICollection<Barcode> BarcodeCreatedByNavigations { get; set; } = new List<Barcode>();

    public virtual ICollection<Barcode> BarcodeModifiedByNavigations { get; set; } = new List<Barcode>();

    public virtual ICollection<Batch> BatchCreatedByNavigations { get; set; } = new List<Batch>();

    public virtual ICollection<Batch> BatchModifiedByNavigations { get; set; } = new List<Batch>();

    public virtual BloodGroup? BloodGroup { get; set; }

    public virtual ICollection<BloodGroup> BloodGroupCreatedByNavigations { get; set; } = new List<BloodGroup>();

    public virtual ICollection<BloodGroup> BloodGroupModifiedByNavigations { get; set; } = new List<BloodGroup>();

    public virtual ICollection<Book> BookCreatedByNavigations { get; set; } = new List<Book>();

    public virtual ICollection<Book> BookModifiedByNavigations { get; set; } = new List<Book>();

    public virtual Building? Building { get; set; }

    public virtual ICollection<Building> BuildingCreatedByNavigations { get; set; } = new List<Building>();

    public virtual ICollection<Building> BuildingModifiedByNavigations { get; set; } = new List<Building>();

    public virtual ICollection<City> CityCreatedByNavigations { get; set; } = new List<City>();

    public virtual ICollection<City> CityModifiedByNavigations { get; set; } = new List<City>();

    public virtual ICollection<Class> ClassCreatedByNavigations { get; set; } = new List<Class>();

    public virtual ICollection<Class> ClassModifiedByNavigations { get; set; } = new List<Class>();

    public virtual ICollection<ContactU> ContactUCreatedByNavigations { get; set; } = new List<ContactU>();

    public virtual ICollection<ContactU> ContactUModifiedByNavigations { get; set; } = new List<ContactU>();

    public virtual ICollection<Country> CountryCreatedByNavigations { get; set; } = new List<Country>();

    public virtual ICollection<Country> CountryModifiedByNavigations { get; set; } = new List<Country>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<Department> DepartmentCreatedByNavigations { get; set; } = new List<Department>();

    public virtual ICollection<Department> DepartmentModifiedByNavigations { get; set; } = new List<Department>();

    public virtual StaffType? Designation { get; set; }

    public virtual ICollection<Domain> Domains { get; set; } = new List<Domain>();

    public virtual EmployementType? EmployementType { get; set; }

    public virtual ICollection<EmployementType> EmployementTypeCreatedByNavigations { get; set; } = new List<EmployementType>();

    public virtual ICollection<EmployementType> EmployementTypeModifiedByNavigations { get; set; } = new List<EmployementType>();

    public virtual ICollection<Gender> GenderCreatedByNavigations { get; set; } = new List<Gender>();

    public virtual ICollection<Gender> GenderModifiedByNavigations { get; set; } = new List<Gender>();

    public virtual ICollection<Staff> InverseModifiedByNavigation { get; set; } = new List<Staff>();

    public virtual ICollection<IssueBookStudent> IssueBookStudentCreatedByNavigations { get; set; } = new List<IssueBookStudent>();

    public virtual ICollection<IssueBookStudent> IssueBookStudentModifiedByNavigations { get; set; } = new List<IssueBookStudent>();

    public virtual ICollection<LoginType> LoginTypeCreatedByNavigations { get; set; } = new List<LoginType>();

    public virtual ICollection<LoginType> LoginTypeModifiedByNavigations { get; set; } = new List<LoginType>();

    public virtual MaritalStatus? MaritalStatus { get; set; }

    public virtual ICollection<MaritalStatus> MaritalStatusCreatedByNavigations { get; set; } = new List<MaritalStatus>();

    public virtual ICollection<MaritalStatus> MaritalStatusModifiedByNavigations { get; set; } = new List<MaritalStatus>();

    public virtual Staff? ModifiedByNavigation { get; set; }

    public virtual Country? NationalityNavigation { get; set; }

    public virtual ICollection<PaymentStatus> PaymentStatusCreatedByNavigations { get; set; } = new List<PaymentStatus>();

    public virtual ICollection<PaymentStatus> PaymentStatusModifiedByNavigations { get; set; } = new List<PaymentStatus>();

    public virtual Country? PermanentCountry { get; set; }

    public virtual State? PermanentState { get; set; }

    public virtual City? PresentCity { get; set; }

    public virtual Country? PresentCountry { get; set; }

    public virtual State? PresentState { get; set; }

    public virtual LoginType? Role { get; set; }

    public virtual SocialCategory? SocialCategory { get; set; }

    public virtual ICollection<SocialCategory> SocialCategoryCreatedByNavigations { get; set; } = new List<SocialCategory>();

    public virtual ICollection<SocialCategory> SocialCategoryModifiedByNavigations { get; set; } = new List<SocialCategory>();

    public virtual ICollection<StaffExperience> StaffExperienceCreatedByNavigations { get; set; } = new List<StaffExperience>();

    public virtual ICollection<StaffExperience> StaffExperienceStaffs { get; set; } = new List<StaffExperience>();

    public virtual ICollection<StaffQalification> StaffQalifications { get; set; } = new List<StaffQalification>();

    public virtual ICollection<StaffType> StaffTypeCreatedByNavigations { get; set; } = new List<StaffType>();

    public virtual ICollection<StaffType> StaffTypeModifiedByNavigations { get; set; } = new List<StaffType>();

    public virtual ICollection<State> StateCreatedByNavigations { get; set; } = new List<State>();

    public virtual ICollection<State> StateModifiedByNavigations { get; set; } = new List<State>();

    public virtual ICollection<Status> StatusCreatedByNavigations { get; set; } = new List<Status>();

    public virtual ICollection<Status> StatusModifiedByNavigations { get; set; } = new List<Status>();

    public virtual ICollection<StudentCategory> StudentCategoryCreatedByNavigations { get; set; } = new List<StudentCategory>();

    public virtual ICollection<StudentCategory> StudentCategoryModifiedByNavigations { get; set; } = new List<StudentCategory>();

    public virtual ICollection<Student> StudentCreatedByNavigations { get; set; } = new List<Student>();

    public virtual ICollection<StudentEducation> StudentEducationCreatedByNavigations { get; set; } = new List<StudentEducation>();

    public virtual ICollection<StudentEducation> StudentEducationModifiedByNavigations { get; set; } = new List<StudentEducation>();

    public virtual ICollection<StudentGuardian> StudentGuardianCreatedByNavigations { get; set; } = new List<StudentGuardian>();

    public virtual ICollection<StudentGuardian> StudentGuardianModifiedByNavigations { get; set; } = new List<StudentGuardian>();

    public virtual ICollection<Student> StudentModifiedByNavigations { get; set; } = new List<Student>();

    public virtual ICollection<StudentParent> StudentParentCreatedByNavigations { get; set; } = new List<StudentParent>();

    public virtual ICollection<StudentParent> StudentParentModifiedByNavigations { get; set; } = new List<StudentParent>();

    public virtual ICollection<StudentSeatBooking> StudentSeatBookingCreatedByNavigations { get; set; } = new List<StudentSeatBooking>();

    public virtual ICollection<StudentSeatBooking> StudentSeatBookingModifiedByNavigations { get; set; } = new List<StudentSeatBooking>();

    public virtual ICollection<StudentSubType> StudentSubTypeCreatedByNavigations { get; set; } = new List<StudentSubType>();

    public virtual ICollection<StudentSubType> StudentSubTypeModifiedByNavigations { get; set; } = new List<StudentSubType>();

    public virtual ICollection<StudentTransport> StudentTransportCreatedByNavigations { get; set; } = new List<StudentTransport>();

    public virtual ICollection<StudentTransport> StudentTransportModifiedByNavigations { get; set; } = new List<StudentTransport>();

    public virtual ICollection<Subject> SubjectCreatedByNavigations { get; set; } = new List<Subject>();

    public virtual ICollection<Subject> SubjectExamHeadNavigations { get; set; } = new List<Subject>();

    public virtual ICollection<Subject> SubjectModifiedByNavigations { get; set; } = new List<Subject>();

    public virtual ICollection<SubscriptionPackage> SubscriptionPackageCreatedByNavigations { get; set; } = new List<SubscriptionPackage>();

    public virtual ICollection<SubscriptionPackage> SubscriptionPackageModifiedByNavigations { get; set; } = new List<SubscriptionPackage>();

    public virtual ICollection<SubscriptionPayment> SubscriptionPaymentCreatedByNavigations { get; set; } = new List<SubscriptionPayment>();

    public virtual ICollection<SubscriptionPayment> SubscriptionPaymentModifiedByNavigations { get; set; } = new List<SubscriptionPayment>();

    public virtual ICollection<SubscriptionsTransaction> SubscriptionsTransactionCreatedByNavigations { get; set; } = new List<SubscriptionsTransaction>();

    public virtual ICollection<SubscriptionsTransaction> SubscriptionsTransactionModifiedByNavigations { get; set; } = new List<SubscriptionsTransaction>();

    public virtual Title? Title { get; set; }
}
