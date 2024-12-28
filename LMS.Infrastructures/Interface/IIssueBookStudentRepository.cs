using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IIssueBookStudentRepository
    {
        Task<IEnumerable<IssueBookStudent>> GetIssueBookStudents();
        Task<IssueBookStudent> GetIssueBookStudentById(Guid issueBookStudentId);
        Task<IEnumerable<IssueBookStudent>> GetIssueBookStudentByBookIdStudentId(Guid bookId, Guid studentId);
        Task<int> InsertIssueBookStudent(IssueBookStudent issueBookStudent);
        Task<int> UpdateIssueBookStudent(IssueBookStudent issueBookStudent);
        Task<int> DeleteIssueBookStudent(Guid issueBookStudentId);
    }
}
