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
        Task<List<StudentCategory>> GetSocialCateogories();
        Task<StudentCategory> GetStudentCateogoryById(string id);
        Task<int> InsertStudentCateogory(StudentCategory studentCateogory);
        Task<int> UpdateStudentCateogory(StudentCategory studentCateogory);
        Task<int> DeleteStudentCateogory(string id);
    }
}
