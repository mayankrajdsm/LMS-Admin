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
        private readonly TestContext _context;
        public StudentCateogoryRepository(TestContext context) => _context = context;
        public async Task<IEnumerable<StudentCateogory>> GetStudentCateogories() => await _context.StudentCateogories.ToListAsync();
        public async Task<StudentCateogory> GetStudentCateogoryById(Guid studentCateogoryId) => await _context.StudentCateogories.FindAsync(studentCateogoryId);
        public async Task<int> InsertStudentCateogory(StudentCateogory studentCateogory)
        {
            _context.StudentCateogories.Add(studentCateogory);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateStudentCateogory(StudentCateogory studentCateogory) => await _context.SaveChangesAsync();
        public async Task<int> DeleteStudentCateogory(Guid studentCateogoryId)
        {
            var studentCateogory = await _context.StudentCateogories.FindAsync(studentCateogoryId);
            _context.StudentCateogories.Remove(studentCateogory);
            return await _context.SaveChangesAsync();
        }
    }
}
