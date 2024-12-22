using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IStudentSubTypeService
    {
        Task<List<StudentSubType>> GetStudentSubTypes();
        Task<StudentSubType> GetStudentSubTypeById(string id);
        Task<int> InsertStudentSubType(StudentSubType studentSubType);
        Task<int> UpdateStudentSubType(StudentSubType studentSubType);
        Task<int> DeleteStudentSubType(string id);
    }
}
