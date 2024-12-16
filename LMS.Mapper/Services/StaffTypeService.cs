using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Repository;
using LMS.Mapper.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Mapper.ConversionHelper;
using LMS.Mapper.BusinessObject;

namespace LMS.Mapper.Services
{
    public class StaffTypeService : IStaffTypeService
    {
        private readonly IStaffTypeRepository _staffTypeRepository;
        public StaffTypeService(IStaffTypeRepository staffTypeRepository)
        {
            _staffTypeRepository = staffTypeRepository;
        }
        public async Task<List<StaffType>> GetStaffTypes()
        {
            List<StaffType> staffTypes = new List<StaffType>();
            var existingStaffType = await _staffTypeRepository.GetStaffTypes();
            foreach (var staffType in existingStaffType)
            {
                staffTypes.Add(staffType.ToBusinessObject());
            }
            return staffTypes;
        }
        public async Task<int> InsertStaffType(string name, string createdBy)
        {
            StaffType staffType = new StaffType();
            staffType.StaffTypeName = name;
            staffType.IsActive = true;
            staffType.CreatedOn = DateTime.Now;
            staffType.CreatedBy = createdBy;
            return await _staffTypeRepository.InsertStaffType(staffType.ToEntityModel());
        }
    }
}
