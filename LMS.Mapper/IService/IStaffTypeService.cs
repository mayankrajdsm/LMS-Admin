using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IStaffTypeService
    {
        Task<List<StaffType>> GetStaffTypes();
        Task<int> InsertStaffType(string name, string createdBy);
    }
}
