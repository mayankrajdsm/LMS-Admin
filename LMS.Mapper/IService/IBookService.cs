﻿using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        int InsertBook(Book book);
    }
}