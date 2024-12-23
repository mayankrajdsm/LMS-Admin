using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IClassRepository
    {
        Task<IEnumerable<Class>> GetAllClass();
        Task<int> InsertClass(Class classes);
    }
}
