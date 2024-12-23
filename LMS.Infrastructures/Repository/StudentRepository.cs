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
            return await _context.StudentContact.ToListAsync();
        }
        public async Task<IEnumerable<StudentEducation>> GetAllStudentEducationAsync()
        {
            return await _context.StudentEducation.ToListAsync();
        }
        public async Task<IEnumerable<StudentGuardian>> GetAllStudentGuardianAsync()
        {
            return await _context.StudentGuardian.ToListAsync();
        }
        public async Task<IEnumerable<StudentParent>> GetAllStudentParentAsync()
        {
            return await _context.StudentParents.ToListAsync();
        }
        public async Task<IEnumerable<StudentTransport>> GetAllStudentTransportAsync()
        {
            return await _context.StudentTransport.ToListAsync();
        }
        public async Task<int> InsertStudentContact(StudentContact studentContact)
        {
            _context.StudentContact.Add(studentContact);
            return _context.SaveChanges();
        }
        public async Task<int> InsertStudent(Student student)
        {
            _context.Students.Add(student);
            return _context.SaveChanges();
        }
        public async Task<int> InsertStudentEducation(StudentEducation studentEducation)
        {
            _context.StudentEducation.Add(studentEducation);
            return _context.SaveChanges();
        }
        public async Task<int> InsertStudentGuardian(StudentGuardian studentGuardian)
        {
            _context.StudentGuardian.Add(studentGuardian);
            return _context.SaveChanges();
        }
        public async Task<int> InsertStudentParents(StudentParent studentParent)
        {
            _context.StudentParents.Add(studentParent);
            return _context.SaveChanges();
        }
        public async Task<int> InsertStudentTransport(StudentTransport studentTransport)
        {
            _context.StudentTransport.Add(studentTransport);
            return _context.SaveChanges();
        }

    }
}
