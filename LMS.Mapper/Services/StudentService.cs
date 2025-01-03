﻿using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using LMS.Mapper.IService;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        public async Task<int> InsertStudent(Student student)
        {
            return await _studentRepository.InsertStudent(student);
        }
        public async Task<int> InsertStudentContact(StudentContact studentContact)
        {
            return await _studentRepository.InsertStudentContact(studentContact);
        }
        public async Task<int> InsertStudentParents(StudentParent studentParent)
        {
            return await _studentRepository.InsertStudentParents(studentParent);
        }
        public async Task<int> InsertStudentGuardian(StudentGuardian studentGuardian)
        {
            return await _studentRepository.InsertStudentGuardian(studentGuardian);
        }
        public async Task<int> InsertStudentTransport(StudentTransport studentTransport)
        {
            return await _studentRepository.InsertStudentTransport(studentTransport);
        }
        public async Task<int> InsertStudentEducation(StudentEducation studentEducation)
        {
            return await _studentRepository.InsertStudentEducation(studentEducation);
        }   
        public async Task<int> DeleteStudent(Guid studentID)
        {
            return await _studentRepository.DeleteStudent(studentID);
        }
        public async Task<int> DeleteStudentContact(Guid studentContactID)
        {
            return await _studentRepository.DeleteStudentContact(studentContactID);
        }
        public async Task<int> DeleteStudentEducation(Guid studentEducationID)
        {
            return await _studentRepository.DeleteStudentEducation(studentEducationID);
        }
        public async Task<int> DeleteStudentGuardian(Guid studentGuardianID)
        {
            return await _studentRepository.DeleteStudentGuardian(studentGuardianID);
        }
        public async Task<int> DeleteStudentParents(Guid studentParentID)
        {
            return await _studentRepository.DeleteStudentParents(studentParentID);
        }
        public async Task<int> DeleteStudentTransport(Guid studentTransportID)
        {
            return await _studentRepository.DeleteStudentTransport(studentTransportID);
        }

    }
}
