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
    public class ClassRepository: IClassRepository
    {
        private readonly LMSDbContext _context;
        public ClassRepository(LMSDbContext context) 
        {
            _context = context;
        }
        public async Task<IEnumerable<Class>> GetAllClass() 
        {
            return await _context.Classes.ToListAsync();
        }
    }
}
