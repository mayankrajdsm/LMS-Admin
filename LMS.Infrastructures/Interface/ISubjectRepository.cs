using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface ISubjectRepository
    {
        Task<IEnumerable<Subject>> GetSubjects();
       Task<Subject> GetSubjectById(Guid id);
        Task<int> InsertSubject(Subject subject);
       Task<int> UpdateSubject(Subject subject);
        Task<int> DeleteSubject(Guid id);
    }
}
