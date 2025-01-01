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
    public class StudentSubTypeRepository: IStudentSubTypeRepository
    {
        private readonly FunskoolsContext _context;
        public StudentSubTypeRepository(FunskoolsContext context) => _context = context;
        public async Task<IEnumerable<StudentSubType>> GetStudentSubTypes() => await _context.StudentSubTypes.ToListAsync();
        public async Task<StudentSubType> GetStudentSubTypeById(Guid studentSubTypeId) => await _context.StudentSubTypes.FindAsync(studentSubTypeId);
        public async Task<int> InsertStudentSubType(StudentSubType studentSubType)
        {
            _context.StudentSubTypes.Add(studentSubType);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateStudentSubType(StudentSubType studentSubType) => await _context.SaveChangesAsync();
        public async Task<int> DeleteStudentSubType(Guid studentSubTypeId)
        {
            var studentSubType = await _context.StudentSubTypes.FindAsync(studentSubTypeId);
            _context.StudentSubTypes.Remove(studentSubType);
            return await _context.SaveChangesAsync();
        }
    }
}
