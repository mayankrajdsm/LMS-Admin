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
                StaffTypeId = staffType.StaffTypeId == null ? "" : Convert.ToString(staffType.StaffTypeId),
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
                LoginTypeId = loginType.LoginTypeId == null ? "" : Convert.ToString(loginType.LoginTypeId),
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
                DomainId = domain.DomainId == null ? "" : Convert.ToString(domain.DomainId),
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
                DomainId = building.DomainId == null ? "" : Convert.ToString(building.DomainId),
                BuildingId = building.BuildingId == null ? "" : Convert.ToString(building.BuildingId),
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
                DepartmentId = department.DepartmentId == null ? "" : Convert.ToString(department.DepartmentId),
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
                AboutUsId = about.AboutUsId == null ? "" : Convert.ToString(about.AboutUsId),
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
                ContactUsId = contact.ContactUsId == null ? "" : Convert.ToString(contact.ContactUsId),
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
                BannerId = banner.BannerId == null ? "" : Convert.ToString(banner.BannerId),
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
                BarcodeId = barcode.BarcodeId == null ? "" : Convert.ToString(barcode.BarcodeId),
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
                BatchId = batch.BatchId == null ? "" : Convert.ToString(batch.BatchId),
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
                EmployementTypeId = employementType.EmployementTypeId == null ? "" : Convert.ToString(employementType.EmployementTypeId),
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
                GenderId = gender.GenderId == null ? "" : Convert.ToString(gender.GenderId),
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
                IssueBookStudentId = issueBookStudent.IssueBookStudentId == null ? "" : Convert.ToString(issueBookStudent.IssueBookStudentId),
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
                MaritalStatusId = maritalStatus.MaritalStatusId == null ? "" : Convert.ToString(maritalStatus.MaritalStatusId),
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
                PaymentStatusId = paymentStatus.PaymentStatusId == null ? "" : Convert.ToString(paymentStatus.PaymentStatusId),
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
                SocialCategoryId = socialCateogory.SocialCategoryId == null ? "" : Convert.ToString(socialCateogory.SocialCategoryId),
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
                StudentCategoryId = studentCateogory.StudentCategoryId == null ? "" : Convert.ToString(studentCateogory.StudentCategoryId),
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
                StudentSeatBookingId = studentSeatBooking.StudentSeatBookingId == null ? "" : Convert.ToString(studentSeatBooking.StudentSeatBookingId),
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
                StudentSubTypeId = studentSubType.StudentSubTypeId == null ? "" : Convert.ToString(studentSubType.StudentSubTypeId),
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
                SubscriptionPackageId = subscriptionPackage.SubscriptionPackageId == null ? "" : Convert.ToString(subscriptionPackage.SubscriptionPackageId),
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
                PaymentId = subscriptionPayment.SubscriptionPakageId == null ? "" : Convert.ToString(subscriptionPayment.SubscriptionPakageId),
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
                SubscriptionsTransactionStudentId = subscriptionsTransaction.SubscriptionsTransactionStudentId == null ? "" : Convert.ToString(subscriptionsTransaction.SubscriptionsTransactionStudentId),
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
    }
}
