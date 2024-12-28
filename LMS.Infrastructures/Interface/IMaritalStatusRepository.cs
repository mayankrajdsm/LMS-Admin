using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IMaritalStatusRepository
    {
        Task<IEnumerable<MaritalStatus>> GetMaritalStatus();
        Task<MaritalStatus> GetMaritalStatusById(Guid maritalStatusId);
        Task<int> InsertMaritalStatus(MaritalStatus maritalStatus);
        Task<int> UpdateMaritalStatus(MaritalStatus maritalStatus);
        Task<int> DeleteMaritalStatus(Guid maritalStatusId);
    }
}
