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
        public StaffTypeService(IStaffTypeRepository staffTypeRepository) => _staffTypeRepository = staffTypeRepository;
        public async Task<List<StaffType>> GetStaffTypes()
        {
            List<StaffType> staffTypes = new List<StaffType>();
            var existingStaffType = await _staffTypeRepository.GetStaffTypes();
            if (existingStaffType != null)
            {
                foreach (var staffType in existingStaffType)
                {
                    staffTypes.Add(staffType.ToBusinessObject());
                }
            }
            return staffTypes;
        }
        public async Task<StaffType> GetStaffTypeById(string staffTypeId)
        {
            var staffType = await _staffTypeRepository.GetStaffTypeById(Guid.Parse(staffTypeId));
            return staffType.ToBusinessObject();
        }
        public async Task<int> InsertStaffType(StaffType staffType) => await _staffTypeRepository.InsertStaffType(staffType.ToEntityModel());
        public async Task<int> UpdateStaffType(StaffType staffType) => await _staffTypeRepository.UpdateStaffType(staffType.ToEntityModel());
    }
}
