using LMS.Infrastructures.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudent();
        Task<IEnumerable<StudentContact>> GetAllStudentContactsAsync();
        Task<IEnumerable<StudentEducation>> GetAllStudentEducationAsync();

        Task<IEnumerable<StudentGuardian>> GetAllStudentGuardianAsync();
        Task<IEnumerable<StudentParent>> GetAllStudentParentAsync();

        Task<IEnumerable<StudentTransport>> GetAllStudentTransportAsync();
        Task<int> InsertStudentContact(StudentContact studentContact);
        Task<int> InsertStudentEducation(StudentEducation studentEducation);
        Task<int> InsertStudentGuardian(StudentGuardian studentGuardian);
        Task<int> InsertStudentParents(StudentParent studentParent);
        Task<int> InsertStudentTransport(StudentTransport studentTransport);
        Task<int> InsertStudent(Student student);

    }
}
