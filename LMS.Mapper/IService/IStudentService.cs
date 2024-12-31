using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudent();
        Task<IEnumerable<StudentContact>> GetAllStudentContact();
        Task<IEnumerable<StudentEducation>> GetAllStudentEducation();
        Task<IEnumerable<StudentParent>> GetAllStudentParent();
        Task<IEnumerable<StudentTransport>> GetAllStudentTransport();
        Task<IEnumerable<StudentGuardian>> GetAllStudentGuardian();
        Task<int> InsertStudentContact(StudentContact studentContact);
        Task<int> InsertStudentParents(StudentParent studentParent);
        Task<int> InsertStudentGuardian(StudentGuardian studentGuardian);
        Task<int> InsertStudentTransport(StudentTransport studentTransport);
        Task<int> InsertStudentEducation(StudentEducation studentEducation);
        Task<int> InsertStudent(Student student);
        Task<int> DeleteStudent(Guid studentID);
        Task<int> DeleteStudentContact(Guid studentContactID);
        Task<int> DeleteStudentEducation(Guid studentEducationID);
        Task<int> DeleteStudentGuardian(Guid studentGuardianID);
        Task<int> DeleteStudentParents(Guid studentParentID);
        Task<int> DeleteStudentTransport(Guid studentTransportID);
    }
}
