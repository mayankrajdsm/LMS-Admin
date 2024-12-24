using LMS.Infrastructures.Interface;
using LMS.Mapper.BusinessObject;
using LMS.Mapper.ConversionHelper;
using LMS.Mapper.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.Services
{
    public class MaritalStatusService : IMaritalStatusService
    {
        private readonly IMaritalStatusRepository _maritalStatusRepository;

        public MaritalStatusService(IMaritalStatusRepository maritalStatusRepository) => _maritalStatusRepository = maritalStatusRepository;

        public async Task<List<MaritalStatus>> GetMaritalStatusList()
        {
            List<MaritalStatus> lstMaritalStatus = new List<MaritalStatus>();
            var existingMaritalStatuses = await _maritalStatusRepository.GetMaritalStatus();
            if (existingMaritalStatuses != null)
            {
                foreach (var maritalStatus in existingMaritalStatuses)
                {
                    lstMaritalStatus.Add(maritalStatus.ToBusinessObject());
                }
            }
            return lstMaritalStatus;
        }
        public async Task<MaritalStatus> GetMaritalStatusById(string id)
        {
            var maritalStatus = await _maritalStatusRepository.GetMaritalStatusById(Guid.Parse(id));
            return maritalStatus.ToBusinessObject();
        }
        public async Task<int> InsertMaritalStatus(MaritalStatus maritalStatus) => await _maritalStatusRepository.InsertMaritalStatus(maritalStatus.ToEntityModel());
        public async Task<int> UpdateMaritalStatus(MaritalStatus maritalStatus) => await _maritalStatusRepository.UpdateMaritalStatus(maritalStatus.ToEntityModel());
        public async Task<int> DeleteMaritalStatus(string id) => await _maritalStatusRepository.DeleteMaritalStatus(Guid.Parse(id));
    }
}
