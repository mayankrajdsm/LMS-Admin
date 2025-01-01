using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Repository
{
    public class SubjectRepository: ISubjectRepository
    {
        private readonly FunskoolsContext _context;
        public SubjectRepository(FunskoolsContext context) => _context = context;
        public async Task<IEnumerable<Subject>> GetSubjects() => await _context.Subjects.ToListAsync();
        public async Task<Subject> GetSubjectById(Guid id) => await _context.Subjects.FindAsync(id);
        public async Task<int> InsertSubject(Subject subject)
        {
            _context.Subjects.Add(subject);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateSubject(Subject subject) => await _context.SaveChangesAsync();
        public async Task<int> DeleteSubject(Guid id)
        {
            var subject = await _context.Subjects.FindAsync(id);
            _context.Subjects.Remove(subject);
            return await _context.SaveChangesAsync();
        }
    }
}
