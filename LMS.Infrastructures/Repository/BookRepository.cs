﻿using LMS.Infrastructures.Interface;
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
    public class BookRepository: IBookRepository
    {
        private readonly LMSDbContext _context;
        public BookRepository(LMSDbContext context)
        {
            _context = context;

        }
        public async Task<IEnumerable<Book>> GetAllBooks() 
        {
            return await _context.Books.ToListAsync();
        }
        public async Task<int> InsertBook(Book book)
        {
             _context.Books.Add(book);
            return await _context.SaveChangesAsync();

        }
    }
}