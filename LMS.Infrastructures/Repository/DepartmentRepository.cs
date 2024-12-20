using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Repository
{
    public class DepartmentRepository: IDepartmentRepository
    {
        private readonly TestContext _context;
        public DepartmentRepository(TestContext context) => _context = context;
        public async Task<IEnumerable<Department>> GetDepartments() => await _context.Departments.ToListAsync();
        public async Task<Department> GetDepartmentById(Guid departmentId) => await _context.Departments.FindAsync(departmentId);
        public async Task<int> InsertDepartment(Department department)
        {
            _context.Departments.Add(department);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateDepartment(Department department) => await _context.SaveChangesAsync();
    }
}
