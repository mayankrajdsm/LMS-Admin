using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IStudentCateogoryRepository
    {
        Task<IEnumerable<StudentCategory>> GetStudentCateogories();
        Task<StudentCategory> GetStudentCateogoryById(Guid studentCateogoryId);
        Task<int> InsertStudentCateogory(StudentCategory studentCateogory);
        Task<int> UpdateStudentCateogory(StudentCategory studentCateogory);
        Task<int> DeleteStudentCateogory(Guid studentCateogoryId);
    }
}
