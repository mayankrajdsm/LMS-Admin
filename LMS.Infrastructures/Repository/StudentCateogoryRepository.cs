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
    public class StudentCateogoryRepository: IStudentCateogoryRepository
    {
        private readonly FunskoolsContext _context;
        public StudentCateogoryRepository(FunskoolsContext context) => _context = context;
        public async Task<IEnumerable<StudentCategory>> GetStudentCateogories() => await _context.StudentCategories.ToListAsync();
        public async Task<StudentCategory> GetStudentCateogoryById(Guid studentCateogoryId) => await _context.StudentCategories.FindAsync(studentCateogoryId);
        public async Task<int> InsertStudentCateogory(StudentCategory studentCateogory)
        {
            _context.StudentCategories.Add(studentCateogory);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateStudentCateogory(StudentCategory studentCateogory) => await _context.SaveChangesAsync();
        public async Task<int> DeleteStudentCateogory(Guid studentCateogoryId)
        {
            var studentCateogory = await _context.StudentCategories.FindAsync(studentCateogoryId);
            _context.StudentCategories.Remove(studentCateogory);
            return await _context.SaveChangesAsync();
        }
    }
}
