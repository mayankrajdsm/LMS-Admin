using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IStaffTypeRepository
    {
        Task<IEnumerable<StaffType>> GetStaffTypes();
        Task<StaffType> GetStaffTypeById(Guid staffType);
        Task<int> InsertStaffType(StaffType staffType);
        Task<int> UpdateStaffType(StaffType staffType);
    }
}
