using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Repository
{
    public class IssueBookStudentRepository : IIssueBookStudentRepository
    {
        private readonly FunskoolsContext _context;
        public IssueBookStudentRepository(FunskoolsContext context) => _context = context;
        public async Task<IEnumerable<IssueBookStudent>> GetIssueBookStudents() => await _context.IssueBookStudents.ToListAsync();
        public async Task<IssueBookStudent> GetIssueBookStudentById(Guid issueBookStudentId)
        {
            return await _context.IssueBookStudents.FindAsync(issueBookStudentId);
        }
        public async Task<IEnumerable<IssueBookStudent>> GetIssueBookStudentByBookIdStudentId(Guid bookId, Guid studentId) => _context.IssueBookStudents.Where(b => b.BookId == bookId && b.StudentId == studentId);
        public async Task<int> InsertIssueBookStudent(IssueBookStudent issueBookStudent)
        {
            _context.IssueBookStudents.Add(issueBookStudent);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateIssueBookStudent(IssueBookStudent issueBookStudent)
        {
            return await _context.SaveChangesAsync();
        }
        public async Task<int> DeleteIssueBookStudent(Guid issueBookStudentId)
        {
            var issueBookStudent = await _context.IssueBookStudents.FindAsync(issueBookStudentId);
            _context.IssueBookStudents.Remove(issueBookStudent);
            return await _context.SaveChangesAsync();
        }
    }
}
