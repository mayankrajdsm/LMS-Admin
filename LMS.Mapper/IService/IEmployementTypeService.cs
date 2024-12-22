using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IEmployementTypeService
    {
        Task<List<EmployementType>> GetEmployementTypes();
        Task<EmployementType> GetEmployementTypeById(string employementTypeId);
        Task<int> InsertEmployementType(EmployementType employementType);
        Task<int> UpdateEmployementType(EmployementType employementType);
        Task<int> DeleteEmployementType(string employementTypeId);
    }
}
