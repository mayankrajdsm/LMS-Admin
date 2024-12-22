using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IStudentCateogoryService
    {
        Task<List<StudentCateogory>> GetSocialCateogories();
        Task<StudentCateogory> GetStudentCateogoryById(string id);
        Task<int> InsertStudentCateogory(StudentCateogory studentCateogory);
        Task<int> UpdateStudentCateogory(StudentCateogory studentCateogory);
        Task<int> DeleteStudentCateogory(string id);
    }
}
