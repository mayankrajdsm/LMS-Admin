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
    public class StudentRepository: IStudentRepository
    {
        private readonly TestContext _context;
        public StudentRepository(TestContext context) 
        {
            _context = context;
        }
        public async Task<IEnumerable<Student>> GetAllStudent()
        {
           return await _context.Students.ToListAsync();
        }
        public async Task<IEnumerable<StudentContact>> GetAllStudentContactsAsync()
        {
            return await _context.StudentContacts.ToListAsync();
        }
        public async Task<IEnumerable<StudentEducation>> GetAllStudentEducationAsync()
        {
            return await _context.StudentEducations.ToListAsync();
        }
        public async Task<IEnumerable<StudentGuardian>> GetAllStudentGuardianAsync()
        {
            return await _context.StudentGuardians.ToListAsync();
        }
        public async Task<IEnumerable<StudentParent>> GetAllStudentParentAsync()
        {
            return await _context.StudentParents.ToListAsync();
        }
        public async Task<IEnumerable<StudentTransport>> GetAllStudentTransportAsync()
        {
            return await _context.StudentTransports.ToListAsync();
        }
    }
}
