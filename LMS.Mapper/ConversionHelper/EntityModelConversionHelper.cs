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
            convertedModel.CountryId = Guid.Parse(domain.CountryId);
            convertedModel.StateId = Guid.Parse(domain.StateId);
            convertedModel.CityId = Guid.Parse(domain.CityId);
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
    }
}
