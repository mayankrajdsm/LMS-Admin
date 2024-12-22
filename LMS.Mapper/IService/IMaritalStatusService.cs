using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IMaritalStatusService
    {
        Task<List<MaritalStatus>> GetMaritalStatusList();
        Task<MaritalStatus> GetMaritalStatusById(string id);
        Task<int> InsertMaritalStatus(MaritalStatus maritalStatus);
        Task<int> UpdateMaritalStatus(MaritalStatus maritalStatus);
        Task<int> DeleteMaritalStatus(string id);
    }
}
