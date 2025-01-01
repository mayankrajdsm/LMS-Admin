using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IStaffRepository
    {
Task<IEnumerable<Staff>> GetAllStaff();
        Task<Staff> GetStaffById(Guid id);
        Task<Staff> GetLoginUser(string email);
        Task<int> InsertStaff(Staff staff);
       Task<int> UpdateStaff(Staff staff);
        Task<int> DeleteStaff(Guid id);
    }
}
