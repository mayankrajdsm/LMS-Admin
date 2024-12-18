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
    public class DepartmentService: IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<List<Department>> GetDepartments()
        {
            List<Department> departments = new List<Department>();
            var existingDepartments = await _departmentRepository.GetDepartments();
            foreach (var department in existingDepartments)
            {
                departments.Add(department.ToBusinessObject());
            }
            return departments;
        }
        public async Task<Department> GetDepartmentById(string departmentId)
        {
            var department = await _departmentRepository.GetDepartmentById(Guid.Parse(departmentId));
            return department.ToBusinessObject();
        }
        public async Task<int> InsertDepartment(Department department)
        {
            return await _departmentRepository.InsertDepartment(department.ToEntityModel());
        }
        public async Task<int> UpdateDepartment(Department department)
        {
            return await _departmentRepository.UpdateDepartment(department.ToEntityModel());
        }
    }
}
