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
        Task<IEnumerable<StudentCateogory>> GetStudentCateogories();
        Task<StudentCateogory> GetStudentCateogoryById(Guid studentCateogoryId);
        Task<int> InsertStudentCateogory(StudentCateogory studentCateogory);
        Task<int> UpdateStudentCateogory(StudentCateogory studentCateogory);
        Task<int> DeleteStudentCateogory(Guid studentCateogoryId);
    }
}
