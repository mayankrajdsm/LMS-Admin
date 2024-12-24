using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IIssueBookStudentService
    {
        Task<List<IssueBookStudent>> GetIssueBookStudents();
        Task<List<IssueBookStudent>> GetIssueBookStudentByBookIdStudentId(string bookId, string studentId);
        Task<IssueBookStudent> GetIssueBookStudentByBookIdStudentId(string issueId);
        Task<int> InsertIssueBookStudent(IssueBookStudent issueBookStudent);
        Task<int> UpdateIssueBookStudent(IssueBookStudent issueBookStudent);
        Task<int> DeleteIssueBookStudent(string issueId);
    }
}
