using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IEmployementTypeRepository
    {
        Task<IEnumerable<EmployementType>> GetEmployementTypes();
        Task<EmployementType> GetEmployementTypeById(Guid employementTypeId);
        Task<int> InsertEmployementType(EmployementType employementType);
        Task<int> UpdateEmployementType(EmployementType employementType);
        Task<int> DeleteEmployementType(Guid employementTypeId);

    }
}
