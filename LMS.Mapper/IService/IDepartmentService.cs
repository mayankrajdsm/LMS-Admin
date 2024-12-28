using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetDepartments();
        Task<Department> GetDepartmentById(string departmentId);
        Task<int> InsertDepartment(Department department);
        Task<int> UpdateDepartment(Department department);
    }
}
