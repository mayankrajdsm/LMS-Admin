using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IStudentSubTypeRepository
    {
        Task<IEnumerable<StudentSubType>> GetStudentSubTypes();
        Task<StudentSubType> GetStudentSubTypeById(Guid studentSubTypeId);
        Task<int> InsertStudentSubType(StudentSubType studentSubType);
        Task<int> UpdateStudentSubType(StudentSubType studentSubType);
        Task<int> DeleteStudentSubType(Guid studentSubTypeId);
    }
}
