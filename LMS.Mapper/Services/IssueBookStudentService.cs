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
    public class IssueBookStudentService : IIssueBookStudentService
    {
        private readonly IIssueBookStudentRepository _issueBookStudentRepository;

        public IssueBookStudentService(IIssueBookStudentRepository issueBookStudentRepository) => _issueBookStudentRepository = issueBookStudentRepository;

        public async Task<List<IssueBookStudent>> GetIssueBookStudents()
        {
            List<IssueBookStudent> lstIssueBookStudent = new List<IssueBookStudent>();
            var existingIssueBookStudent = await _issueBookStudentRepository.GetIssueBookStudents();
            if (existingIssueBookStudent != null)
            {
                foreach (var issueBookStudent in existingIssueBookStudent)
                {
                    lstIssueBookStudent.Add(issueBookStudent.ToBusinessObject());
                }
            }
            return lstIssueBookStudent;
        }
        public async Task<List<IssueBookStudent>> GetIssueBookStudentByBookIdStudentId(string bookId, string studentId)
        {
            List<IssueBookStudent> lstIssueBookStudent = new List<IssueBookStudent>();
            var existingIssueBookStudent = await _issueBookStudentRepository.GetIssueBookStudentByBookIdStudentId(Guid.Parse(bookId), Guid.Parse(studentId));
            foreach (var issueBookStudent in existingIssueBookStudent)
            {
                lstIssueBookStudent.Add(issueBookStudent.ToBusinessObject());
            }
            return lstIssueBookStudent;
        }
        public async Task<IssueBookStudent> GetIssueBookStudentByBookIdStudentId(string issueId)
        {
            var issueBookStudent = await _issueBookStudentRepository.GetIssueBookStudentById(Guid.Parse(issueId));
            return issueBookStudent.ToBusinessObject();
        }
        public async Task<int> InsertIssueBookStudent(IssueBookStudent issueBookStudent) => await _issueBookStudentRepository.InsertIssueBookStudent(issueBookStudent.ToEntityModel());
        public async Task<int> UpdateIssueBookStudent(IssueBookStudent issueBookStudent) => await _issueBookStudentRepository.UpdateIssueBookStudent(issueBookStudent.ToEntityModel());
        public async Task<int> DeleteIssueBookStudent(string issueId) => await _issueBookStudentRepository.DeleteIssueBookStudent(Guid.Parse(issueId));
    }
}
