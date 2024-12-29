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
    public class StudentCateogoryService : IStudentCateogoryService
    {
        private readonly IStudentCateogoryRepository _studentCateogoryRepository;

        public StudentCateogoryService(IStudentCateogoryRepository studentCateogoryRepository) => _studentCateogoryRepository = studentCateogoryRepository;

        public async Task<List<StudentCategory>> GetSocialCateogories()
        {
            List<StudentCategory> studentCateogories = new List<StudentCategory>();
            var existingStudentCateogories = await _studentCateogoryRepository.GetStudentCateogories();
            if (existingStudentCateogories != null)
            {
                foreach (var studentCateogory in existingStudentCateogories)
                {
                    studentCateogories.Add(studentCateogory.ToBusinessObject());
                }
            }
            return studentCateogories;
        }
        public async Task<StudentCategory> GetStudentCateogoryById(string id)
        {
            var studentCateogory = await _studentCateogoryRepository.GetStudentCateogoryById(Guid.Parse(id));
            return studentCateogory.ToBusinessObject();
        }
        public async Task<int> InsertStudentCateogory(StudentCategory studentCateogory) => await _studentCateogoryRepository.InsertStudentCateogory(studentCateogory.ToEntityModel());
        public async Task<int> UpdateStudentCateogory(StudentCategory studentCateogory) => await _studentCateogoryRepository.UpdateStudentCateogory(studentCateogory.ToEntityModel());
        public async Task<int> DeleteStudentCateogory(string id) => await _studentCateogoryRepository.DeleteStudentCateogory(Guid.Parse(id));
    }
}
