using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.ConversionHelper
{
    public static class EntityModelConversionHelper
    {
        public static Domain ToEntityModel(this BusinessObject.Domain domain, Domain existingDomain = null)
        {
            Domain convertedModel = existingDomain != null ? existingDomain : new Domain();
            convertedModel.DomainId = string.IsNullOrEmpty(domain.DomainId) ? Guid.NewGuid() : Guid.Parse(domain.DomainId);
            convertedModel.RegisteredName = domain.RegisteredName;
            convertedModel.Address1 = domain.Address1;
            convertedModel.Address2 = domain.Address2;
            convertedModel.CountryId = string.IsNullOrEmpty(domain.CountryId) ? Guid.NewGuid() : Guid.Parse(domain.CountryId);
            convertedModel.StateId = string.IsNullOrEmpty(domain.StateId) ? Guid.NewGuid() : Guid.Parse(domain.StateId);
            convertedModel.CityId = string.IsNullOrEmpty(domain.CityId) ? Guid.NewGuid() : Guid.Parse(domain.CityId);
            convertedModel.ContactPerson = domain.ContactPerson;
            convertedModel.ContactNo = domain.ContactNo;
            convertedModel.ContactEmail = domain.ContactEmail;
            convertedModel.IsActive = domain.IsActive;
            convertedModel.CreatedOn = DateTime.Now;
            convertedModel.CreatedBy = new(domain.CreatedBy);
            convertedModel.ModifiedOn = string.IsNullOrEmpty(domain.DomainId) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(domain.DomainId) ? null : Guid.Parse(domain.CreatedBy);
            return convertedModel;
        }
        public static StaffType ToEntityModel(this BusinessObject.StaffType staffType, StaffType existingStaffType = null)
        {
            StaffType convertedModel = existingStaffType != null ? existingStaffType : new StaffType();
            convertedModel.StaffTypeId = string.IsNullOrEmpty(staffType.StaffTypeId) ? Guid.NewGuid() : Guid.Parse(staffType.StaffTypeId);
            convertedModel.StaffTypeName = staffType.StaffTypeName;
            convertedModel.IsActive = staffType.IsActive;
            convertedModel.CreatedOn = staffType.CreatedOn;
            convertedModel.CreatedBy = Guid.Parse(staffType.CreatedBy);
            convertedModel.ModifiedOn = staffType.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(staffType.ModifiedBy) ? null : Guid.Parse(staffType.CreatedBy);
            return convertedModel;
        }
        public static LoginType ToEntityModel(this BusinessObject.LoginType loginType, LoginType existingLoginType = null)
        {
            LoginType convertedModel = existingLoginType != null ? existingLoginType : new LoginType();
            convertedModel.LoginTypeId = string.IsNullOrEmpty(loginType.LoginTypeId) ? Guid.NewGuid() : Guid.Parse(loginType.LoginTypeId);
            convertedModel.LoginTypeName = loginType.LoginTypeName;
            convertedModel.LoginTypeKey = loginType.LoginTypeKey;
            convertedModel.IsActive = loginType.IsActive;
            convertedModel.CreatedOn = loginType.CreatedOn;
            convertedModel.CreatedBy = Guid.Parse(loginType.CreatedBy);
            convertedModel.ModifiedOn = loginType.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(loginType.ModifiedBy) ? null : Guid.Parse(loginType.CreatedBy);
            return convertedModel;
        }
        public static Building ToEntityModel(this BusinessObject.Building building, Building existingBuilding = null)
        {
            Building convertedModel = existingBuilding != null ? existingBuilding : new Building();
            convertedModel.BuildingId = string.IsNullOrEmpty(building.BuildingId) ? Guid.NewGuid() : Guid.Parse(building.BuildingId);
            convertedModel.DomainId = Guid.Parse(building.DomainId);
            convertedModel.BuildingName = building.BuildingName;
            convertedModel.Address1 = building.Address1;
            convertedModel.Address2 = building.Address2;
            convertedModel.CountryId = Guid.Parse(building.CountryId);
            convertedModel.StateId = Guid.Parse(building.StateId);
            convertedModel.CityId = Guid.Parse(building.CityId);
            convertedModel.ContactPerson = building.ContactPerson;
            convertedModel.ContactNo = building.ContactNo;
            convertedModel.ContactEmail = building.ContactEmail;
            convertedModel.IsActive = building.IsActive;
            convertedModel.CreatedBy = Guid.Parse(building.CreatedBy);
            convertedModel.CreatedOn = building.CreatedOn;
            convertedModel.ModifiedOn = building.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(building.ModifiedBy) ? null : Guid.Parse(building.CreatedBy);
            return convertedModel;
        }
        public static Department ToEntityModel(this BusinessObject.Department department, Department existingDepartment = null)
        {
            Department convertedModel = existingDepartment != null ? existingDepartment : new Department();
            convertedModel.DepartmentId = string.IsNullOrEmpty(department.DepartmentId) ? Guid.NewGuid() : Guid.Parse(department.DepartmentId);
            convertedModel.DepartmentName = department.DepartmentName;
            convertedModel.IsActive = department.IsActive;
            convertedModel.CreatedBy = Guid.Parse(department.CreatedBy);
            convertedModel.CreatedOn = department.CreatedOn;
            convertedModel.ModifiedOn = department.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(department.ModifiedBy) ? null : Guid.Parse(department.CreatedBy);
            return convertedModel;
        }
        public static AboutU ToEntityModel(this BusinessObject.AboutU about, AboutU existingAbout = null)
        {
            AboutU convertedModel = existingAbout != null ? existingAbout : new AboutU();
            convertedModel.AboutUsId = string.IsNullOrEmpty(about.AboutUsId) ? Guid.NewGuid() : Guid.Parse(about.AboutUsId);
            convertedModel.AboutUsTitle = about.AboutUsTitle;
            convertedModel.AboutUsText = about.AboutUsText;
            convertedModel.IsActive = about.IsActive;
            convertedModel.CreatedBy = Guid.Parse(about.CreatedBy);
            convertedModel.CreatedOn = about.CreatedOn;
            convertedModel.ModifiedOn = about.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(about.ModifiedBy) ? null : Guid.Parse(about.CreatedBy);
            return convertedModel;
        }
        public static ContactU ToEntityModel(this BusinessObject.ContactU contact, ContactU existingContactUs = null)
        {
            ContactU convertedModel = existingContactUs != null ? existingContactUs : new ContactU();
            convertedModel.ContactUsId = string.IsNullOrEmpty(contact.ContactUsId) ? Guid.NewGuid() : Guid.Parse(contact.ContactUsId);
            convertedModel.ContactUsText = contact.ContactUsText;
            convertedModel.IsActive = contact.IsActive;
            convertedModel.CreatedBy = Guid.Parse(contact.CreatedBy);
            convertedModel.CreatedOn = contact.CreatedOn;
            convertedModel.ModifiedOn = contact.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(contact.ModifiedBy) ? null : Guid.Parse(contact.CreatedBy);
            return convertedModel;
        }
        public static Banner ToEntityModel(this BusinessObject.Banner banner, Banner existingBanner = null)
        {
            Banner convertedModel = existingBanner != null ? existingBanner : new Banner();
            convertedModel.BannerId = string.IsNullOrEmpty(banner.BannerId) ? Guid.NewGuid() : Guid.Parse(banner.BannerId);
            convertedModel.BannerName = banner.BannerName;
            convertedModel.IsActive = banner.IsActive;
            convertedModel.CreatedBy = Guid.Parse(banner.CreatedBy);
            convertedModel.CreatedOn = banner.CreatedOn;
            convertedModel.ModifiedOn = banner.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(banner.ModifiedBy) ? null : Guid.Parse(banner.CreatedBy);
            return convertedModel;
        }
        public static Barcode ToEntityModel(this BusinessObject.Barcode barcode, Barcode existingBarcode = null)
        {
            Barcode convertedModel = existingBarcode != null ? existingBarcode : new Barcode();
            convertedModel.BarcodeId = string.IsNullOrEmpty(barcode.BarcodeId) ? Guid.NewGuid() : Guid.Parse(barcode.BarcodeId);
            // convertedModel.Code = barcode.Code;
            convertedModel.IsActive = barcode.IsActive;
            convertedModel.CreatedBy = Guid.Parse(barcode.CreatedBy);
            convertedModel.CreatedOn = barcode.CreatedOn;
            convertedModel.ModifiedOn = barcode.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(barcode.ModifiedBy) ? null : Guid.Parse(barcode.CreatedBy);
            return convertedModel;
        }
        public static Batch ToEntityModel(this BusinessObject.Batch batch, Batch existingBatch = null)
        {
            Batch convertedModel = existingBatch != null ? existingBatch : new Batch();
            convertedModel.BatchId = string.IsNullOrEmpty(batch.BatchId) ? Guid.NewGuid() : Guid.Parse(batch.BatchId);
            convertedModel.BatchCode = batch.BatchCode;
            convertedModel.FromDate = batch.FromDate;
            convertedModel.ToDate = batch.ToDate;
            convertedModel.IsActive = batch.IsActive;
            convertedModel.CreatedBy = Guid.Parse(batch.CreatedBy);
            convertedModel.CreatedOn = batch.CreatedOn;
            convertedModel.ModifiedOn = batch.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(batch.ModifiedBy) ? null : Guid.Parse(batch.CreatedBy);
            return convertedModel;
        }
        public static EmployementType ToEntityModel(this BusinessObject.EmployementType employementType, EmployementType existingEmployementType = null)
        {
            EmployementType convertedModel = existingEmployementType != null ? existingEmployementType : new EmployementType();
            convertedModel.EmployementTypeId = string.IsNullOrEmpty(employementType.EmployementTypeId) ? Guid.NewGuid() : Guid.Parse(employementType.EmployementTypeId);
            convertedModel.EmployementTypeCode = employementType.EmployementTypeCode;
            convertedModel.EmployementTypeName = employementType.EmployementTypeName;
            convertedModel.IsActive = employementType.IsActive;
            convertedModel.CreatedBy = Guid.Parse(employementType.CreatedBy);
            convertedModel.CreatedOn = employementType.CreatedOn;
            convertedModel.ModifiedOn = employementType.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(employementType.ModifiedBy) ? null : Guid.Parse(employementType.CreatedBy);
            return convertedModel;
        }
        public static Gender ToEntityModel(this BusinessObject.Gender gender, Gender existingGender = null)
        {
            Gender convertedModel = existingGender != null ? existingGender : new Gender();
            convertedModel.GenderId = string.IsNullOrEmpty(gender.GenderId) ? Guid.NewGuid() : Guid.Parse(gender.GenderId);
            convertedModel.GenderCode = gender.GenderCode;
            convertedModel.GenderName = gender.GenderName;
            convertedModel.IsActive = gender.IsActive;
            convertedModel.CreatedBy = Guid.Parse(gender.CreatedBy);
            convertedModel.CreatedOn = gender.CreatedOn;
            convertedModel.ModifiedOn = gender.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(gender.ModifiedBy) ? null : Guid.Parse(gender.CreatedBy);
            return convertedModel;
        }
        public static IssueBookStudent ToEntityModel(this BusinessObject.IssueBookStudent issueBookStudent, IssueBookStudent existingIssueBookStudent = null)
        {
            IssueBookStudent convertedModel = existingIssueBookStudent != null ? existingIssueBookStudent : new IssueBookStudent();
            convertedModel.IssueBookStudentId = string.IsNullOrEmpty(issueBookStudent.IssueBookStudentId) ? Guid.NewGuid() : Guid.Parse(issueBookStudent.IssueBookStudentId);
            convertedModel.StudentId = Guid.Parse(issueBookStudent.StudentId);
            convertedModel.BookId = Guid.Parse(issueBookStudent.BookId);
            convertedModel.FromDate = issueBookStudent.FromDate;
            convertedModel.ToDate = issueBookStudent.ToDate;
            convertedModel.IsActive = issueBookStudent.IsActive;
            convertedModel.CreatedBy = Guid.Parse(issueBookStudent.CreatedBy);
            convertedModel.CreatedOn = issueBookStudent.CreatedOn;
            convertedModel.ModifiedOn = issueBookStudent.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(issueBookStudent.ModifiedBy) ? null : Guid.Parse(issueBookStudent.CreatedBy);
            return convertedModel;
        }
        public static MaritalStatus ToEntityModel(this BusinessObject.MaritalStatus maritalStatus, MaritalStatus existingMaritalStatus = null)
        {
            MaritalStatus convertedModel = existingMaritalStatus != null ? existingMaritalStatus : new MaritalStatus();
            convertedModel.MaritalStatusId = string.IsNullOrEmpty(maritalStatus.MaritalStatusId) ? Guid.NewGuid() : Guid.Parse(maritalStatus.MaritalStatusId);
            convertedModel.MaritalStatusCode = maritalStatus.MaritalStatusCode;
            convertedModel.MaritalStatusName = maritalStatus.MaritalStatusName;
            convertedModel.IsActive = maritalStatus.IsActive;
            convertedModel.CreatedBy = Guid.Parse(maritalStatus.CreatedBy);
            convertedModel.CreatedOn = maritalStatus.CreatedOn;
            convertedModel.ModifiedOn = maritalStatus.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(maritalStatus.ModifiedBy) ? null : Guid.Parse(maritalStatus.CreatedBy);
            return convertedModel;
        }
        public static PaymentStatus ToEntityModel(this BusinessObject.PaymentStatus paymentStatus, PaymentStatus existingPaymentStatus = null)
        {
            PaymentStatus convertedModel = existingPaymentStatus != null ? existingPaymentStatus : new PaymentStatus();
            convertedModel.PaymentStatusId = string.IsNullOrEmpty(paymentStatus.PaymentStatusId) ? Guid.NewGuid() : Guid.Parse(paymentStatus.PaymentStatusId);
            convertedModel.PaymentStatusName = paymentStatus.PaymentStatusName;
            convertedModel.IsActive = paymentStatus.IsActive;
            convertedModel.CreatedBy = Guid.Parse(paymentStatus.CreatedBy);
            convertedModel.CreatedOn = paymentStatus.CreatedOn;
            convertedModel.ModifiedOn = paymentStatus.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(paymentStatus.ModifiedBy) ? null : Guid.Parse(paymentStatus.CreatedBy);
            return convertedModel;
        }
        public static SocialCategory ToEntityModel(this BusinessObject.SocialCategory socialCateogory, SocialCategory existingSocialCateogory = null)
        {
            SocialCategory convertedModel = existingSocialCateogory != null ? existingSocialCateogory : new SocialCategory();
            convertedModel.SocialCategoryId = string.IsNullOrEmpty(socialCateogory.SocialCategoryId) ? Guid.NewGuid() : Guid.Parse(socialCateogory.SocialCategoryId);
            convertedModel.SocialCategoryCode = socialCateogory.SocialCategoryCode;
            convertedModel.SocialCategoryName = socialCateogory.SocialCategoryName;
            convertedModel.IsActive = socialCateogory.IsActive;
            convertedModel.CreatedBy = Guid.Parse(socialCateogory.CreatedBy);
            convertedModel.CreatedOn = socialCateogory.CreatedOn;
            convertedModel.ModifiedOn = socialCateogory.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(socialCateogory.ModifiedBy) ? null : Guid.Parse(socialCateogory.CreatedBy);
            return convertedModel;
        }
        public static StudentCategory ToEntityModel(this BusinessObject.StudentCategory studentCateogory, StudentCategory existingStudentCateogory = null)
        {
            StudentCategory convertedModel = existingStudentCateogory != null ? existingStudentCateogory : new StudentCategory();
            convertedModel.StudentCategoryId = string.IsNullOrEmpty(studentCateogory.StudentCategoryId) ? Guid.NewGuid() : Guid.Parse(studentCateogory.StudentCategoryId);
            convertedModel.StudentCategoryName = studentCateogory.StudentCategoryName;
            convertedModel.IsActive = studentCateogory.IsActive;
            convertedModel.CreatedBy = Guid.Parse(studentCateogory.CreatedBy);
            convertedModel.CreatedOn = studentCateogory.CreatedOn;
            convertedModel.ModifiedOn = studentCateogory.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(studentCateogory.ModifiedBy) ? null : Guid.Parse(studentCateogory.CreatedBy);
            return convertedModel;
        }
        public static StudentSeatBooking ToEntityModel(this BusinessObject.StudentSeatBooking studentSeatBooking, StudentSeatBooking existingStudentSeatBooking = null)
        {
            StudentSeatBooking convertedModel = existingStudentSeatBooking != null ? existingStudentSeatBooking : new StudentSeatBooking();
            convertedModel.StudentSeatBookingId = string.IsNullOrEmpty(studentSeatBooking.StudentSeatBookingId) ? Guid.NewGuid() : Guid.Parse(studentSeatBooking.StudentSeatBookingId);
            convertedModel.StudentId = Guid.Parse(studentSeatBooking.StudentId);
            convertedModel.SeatNo = studentSeatBooking.SeatNo;
            convertedModel.TokenNo = studentSeatBooking.TokenNo;
            convertedModel.FromDate = studentSeatBooking.FromDate;
            convertedModel.ToDate = studentSeatBooking.ToDate;
            convertedModel.IsActive = studentSeatBooking.IsActive;
            convertedModel.CreatedBy = Guid.Parse(studentSeatBooking.CreatedBy);
            convertedModel.CreatedOn = studentSeatBooking.CreatedOn;
            convertedModel.ModifiedOn = studentSeatBooking.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(studentSeatBooking.ModifiedBy) ? null : Guid.Parse(studentSeatBooking.CreatedBy);
            return convertedModel;
        }
        public static StudentSubType ToEntityModel(this BusinessObject.StudentSubType studentSubType, StudentSubType existingStudentSubType = null)
        {
            StudentSubType convertedModel = existingStudentSubType != null ? existingStudentSubType : new StudentSubType();
            convertedModel.StudentSubTypeId = string.IsNullOrEmpty(studentSubType.StudentSubTypeId) ? Guid.NewGuid() : Guid.Parse(studentSubType.StudentSubTypeId);
            convertedModel.StudentSubTypeName = studentSubType.StudentSubTypeName;
            convertedModel.DiscountPer = studentSubType.DiscountPer;
            convertedModel.IsActive = studentSubType.IsActive;
            convertedModel.CreatedBy = Guid.Parse(studentSubType.CreatedBy);
            convertedModel.CreatedOn = studentSubType.CreatedOn;
            convertedModel.ModifiedOn = studentSubType.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(studentSubType.ModifiedBy) ? null : Guid.Parse(studentSubType.CreatedBy);
            return convertedModel;
        }
        public static SubscriptionPackage ToEntityModel(this BusinessObject.SubscriptionPackage pakage, SubscriptionPackage existingSubscriptionPakage = null)
        {
            SubscriptionPackage convertedModel = existingSubscriptionPakage != null ? existingSubscriptionPakage : new SubscriptionPackage();
            convertedModel.SubscriptionPackageId = string.IsNullOrEmpty(pakage.SubscriptionPackageId) ? Guid.NewGuid() : Guid.Parse(pakage.SubscriptionPackageId);
            convertedModel.SubscriptionPackageName = pakage.SubscriptionPackageName;
            convertedModel.SubscriptionPeriodMonths = pakage.SubscriptionPeriodMonths;
            convertedModel.PriceMonth = pakage.PriceMonth;
            convertedModel.DiscountPer = pakage.DiscountPer;
            convertedModel.Decription = pakage.Decription;
            convertedModel.IsActive = pakage.IsActive;
            convertedModel.CreatedBy = Guid.Parse(pakage.CreatedBy);
            convertedModel.CreatedOn = pakage.CreatedOn;
            convertedModel.ModifiedOn = pakage.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(pakage.ModifiedBy) ? null : Guid.Parse(pakage.CreatedBy);
            return convertedModel;
        }
        public static SubscriptionPayment ToEntityModel(this BusinessObject.SubscriptionPayment payment, SubscriptionPayment existingPayment = null)
        {
            SubscriptionPayment convertedModel = existingPayment != null ? existingPayment : new SubscriptionPayment();
            convertedModel.PaymentId = string.IsNullOrEmpty(payment.PaymentId) ? Guid.NewGuid() : Guid.Parse(payment.PaymentId);
            convertedModel.ReceiptNo = payment.ReceiptNo;
            convertedModel.StudentTeacher = payment.StudentTeacher;
            convertedModel.StudentTeacherId = Guid.Parse(payment.StudentTeacherId);
            convertedModel.SubscriptionPakageId = Guid.Parse(payment.SubscriptionPakageId);
            convertedModel.Rate = payment.Rate;
            convertedModel.Months = payment.Months;
            convertedModel.DiscountPer = payment.DiscountPer;
            convertedModel.PaymentStatus = Guid.Parse(payment.PaymentStatus);
            convertedModel.IsActive = payment.IsActive;
            convertedModel.CreatedBy = Guid.Parse(payment.CreatedBy);
            convertedModel.CreatedOn = payment.CreatedOn;
            convertedModel.ModifiedOn = payment.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(payment.ModifiedBy) ? null : Guid.Parse(payment.CreatedBy);
            return convertedModel;
        }
        public static SubscriptionsTransaction ToEntityModel(this BusinessObject.SubscriptionsTransaction transaction, SubscriptionsTransaction existingTransaction = null)
        {
            SubscriptionsTransaction convertedModel = existingTransaction != null ? existingTransaction : new SubscriptionsTransaction();
            convertedModel.SubscriptionsTransactionStudentId = string.IsNullOrEmpty(transaction.SubscriptionsTransactionStudentId) ? Guid.NewGuid() : Guid.Parse(transaction.SubscriptionsTransactionStudentId);
            convertedModel.StudentTeacher = transaction.StudentTeacherId;
            convertedModel.StudentTeacherId = Guid.Parse(transaction.StudentTeacherId);
            convertedModel.SubscriptionPakageId = Guid.Parse(transaction.SubscriptionPakageId);
            convertedModel.PaymentId = Guid.Parse(transaction.PaymentId);
            convertedModel.ValidFrom = transaction.ValidFrom;
            convertedModel.ValidTo = transaction.ValidTo;
            convertedModel.IsActive = transaction.IsActive;
            convertedModel.CreatedBy = Guid.Parse(transaction.CreatedBy);
            convertedModel.CreatedOn = transaction.CreatedOn;
            convertedModel.ModifiedOn = transaction.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(transaction.ModifiedBy) ? null : Guid.Parse(transaction.CreatedBy);
            return convertedModel;
        }
        public static Staff ToEntityModel(this BusinessObject.Staff staff, Staff existingStaff = null)
        {
            Staff convertedModel = existingStaff != null ? existingStaff : new Staff();

            convertedModel.StaffId = string.IsNullOrEmpty(staff.StaffId) ? Guid.NewGuid() : Guid.Parse(staff.StaffId);
            convertedModel.TitleId = string.IsNullOrEmpty(staff.TitleId) ? null : Guid.Parse(staff.TitleId);
            convertedModel.FirstName = staff.FirstName ?? string.Empty;
            convertedModel.MiddleName = staff.MiddleName ?? string.Empty;
            convertedModel.LastName = staff.LastName ?? string.Empty;
            convertedModel.DoJ = staff.DoJ;
            convertedModel.GenderId = Guid.Parse(staff.GenderId);
            convertedModel.DoB = staff.DoB;
            convertedModel.DepartmentId = string.IsNullOrEmpty(staff.DepartmentId) ? null : Guid.Parse(staff.DepartmentId);
            convertedModel.DesignationId = string.IsNullOrEmpty(staff.DesignationId) ? null : Guid.Parse(staff.DesignationId);
            convertedModel.RoleId = string.IsNullOrEmpty(staff.RoleId) ? null : Guid.Parse(staff.RoleId);
            convertedModel.SalaryOffered = staff.SalaryOffered ?? 0;
            convertedModel.Qualification = staff.Qualification ?? string.Empty;
            convertedModel.Experience = staff.Experience ?? string.Empty;
            convertedModel.AreaOfSpecialization = staff.AreaOfSpecialization ?? string.Empty;
            convertedModel.BiometricIdentificationNumberId = staff.BiometricIdentificationNumberId ?? string.Empty;
            convertedModel.DateOfSuperannuation = staff.DateOfSuperannuation;
            convertedModel.DateOfRegularAppointment = staff.DateOfRegularAppointment;
            convertedModel.SocialCategoryId = string.IsNullOrEmpty(staff.SocialCategoryId) ? null : Guid.Parse(staff.SocialCategoryId);
            convertedModel.Caste = staff.Caste ?? string.Empty;
            convertedModel.LibraryCardNumber = staff.LibraryCardNumber ?? string.Empty;
            convertedModel.ProfilePicture = staff.ProfilePicture ?? string.Empty;
            convertedModel.AadharCardNo = staff.AadharCardNo ?? 0;
            convertedModel.MaritalStatusId = string.IsNullOrEmpty(staff.MaritalStatusId) ? null : Guid.Parse(staff.MaritalStatusId);
            convertedModel.MarriageAnniversary = staff.MarriageAnniversary ?? null;
            convertedModel.SpouseName = staff.SpouseName ?? string.Empty;
            convertedModel.PanCardNo = staff.PanCardNo ?? string.Empty;
            convertedModel.FatherName = staff.FatherName ?? string.Empty;
            convertedModel.MotherName = staff?.MotherName ?? string.Empty;
            convertedModel.BloodGroupId = string.IsNullOrEmpty(staff.BloodGroupId) ? null : Guid.Parse(staff.BloodGroupId);
            convertedModel.Nationality = string.IsNullOrEmpty(staff.Nationality) ? null : Guid.Parse(staff.Nationality);
            convertedModel.EmployementTypeId = string.IsNullOrEmpty(staff.EmployementTypeId) ? null : Guid.Parse(staff.EmployementTypeId);
            convertedModel.OnlyViewingrights = staff.OnlyViewingrights ?? false;
            convertedModel.Uannumber = staff.Uannumber ?? 0;
            convertedModel.ShiftInTime = staff.ShiftInTime ?? string.Empty;
            convertedModel.ShiftOutTime = staff.ShiftOutTime ?? string.Empty;
            convertedModel.BankName = staff.BankName ?? string.Empty;
            convertedModel.IfscCode = staff.IfscCode ?? string.Empty;
            convertedModel.AccountNumber = staff.AccountNumber ?? 0;
            convertedModel.Mobile = staff.Mobile ?? 0;
            convertedModel.EmailId = staff.EmailId ?? string.Empty;
            convertedModel.AlternateEmailId = staff.AlternateEmailId ?? string.Empty;
            convertedModel.LinkedInProfile = staff.LinkedInProfile ?? string.Empty;
            convertedModel.PermanentAddress1 = staff.PermanentAddress1 ?? string.Empty;
            convertedModel.PermanentAddress2 = staff.PermanentAddress2 ?? string.Empty;
            convertedModel.PermanentCountryId = string.IsNullOrEmpty(staff.PermanentCountryId) ? null : Guid.Parse(staff.PermanentCountryId);
            convertedModel.PermanentStateId = string.IsNullOrEmpty(staff.PermanentStateId) ? null : Guid.Parse(staff.PermanentStateId);
            convertedModel.PermanentCityId = string.IsNullOrEmpty(staff.PermanentCityId) ? null : Guid.Parse(staff.PermanentCityId);
            convertedModel.PermanentPincode = staff.PermanentPincode ?? 0;
            convertedModel.PresentAddress1 = staff.PresentAddress1 ?? string.Empty;
            convertedModel.PresentAddress2 = staff.PresentAddress2 ?? string.Empty;
            convertedModel.PresentCountryId = string.IsNullOrEmpty(staff.PermanentCityId) ? null : Guid.Parse(staff.PermanentCityId);
            convertedModel.PresentStateId = string.IsNullOrEmpty(staff.PresentStateId) ? null : Guid.Parse(staff.PresentStateId);
            convertedModel.PresentCityId = string.IsNullOrEmpty(staff.PresentCityId) ? null : Guid.Parse(staff.PresentCityId);
            convertedModel.PresentPincode = staff.PresentPincode ?? 0;
            convertedModel.IsActive = staff.IsActive;
            convertedModel.CreatedOn = staff.CreatedOn;
            convertedModel.CreatedBy = Guid.Parse(staff.CreatedBy);
            convertedModel.ModifiedOn = staff.ModifiedOn == null ? DateTime.Now : staff.ModifiedOn;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(staff.ModifiedBy) ? null : Guid.Parse(staff.ModifiedBy);
            convertedModel.BuildingId = string.IsNullOrEmpty(staff.BuildingId) ? null : Guid.Parse(staff.BuildingId);
            convertedModel.Password = staff.Password ?? "";

            return convertedModel;
        }
    }
}
