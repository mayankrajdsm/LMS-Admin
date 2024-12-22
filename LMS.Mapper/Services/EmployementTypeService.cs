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
    public class EmployementTypeService : IEmployementTypeService
    {
        private readonly IEmployementTypeRepository _employementTypeRepository;

        public EmployementTypeService(IEmployementTypeRepository employementTypeRepository) => _employementTypeRepository = employementTypeRepository;

        public async Task<List<EmployementType>> GetEmployementTypes()
        {
            List<EmployementType> employementTypes = new List<EmployementType>();
            var existingEmployementType = await _employementTypeRepository.GetEmployementTypes();
            if (existingEmployementType != null)
            {
                foreach (var employementType in existingEmployementType)
                {
                    employementTypes.Add(employementType.ToBusinessObject());
                }
            }
            return employementTypes;
        }
        public async Task<EmployementType> GetEmployementTypeById(string employementTypeId)
        {
            var employementType = await _employementTypeRepository.GetEmployementTypeById(Guid.Parse(employementTypeId));
            return employementType.ToBusinessObject();
        }
        public async Task<int> InsertEmployementType(EmployementType employementType) => await _employementTypeRepository.InsertEmployementType(employementType.ToEntityModel());
        public async Task<int> UpdateEmployementType(EmployementType employementType) => await _employementTypeRepository.UpdateEmployementType(employementType.ToEntityModel());
        public async Task<int> DeleteEmployementType(string employementTypeId) => await _employementTypeRepository.DeleteEmployementType(Guid.Parse(employementTypeId));
    }
}
