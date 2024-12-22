using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Repository;
using LMS.Mapper.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Mapper.ConversionHelper;
using LMS.Mapper.BusinessObject;

namespace LMS.Mapper.Services
{
    public class StudentSubTypeService : IStudentSubTypeService
    {
        private readonly IStudentSubTypeRepository _studentSubTypeRepository;

        public StudentSubTypeService(IStudentSubTypeRepository studentSubTypeRepository) => _studentSubTypeRepository = studentSubTypeRepository;

        public async Task<List<StudentSubType>> GetStudentSubTypes()
        {
            List<StudentSubType> studentSubTypes = new List<StudentSubType>();
            var existingStudentSubTypes = await _studentSubTypeRepository.GetStudentSubTypes();
            if (existingStudentSubTypes != null)
            {
                foreach (var studentSubType in existingStudentSubTypes)
                {
                    studentSubTypes.Add(studentSubType.ToBusinessObject());
                }
            }
            return studentSubTypes;
        }
        public async Task<StudentSubType> GetStudentSubTypeById(string id)
        {
            var studentSubType = await _studentSubTypeRepository.GetStudentSubTypeById(Guid.Parse(id));
            return studentSubType.ToBusinessObject();
        }
        public async Task<int> InsertStudentSubType(StudentSubType studentSubType) => await _studentSubTypeRepository.InsertStudentSubType(studentSubType.ToEntityModel());
        public async Task<int> UpdateStudentSubType(StudentSubType studentSubType) => await _studentSubTypeRepository.UpdateStudentSubType(studentSubType.ToEntityModel());
        public async Task<int> DeleteStudentSubType(string id) => await _studentSubTypeRepository.DeleteStudentSubType(Guid.Parse(id));
    }
}
