using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IStaffService
    {
        Task<List<Staff>> GetAllStaff();
        Task<Staff> GetStaffById(string id);
        Task<Staff> GetLoginUser(string emailId);
        Task<int> InsertStaff(Staff staff);
        Task<int> UpdateStaff(Staff staff);
    }
}
