using LMS.Infrastructures.Extensions;
using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Repository
{
    public class ClassRepository: IClassRepository
    {
        private readonly FunskoolsContext _context;
        public ClassRepository(FunskoolsContext context) 
        {
            _context = context;
        }
        public async Task<IEnumerable<Class>> GetAllClass() 
        {

            return await _context.Classes.ToListAsync();
        }
        public async Task<int> InsertClass(Class classes)
        {
            _context.Classes.Add(classes);
            return await _context.SaveChangesAsync();   
        }

    }
}
