using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.Services
{
    public class StudentService: IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository) 
        {
            _studentRepository = studentRepository;
        }
        public async Task<IEnumerable<Student>> GetAllStudent() 
        {
            return await _studentRepository.GetAllStudent();
        }
        public async Task<IEnumerable<StudentContact>> GetAllStudentContact()
        {
            return await _studentRepository.GetAllStudentContactsAsync();
        }
        public async Task<IEnumerable<StudentEducation>> GetAllStudentEducation()
        {
            return await _studentRepository.GetAllStudentEducationAsync();
        }
        public async Task<IEnumerable<StudentParent>> GetAllStudentParent()
        {
            return await _studentRepository.GetAllStudentParentAsync();
        }
        public async Task<IEnumerable<StudentTransport>> GetAllStudentTransport()
        {
            return await _studentRepository.GetAllStudentTransportAsync();
        }
        public async Task<IEnumerable<StudentGuardian>> GetAllStudentGuardian()
        {
            return await _studentRepository.GetAllStudentGuardianAsync();
        }

    }
}
