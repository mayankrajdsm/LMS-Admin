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
        public async Task<int> InsertStudentContact(StudentContact studentContact)
        {
            _context.StudentContacts.Add(studentContact);
            return _context.SaveChanges();
        }
        public async Task<int> InsertStudent(Student student)
        {
            _context.Students.Add(student);
            return _context.SaveChanges();
        }
        public async Task<int> InsertStudentEducation(StudentEducation studentEducation)
        {
            _context.StudentEducations.Add(studentEducation);
            return _context.SaveChanges();
        }
        public async Task<int> InsertStudentGuardian(StudentGuardian studentGuardian)
        {
            _context.StudentGuardians.Add(studentGuardian);
            return _context.SaveChanges();
        }
        public async Task<int> InsertStudentParents(StudentParent studentParent)
        {
            _context.StudentParents.Add(studentParent);
            return _context.SaveChanges();
        }
        public async Task<int> InsertStudentTransport(StudentTransport studentTransport)
        {
            _context.StudentTransports.Add(studentTransport);
            return _context.SaveChanges();
        }
        public async Task<int> DeleteStudent(Guid studentid)
        {
           var result= _context.Students.FindAsync(studentid).Result;
           
            if (result != null)
            {
                _context.Students.RemoveRange(result);
                _context.Students.Remove(result);
                return _context.SaveChanges();
            }
           return _context.SaveChanges();
            
        }
        public async Task<int> DeleteStudentContact(Guid studentContactid)
        {
            var result = _context.StudentContacts.FindAsync(studentContactid).Result;
            if (result != null)
            {
                _context.StudentContacts.Remove(result);
                return _context.SaveChanges();
            }
            return _context.SaveChanges();

        }
        public async Task<int> DeleteStudentEducation(Guid studentEducationid)
        {
            var result = _context.Students.FindAsync(studentEducationid).Result;
            if (result != null)
            {
                _context.Students.Remove(result);
                return _context.SaveChanges();
            }
            return _context.SaveChanges();

        }
        public async Task<int> DeleteStudentGuardian(Guid studentGuardianid)
        {
            var result = _context.Students.FindAsync(studentGuardianid).Result;
            if (result != null)
            {
                _context.Students.Remove(result);
                return _context.SaveChanges();
            }
            return _context.SaveChanges();

        }
        public async Task<int> DeleteStudentParents(Guid studentParentid)
        {
            var result = _context.Students.FindAsync(studentParentid).Result;
            if (result != null)
            {
                _context.Students.Remove(result);
                return _context.SaveChanges();
            }
            return _context.SaveChanges();

        }
        public async Task<int> DeleteStudentTransport(Guid studentTransportid)
        {
            var result = _context.Students.FindAsync(studentTransportid).Result;
            if (result != null)
            {
                _context.Students.Remove(result);
                return _context.SaveChanges();
            }
            return _context.SaveChanges();

        }

    }
}
