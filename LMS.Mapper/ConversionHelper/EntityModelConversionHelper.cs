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
            convertedModel.DomainId = string.IsNullOrEmpty(domain.DomainId) ? Guid.NewGuid() : new Guid(domain.DomainId);
            convertedModel.RegisteredName = domain.RegisteredName;
            convertedModel.Address1 = domain.Address1;
            convertedModel.Address2 = domain.Address2;
            convertedModel.CountryId = new Guid(domain.CountryId);
            convertedModel.StateId = new Guid(domain.StateId);
            convertedModel.CityId = new Guid(domain.CityId);
            convertedModel.ContactPerson = domain.ContactPerson;
            convertedModel.ContactNo = domain.ContactNo;
            convertedModel.ContactEmail = domain.ContactEmail;
            convertedModel.IsActive = domain.IsActive;
            convertedModel.CreatedOn = DateTime.Now;
            convertedModel.CreatedBy = new(domain.CreatedBy);
            convertedModel.ModifiedOn = string.IsNullOrEmpty(domain.DomainId) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(domain.DomainId) ? null : new Guid(domain.CreatedBy);
            return convertedModel;
        }
        public static StaffType ToEntityModel(this BusinessObject.StaffType staffType, StaffType existingStaffType = null)
        {
            StaffType convertedModel = existingStaffType != null ? existingStaffType : new StaffType();
            convertedModel.StaffTypeId = string.IsNullOrEmpty(staffType.StaffTypeId) ? Guid.NewGuid() : new Guid(staffType.StaffTypeId);
            convertedModel.StaffTypeName = staffType.StaffTypeName;
            convertedModel.IsActive = staffType.IsActive;
            convertedModel.CreatedOn = staffType.CreatedOn;
            convertedModel.CreatedBy = new Guid(staffType.CreatedBy);
            convertedModel.ModifiedOn = staffType.ModifiedOn.Equals(null) ? null : DateTime.Now;
            convertedModel.ModifiedBy = string.IsNullOrEmpty(staffType.ModifiedBy) ? null : new Guid(staffType.CreatedBy);
            return convertedModel;
        }
    }
}
