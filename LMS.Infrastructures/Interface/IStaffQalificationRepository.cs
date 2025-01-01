using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IStaffQalificationRepository
    {
Task<IEnumerable<StaffQalification>> GetStaffQalifications();
        Task<StaffQalification> GetStaffQalificationById(Guid id);
        Task<int> InsertStaffQalification(StaffQalification staffQalification);
        Task<int> UpdateStaffQalification(StaffQalification staffQalification);
        Task<int> DeleteStaffQalification(Guid id);
    }
}
