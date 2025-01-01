using LMS.Infrastructures.Models;
using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.ConversionHelper
{
    public static class BusinessObjectConversionHelper
    {
        public static BusinessObject.StaffType ToBusinessObject(this LMS.Infrastructures.Models.StaffType staffType)
        {
            return new BusinessObject.StaffType
            {
                StaffTypeId = staffType.StaffTypeId == null ? string.Empty : Convert.ToString(staffType.StaffTypeId),
                StaffTypeName = staffType.StaffTypeName,
                IsActive = staffType.IsActive,
                CreatedOn = staffType.CreatedOn,
                CreatedBy = staffType.CreatedBy.ToString(),
                ModifiedOn = staffType.ModifiedOn.Equals(null) ? null : staffType.ModifiedOn,
                ModifiedBy = staffType.ModifiedBy.Equals(null) ? null : staffType.ModifiedBy.ToString()
            };
        }
        public static BusinessObject.LoginType ToBusinessObject(this LMS.Infrastructures.Models.LoginType loginType)
        {
            return new BusinessObject.LoginType
            {
                LoginTypeId = loginType.LoginTypeId == null ? string.Empty : Convert.ToString(loginType.LoginTypeId),
                LoginTypeName = loginType.LoginTypeName,
                LoginTypeKey = loginType.LoginTypeKey,
                IsActive = loginType.IsActive,
                CreatedOn = loginType.CreatedOn,
                CreatedBy = loginType.CreatedBy.ToString(),
                ModifiedOn = loginType.ModifiedOn.Equals(null) ? null : loginType.ModifiedOn,
                ModifiedBy = loginType.ModifiedBy.Equals(null) ? null : loginType.ModifiedBy.ToString()
            };
        }
        public static BusinessObject.Domain ToBusinessObject(this LMS.Infrastructures.Models.Domain domain)
        {
            return new BusinessObject.Domain
            {
                DomainId = domain.DomainId == null ? string.Empty : Convert.ToString(domain.DomainId),
                RegisteredName = domain.RegisteredName,
                Address1 = domain.Address1,
                Address2 = domain.Address2,
                CountryId = Convert.ToString(domain.CountryId),
                StateId = Convert.ToString(domain.StateId),
                CityId = Convert.ToString(domain.CityId),
                ContactPerson = domain.ContactPerson,
                ContactNo = domain.ContactNo,
                ContactEmail = domain.ContactEmail,
                IsActive = domain.IsActive,
                CreatedBy = domain.CreatedBy.ToString(),
            };
        }
        public static BusinessObject.Building ToBusinessObject(this LMS.Infrastructures.Models.Building building)
        {
            return new BusinessObject.Building
            {
                DomainId = building.DomainId == null ? string.Empty : Convert.ToString(building.DomainId),
                BuildingId = building.BuildingId == null ? string.Empty : Convert.ToString(building.BuildingId),
                BuildingName = building.BuildingName,
                Address1 = building.Address1,
                Address2 = building.Address2,
                CountryId = Convert.ToString(building.CountryId),
                StateId = Convert.ToString(building.StateId),
                CityId = Convert.ToString(building.CityId),
                ContactPerson = building.ContactPerson,
                ContactNo = building.ContactNo,
                ContactEmail = building.ContactEmail,
            };
        }
        public static BusinessObject.Department ToBusinessObject(this LMS.Infrastructures.Models.Department department)
        {
            return new BusinessObject.Department
            {
                DepartmentId = department.DepartmentId == null ? string.Empty : Convert.ToString(department.DepartmentId),
                DepartmentName = department.DepartmentName,
                IsActive = department.IsActive,
                CreatedOn = department.CreatedOn,
                CreatedBy = Convert.ToString(department.CreatedBy),
                ModifiedOn = department.ModifiedOn,
                ModifiedBy = Convert.ToString(department.ModifiedBy),
            };
        }
        public static BusinessObject.AboutU ToBusinessObject(this LMS.Infrastructures.Models.AboutU about)
        {
            return new BusinessObject.AboutU
            {
                AboutUsId = about.AboutUsId == null ? string.Empty : Convert.ToString(about.AboutUsId),
                AboutUsTitle = about.AboutUsTitle,
                AboutUsText = about.AboutUsText,
                IsActive = about.IsActive,
                CreatedOn = about.CreatedOn,
                CreatedBy = Convert.ToString(about.CreatedBy),
                ModifiedOn = about.ModifiedOn,
                ModifiedBy = Convert.ToString(about.ModifiedBy),
            };
        }
        public static BusinessObject.ContactU ToBusinessObject(this LMS.Infrastructures.Models.ContactU contact)
        {
            return new BusinessObject.ContactU
            {
                ContactUsId = contact.ContactUsId == null ? string.Empty : Convert.ToString(contact.ContactUsId),
                ContactUsText = contact.ContactUsText,
                IsActive = contact.IsActive,
                CreatedOn = contact.CreatedOn,
                CreatedBy = Convert.ToString(contact.CreatedBy),
                ModifiedOn = contact.ModifiedOn,
                ModifiedBy = Convert.ToString(contact.ModifiedBy),
            };
        }
        public static BusinessObject.Banner ToBusinessObject(this LMS.Infrastructures.Models.Banner banner)
        {
            return new BusinessObject.Banner
            {
                BannerId = banner.BannerId == null ? string.Empty : Convert.ToString(banner.BannerId),
                BannerName = banner.BannerName,
                IsActive = banner.IsActive,
                CreatedOn = banner.CreatedOn,
                CreatedBy = Convert.ToString(banner.CreatedBy),
                ModifiedOn = banner.ModifiedOn,
                ModifiedBy = Convert.ToString(banner.ModifiedBy),
            };
        }
        public static BusinessObject.Barcode ToBusinessObject(this LMS.Infrastructures.Models.Barcode barcode)
        {
            return new BusinessObject.Barcode
            {
                BarcodeId = barcode.BarcodeId == null ? string.Empty : Convert.ToString(barcode.BarcodeId),
                // Code = Convert.ToByte(barcode.Code),
                IsActive = barcode.IsActive,
                CreatedOn = barcode.CreatedOn,
                CreatedBy = Convert.ToString(barcode.CreatedBy),
                ModifiedOn = barcode.ModifiedOn,
                ModifiedBy = Convert.ToString(barcode.ModifiedBy),
            };
        }
        public static BusinessObject.Batch ToBusinessObject(this LMS.Infrastructures.Models.Batch batch)
        {
            return new BusinessObject.Batch
            {
                BatchId = batch.BatchId == null ? string.Empty : Convert.ToString(batch.BatchId),
                BatchCode = batch.BatchCode,
                FromDate = batch.FromDate,
                ToDate = batch.ToDate,
                IsActive = batch.IsActive,
                CreatedOn = batch.CreatedOn,
                CreatedBy = Convert.ToString(batch.CreatedBy),
                ModifiedOn = batch.ModifiedOn,
                ModifiedBy = Convert.ToString(batch.ModifiedBy),
            };
        }
        public static BusinessObject.EmployementType ToBusinessObject(this LMS.Infrastructures.Models.EmployementType employementType)
        {
            return new BusinessObject.EmployementType
            {
                EmployementTypeId = employementType.EmployementTypeId == null ? string.Empty : Convert.ToString(employementType.EmployementTypeId),
                EmployementTypeCode = employementType.EmployementTypeCode,
                EmployementTypeName = employementType.EmployementTypeName,
                IsActive = employementType.IsActive,
                CreatedOn = employementType.CreatedOn,
                CreatedBy = Convert.ToString(employementType.CreatedBy),
                ModifiedOn = employementType.ModifiedOn,
                ModifiedBy = Convert.ToString(employementType.ModifiedBy),
            };
        }
        public static BusinessObject.Gender ToBusinessObject(this LMS.Infrastructures.Models.Gender gender)
        {
            return new BusinessObject.Gender
            {
                GenderId = gender.GenderId == null ? string.Empty : Convert.ToString(gender.GenderId),
                GenderCode = gender.GenderCode,
                GenderName = gender.GenderName,
                IsActive = gender.IsActive,
                CreatedOn = gender.CreatedOn,
                CreatedBy = Convert.ToString(gender.CreatedBy),
                ModifiedOn = gender.ModifiedOn,
                ModifiedBy = Convert.ToString(gender.ModifiedBy),
            };
        }
        public static BusinessObject.IssueBookStudent ToBusinessObject(this LMS.Infrastructures.Models.IssueBookStudent issueBookStudent)
        {
            return new BusinessObject.IssueBookStudent
            {
                IssueBookStudentId = issueBookStudent.IssueBookStudentId == null ? string.Empty : Convert.ToString(issueBookStudent.IssueBookStudentId),
                BookId = Convert.ToString(issueBookStudent.BookId),
                StudentId = Convert.ToString(issueBookStudent.StudentId),
                FromDate = issueBookStudent.FromDate,
                ToDate = issueBookStudent.ToDate,
                IsActive = issueBookStudent.IsActive,
                CreatedOn = issueBookStudent.CreatedOn,
                CreatedBy = Convert.ToString(issueBookStudent.CreatedBy),
                ModifiedOn = issueBookStudent.ModifiedOn,
                ModifiedBy = Convert.ToString(issueBookStudent.ModifiedBy),
                Book = issueBookStudent.Book,
                Student = issueBookStudent.Student,
            };
        }
        public static BusinessObject.MaritalStatus ToBusinessObject(this LMS.Infrastructures.Models.MaritalStatus maritalStatus)
        {
            return new BusinessObject.MaritalStatus
            {
                MaritalStatusId = maritalStatus.MaritalStatusId == null ? string.Empty : Convert.ToString(maritalStatus.MaritalStatusId),
                MaritalStatusCode = maritalStatus.MaritalStatusCode,
                MaritalStatusName = Convert.ToString(maritalStatus.MaritalStatusName),
                IsActive = maritalStatus.IsActive,
                CreatedOn = maritalStatus.CreatedOn,
                CreatedBy = Convert.ToString(maritalStatus.CreatedBy),
                ModifiedOn = maritalStatus.ModifiedOn,
                ModifiedBy = Convert.ToString(maritalStatus.ModifiedBy),
            };
        }
        public static BusinessObject.PaymentStatus ToBusinessObject(this LMS.Infrastructures.Models.PaymentStatus paymentStatus)
        {
            return new BusinessObject.PaymentStatus
            {
                PaymentStatusId = paymentStatus.PaymentStatusId == null ? string.Empty : Convert.ToString(paymentStatus.PaymentStatusId),
                PaymentStatusName = paymentStatus.PaymentStatusName,
                IsActive = paymentStatus.IsActive,
                CreatedOn = paymentStatus.CreatedOn,
                CreatedBy = Convert.ToString(paymentStatus.CreatedBy),
                ModifiedOn = paymentStatus.ModifiedOn,
                ModifiedBy = Convert.ToString(paymentStatus.ModifiedBy),
            };
        }
        public static BusinessObject.SocialCategory ToBusinessObject(this LMS.Infrastructures.Models.SocialCategory socialCateogory)
        {
            return new BusinessObject.SocialCategory
            {
                SocialCategoryId = socialCateogory.SocialCategoryId == null ? string.Empty : Convert.ToString(socialCateogory.SocialCategoryId),
                SocialCategoryCode = socialCateogory.SocialCategoryCode,
                SocialCategoryName = socialCateogory.SocialCategoryName,
                IsActive = socialCateogory.IsActive,
                CreatedOn = socialCateogory.CreatedOn,
                CreatedBy = Convert.ToString(socialCateogory.CreatedBy),
                ModifiedOn = socialCateogory.ModifiedOn,
                ModifiedBy = Convert.ToString(socialCateogory.ModifiedBy),
            };
        }
        public static BusinessObject.StudentCategory ToBusinessObject(this LMS.Infrastructures.Models.StudentCategory studentCateogory)
        {
            return new BusinessObject.StudentCategory
            {
                StudentCategoryId = studentCateogory.StudentCategoryId == null ? string.Empty : Convert.ToString(studentCateogory.StudentCategoryId),
                StudentCategoryName = studentCateogory.StudentCategoryName,
                DiscountPer = studentCateogory.DiscountPer,
                IsActive = studentCateogory.IsActive,
                CreatedOn = studentCateogory.CreatedOn,
                CreatedBy = Convert.ToString(studentCateogory.CreatedBy),
                ModifiedOn = studentCateogory.ModifiedOn,
                ModifiedBy = Convert.ToString(studentCateogory.ModifiedBy),
            };
        }
        public static BusinessObject.StudentSeatBooking ToBusinessObject(this LMS.Infrastructures.Models.StudentSeatBooking studentSeatBooking)
        {
            return new BusinessObject.StudentSeatBooking
            {
                StudentSeatBookingId = studentSeatBooking.StudentSeatBookingId == null ? string.Empty : Convert.ToString(studentSeatBooking.StudentSeatBookingId),
                StudentId = Convert.ToString(studentSeatBooking.StudentId),
                SeatNo = studentSeatBooking.SeatNo,
                TokenNo = studentSeatBooking.TokenNo,
                FromDate = studentSeatBooking.FromDate,
                ToDate = studentSeatBooking.ToDate,
                IsActive = studentSeatBooking.IsActive,
                CreatedOn = studentSeatBooking.CreatedOn,
                CreatedBy = Convert.ToString(studentSeatBooking.CreatedBy),
                ModifiedOn = studentSeatBooking.ModifiedOn,
                ModifiedBy = Convert.ToString(studentSeatBooking.ModifiedBy),
                Student = studentSeatBooking.Student,
            };
        }
        public static BusinessObject.StudentSubType ToBusinessObject(this LMS.Infrastructures.Models.StudentSubType studentSubType)
        {
            return new BusinessObject.StudentSubType
            {
                StudentSubTypeId = studentSubType.StudentSubTypeId == null ? string.Empty : Convert.ToString(studentSubType.StudentSubTypeId),
                StudentSubTypeName = Convert.ToString(studentSubType.StudentSubTypeName),
                DiscountPer = studentSubType.DiscountPer,
                IsActive = studentSubType.IsActive,
                CreatedOn = studentSubType.CreatedOn,
                CreatedBy = Convert.ToString(studentSubType.CreatedBy),
                ModifiedOn = studentSubType.ModifiedOn,
                ModifiedBy = Convert.ToString(studentSubType.ModifiedBy),
            };
        }
        public static BusinessObject.SubscriptionPackage ToBusinessObject(this LMS.Infrastructures.Models.SubscriptionPackage subscriptionPackage)
        {
            return new BusinessObject.SubscriptionPackage
            {
                SubscriptionPackageId = subscriptionPackage.SubscriptionPackageId == null ? string.Empty : Convert.ToString(subscriptionPackage.SubscriptionPackageId),
                SubscriptionPackageName = Convert.ToString(subscriptionPackage.SubscriptionPackageName),
                SubscriptionPeriodMonths = subscriptionPackage.SubscriptionPeriodMonths,
                PriceMonth = subscriptionPackage.PriceMonth,
                DiscountPer = subscriptionPackage.DiscountPer,
                Decription = subscriptionPackage.Decription,
                IsActive = subscriptionPackage.IsActive,
                CreatedOn = subscriptionPackage.CreatedOn,
                CreatedBy = Convert.ToString(subscriptionPackage.CreatedBy),
                ModifiedOn = subscriptionPackage.ModifiedOn,
                ModifiedBy = Convert.ToString(subscriptionPackage.ModifiedBy),
                //SubscriptionsTransactions = subscriptionPackage.SubscriptionsTransactions,
            };
        }
        public static BusinessObject.SubscriptionPayment ToBusinessObject(this LMS.Infrastructures.Models.SubscriptionPayment subscriptionPayment)
        {
            return new BusinessObject.SubscriptionPayment
            {
                PaymentId = subscriptionPayment.SubscriptionPakageId == null ? string.Empty : Convert.ToString(subscriptionPayment.SubscriptionPakageId),
                ReceiptNo = Convert.ToString(subscriptionPayment.ReceiptNo),
                StudentTeacher = subscriptionPayment.StudentTeacher,
                StudentTeacherId = Convert.ToString(subscriptionPayment.StudentTeacherId),
                SubscriptionPakageId = Convert.ToString(subscriptionPayment.SubscriptionPakageId),
                Rate = subscriptionPayment.Rate,
                Months = subscriptionPayment.Months,
                DiscountPer = subscriptionPayment.DiscountPer,
                PaymentStatus = Convert.ToString(subscriptionPayment.PaymentStatus),
                IsActive = subscriptionPayment.IsActive,
                CreatedOn = subscriptionPayment.CreatedOn,
                CreatedBy = Convert.ToString(subscriptionPayment.CreatedBy),
                ModifiedOn = subscriptionPayment.ModifiedOn,
                ModifiedBy = Convert.ToString(subscriptionPayment.ModifiedBy),
                //PaymentStatusNavigation = subscriptionPayment.PaymentStatusNavigation,
                //SubscriptionsTransactions = subscriptionPayment.SubscriptionsTransactions,
            };
        }
        public static BusinessObject.SubscriptionsTransaction ToBusinessObject(this LMS.Infrastructures.Models.SubscriptionsTransaction subscriptionsTransaction)
        {
            return new BusinessObject.SubscriptionsTransaction
            {
                SubscriptionsTransactionStudentId = subscriptionsTransaction.SubscriptionsTransactionStudentId == null ? string.Empty : Convert.ToString(subscriptionsTransaction.SubscriptionsTransactionStudentId),
                StudentTeacher = subscriptionsTransaction.StudentTeacher,
                StudentTeacherId = Convert.ToString(subscriptionsTransaction.StudentTeacherId),
                SubscriptionPakageId = Convert.ToString(subscriptionsTransaction.SubscriptionPakageId),
                PaymentId = Convert.ToString(subscriptionsTransaction.PaymentId),
                ValidFrom = subscriptionsTransaction.ValidFrom,
                ValidTo = subscriptionsTransaction.ValidTo,
                IsActive = subscriptionsTransaction.IsActive,
                CreatedOn = subscriptionsTransaction.CreatedOn,
                CreatedBy = Convert.ToString(subscriptionsTransaction.CreatedBy),
                ModifiedOn = subscriptionsTransaction.ModifiedOn,
                ModifiedBy = Convert.ToString(subscriptionsTransaction.ModifiedBy),
                //Payment = subscriptionsTransaction.Payment,
            };
        }
        public static BusinessObject.Staff ToBusinessObject(this LMS.Infrastructures.Models.Staff staff)
        {
            return new BusinessObject.Staff
            {
                StaffId = staff.StaffId == null ? string.Empty : Convert.ToString(staff.StaffId),
                TitleId = staff.TitleId == null ? string.Empty : Convert.ToString(staff.TitleId),
                FirstName = staff.FirstName,
                MiddleName = staff.MiddleName,
                LastName = staff.LastName,
                DoJ = staff.DoJ,
                GenderId = staff.GenderId == null ? string.Empty : Convert.ToString(staff.GenderId),
                DoB = staff.DoB,
                DepartmentId = staff.DepartmentId == null ? string.Empty : Convert.ToString(staff.DepartmentId),
                DesignationId = staff.DesignationId == null ? string.Empty : Convert.ToString(staff.DesignationId),
                RoleId = staff.RoleId == null ? string.Empty : Convert.ToString(staff.RoleId),
                SalaryOffered = staff.SalaryOffered ?? 0,
                Qualification = staff.Qualification ?? string.Empty,
                Experience = staff.Experience ?? string.Empty,
                AreaOfSpecialization = staff.AreaOfSpecialization ?? string.Empty,
                BiometricIdentificationNumberId = staff.BiometricIdentificationNumberId ?? string.Empty,
                DateOfSuperannuation = staff.DateOfSuperannuation,
                DateOfRegularAppointment = staff.DateOfRegularAppointment,
                SocialCategoryId = staff.SocialCategoryId == null ? string.Empty : Convert.ToString(staff.SocialCategoryId),
                Caste = staff.Caste ?? string.Empty,
                LibraryCardNumber = staff.LibraryCardNumber ?? string.Empty,
                ProfilePicture = staff.ProfilePicture ?? string.Empty,
                AadharCardNo = staff.AadharCardNo ?? 0,
                MaritalStatusId = staff.MaritalStatusId == null ? string.Empty : Convert.ToString(staff.MaritalStatusId),
                MarriageAnniversary = staff.MarriageAnniversary ?? null,
                SpouseName = staff.SpouseName ?? string.Empty,
                PanCardNo = staff.PanCardNo ?? string.Empty,
                FatherName = staff.FatherName ?? string.Empty,
                MotherName = staff?.MotherName ?? string.Empty,
                BloodGroupId = staff.BloodGroupId == null ? string.Empty : Convert.ToString(staff.BloodGroupId),
                Nationality = staff.Nationality == null ? string.Empty : Convert.ToString(staff.Nationality),
                EmployementTypeId = staff.EmployementTypeId == null ? string.Empty : Convert.ToString(staff.EmployementTypeId),
                OnlyViewingrights = staff.OnlyViewingrights ?? false,
                Uannumber = staff.Uannumber ?? 0,
                ShiftInTime = staff.ShiftInTime ?? string.Empty,
                ShiftOutTime = staff.ShiftOutTime ?? string.Empty,
                BankName = staff.BankName ?? string.Empty,
                IfscCode = staff.IfscCode ?? string.Empty,
                AccountNumber = staff.AccountNumber ?? 0,
                Mobile = staff.Mobile ?? 0,
                EmailId = staff.EmailId ?? string.Empty,
                AlternateEmailId = staff.AlternateEmailId ?? string.Empty,
                LinkedInProfile = staff.LinkedInProfile ?? string.Empty,
                PermanentAddress1 = staff.PermanentAddress1 ?? string.Empty,
                PermanentAddress2 = staff.PermanentAddress2 ?? string.Empty,
                PermanentCountryId = staff.PermanentCountryId == null ? string.Empty : Convert.ToString(staff.PermanentCountryId),
                PermanentStateId = staff.PermanentStateId == null ? string.Empty : Convert.ToString(staff.PermanentStateId),
                PermanentCityId = staff.PermanentCityId == null ? string.Empty : Convert.ToString(staff.PermanentCityId),
                PermanentPincode = staff.PermanentPincode ?? 0,
                PresentAddress1 = staff.PresentAddress1 ?? string.Empty,
                PresentAddress2 = staff.PresentAddress2 ?? string.Empty,
                PresentCountryId = staff.PermanentCityId == null ? string.Empty : Convert.ToString(staff.PermanentCityId),
                PresentStateId = staff.PresentStateId == null ? string.Empty : Convert.ToString(staff.PresentStateId),
                PresentCityId = staff.PresentCityId == null ? string.Empty : Convert.ToString(staff.PresentCityId),
                PresentPincode = staff.PresentPincode ?? 0,
                IsActive = staff.IsActive,
                CreatedOn = staff.CreatedOn == null ? DateTime.Now : staff.CreatedOn,
                // CreatedBy = staff.CreatedBy == null ? string.Empty : Convert.ToString(staff.CreatedBy),
                CreatedBy = Convert.ToString(staff.CreatedBy),
                ModifiedOn = staff.ModifiedOn == null ? DateTime.Now : staff.ModifiedOn,
                ModifiedBy = staff.ModifiedBy == null ? string.Empty : Convert.ToString(staff.ModifiedBy),
                BuildingId = staff.BuildingId == null ? string.Empty : Convert.ToString(staff.BuildingId),
                Password = staff.Password ?? "",

                // public List<AboutU> AboutUCreatedByNavigations { get; set; } = new List<AboutU>();

                // public List<AboutU> AboutUModifiedByNavigations { get; set; } = new List<AboutU>();

                // public List<Banner> BannerCreatedByNavigations { get; set; } = new List<Banner>();

                // public List<Banner> BannerModifiedByNavigations { get; set; } = new List<Banner>();

                // public List<Barcode> BarcodeCreatedByNavigations { get; set; } = new List<Barcode>();

                // public List<Barcode> BarcodeModifiedByNavigations { get; set; } = new List<Barcode>();

                // public List<Batch> BatchCreatedByNavigations { get; set; } = new List<Batch>();

                // public List<Batch> BatchModifiedByNavigations { get; set; } = new List<Batch>();

                // public BloodGroup? BloodGroup { get; set; }

                // public List<BloodGroup> BloodGroupCreatedByNavigations { get; set; } = new List<BloodGroup>();

                // public List<BloodGroup> BloodGroupModifiedByNavigations { get; set; } = new List<BloodGroup>();

                // // public List<Book> BookCreatedByNavigations { get; set; } = new List<Book>();

                // // public List<Book> BookModifiedByNavigations { get; set; } = new List<Book>();

                // public Building? Building { get; set; }

                // public List<Building> BuildingCreatedByNavigations { get; set; } = new List<Building>();

                // public List<Building> BuildingModifiedByNavigations { get; set; } = new List<Building>();

                // public List<City> CityCreatedByNavigations { get; set; } = new List<City>();

                // public List<City> CityModifiedByNavigations { get; set; } = new List<City>();

                // // public List<Class> ClassCreatedByNavigations { get; set; } = new List<Class>();

                // // public List<Class> ClassModifiedByNavigations { get; set; } = new List<Class>();

                // public List<ContactU> ContactUCreatedByNavigations { get; set; } = new List<ContactU>();

                // public List<ContactU> ContactUModifiedByNavigations { get; set; } = new List<ContactU>();

                // public List<Country> CountryCreatedByNavigations { get; set; } = new List<Country>();

                // public List<Country> CountryModifiedByNavigations { get; set; } = new List<Country>();

                // public Department? Department { get; set; }

                // public List<Department> DepartmentCreatedByNavigations { get; set; } = new List<Department>();

                // public List<Department> DepartmentModifiedByNavigations { get; set; } = new List<Department>();

                // public StaffType? Designation { get; set; }

                // public List<Domain> Domains { get; set; } = new List<Domain>();

                // public EmployementType? EmployementType { get; set; }

                // public List<EmployementType> EmployementTypeCreatedByNavigations { get; set; } = new List<EmployementType>();

                // public List<EmployementType> EmployementTypeModifiedByNavigations { get; set; } = new List<EmployementType>();

                // public List<Gender> GenderCreatedByNavigations { get; set; } = new List<Gender>();

                // public List<Gender> GenderModifiedByNavigations { get; set; } = new List<Gender>();

                // public List<Staff> InverseModifiedByNavigation { get; set; } = new List<Staff>();

                // public List<IssueBookStudent> IssueBookStudentCreatedByNavigations { get; set; } = new List<IssueBookStudent>();

                // public List<IssueBookStudent> IssueBookStudentModifiedByNavigations { get; set; } = new List<IssueBookStudent>();

                // public List<LoginType> LoginTypeCreatedByNavigations { get; set; } = new List<LoginType>();

                // public List<LoginType> LoginTypeModifiedByNavigations { get; set; } = new List<LoginType>();

                // public MaritalStatus? MaritalStatus { get; set; }

                // public List<MaritalStatus> MaritalStatusCreatedByNavigations { get; set; } = new List<MaritalStatus>();

                // public List<MaritalStatus> MaritalStatusModifiedByNavigations { get; set; } = new List<MaritalStatus>();

                // public Staff? ModifiedByNavigation { get; set; }

                // public Country? NationalityNavigation { get; set; }

                // public List<PaymentStatus> PaymentStatusCreatedByNavigations { get; set; } = new List<PaymentStatus>();

                // public List<PaymentStatus> PaymentStatusModifiedByNavigations { get; set; } = new List<PaymentStatus>();

                // public Country? PermanentCountry { get; set; }

                // public State? PermanentState { get; set; }

                // public City? PresentCity { get; set; }

                // public Country? PresentCountry { get; set; }

                // public State? PresentState { get; set; }

                // public LoginType? Role { get; set; }

                // public SocialCategory? SocialCategory { get; set; }

                // public List<SocialCategory> SocialCategoryCreatedByNavigations { get; set; } = new List<SocialCategory>();

                // public List<SocialCategory> SocialCategoryModifiedByNavigations { get; set; } = new List<SocialCategory>();
            };
        }
         public static BusinessObject.Country ToBusinessObject(this LMS.Infrastructures.Models.Country country)
        {
            return new BusinessObject.Country
            {
                CountryId = country.CountryId == null ? string.Empty : Convert.ToString(country.CountryId),
                CountryName = country.CountryName,
                IsActive = country.IsActive,
                CreatedOn = country.CreatedOn,
                CreatedBy = Convert.ToString(country.CreatedBy),
                ModifiedOn = country.ModifiedOn,
                ModifiedBy = Convert.ToString(country.ModifiedBy),
            };
        }
    }
}
