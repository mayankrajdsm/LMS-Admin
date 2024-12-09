using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.ConversionHelper
{
    public static class BusinessObjectConversionHelper
    {
        public static BusinessObject.StaffType ToBusinessObject(this StaffType staffType)
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
        public static BusinessObject.LoginType ToBusinessObject(this LoginType loginType)
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
    }
}
