using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IStatusRepository
    {
        Task<IEnumerable<Status>> GetStatuses();
       Task<Status> GetStatusById(Guid id);
       Task<int> InsertStatus(Status status);
       Task<int> UpdateStatus(Status status);
        Task<int> DeleteStatus(Guid id);
    }
}
