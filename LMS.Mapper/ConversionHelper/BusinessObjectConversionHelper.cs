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
        //public static BusinessObject.Country ToBusinessObject(this LMS.Infrastructures.Models.Country country)
        //{
        //    return new BusinessObject.Country
        //    {
        //        CountryId = country.CountryId == null ? "" : Convert.ToString(country.CountryId),
        //        CountryName = country.CountryName,
        //        IsActive = country.IsActive,
        //        CreatedOn = country.CreatedOn,
        //        CreatedBy = Convert.ToString(country.CreatedBy),
        //        ModifiedOn = country.ModifiedOn,
        //        ModifiedBy = Convert.ToString(country.ModifiedBy),
        //        States = country.States.ToList()
        //    };
        //}
    }
}
