using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Repository
{
    public class BookRepository: IBookRepository
    {
        private readonly LMSDbContext _context;
        public BookRepository(LMSDbContext context)
        {
            _context = context;

        }
        public IEnumerable<Book> GetAllBooks() 
        {
            return _context.Books.ToList();
        }
    }
}
