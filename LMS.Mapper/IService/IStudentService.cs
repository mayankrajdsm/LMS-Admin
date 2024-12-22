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
    }
}
