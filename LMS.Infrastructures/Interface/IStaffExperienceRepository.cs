    using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IStaffExperienceRepository
    {
Task<IEnumerable<StaffExperience>> GetStaffExperiences();
        Task<StaffExperience> GetStaffExperienceById(Guid id);
        Task<int> InsertStaffExperience(StaffExperience staffExperience);
        Task<int> UpdateStaffExperience(StaffExperience staffExperience);
        Task<int> DeleteStaffExperience(Guid id);
    }
}
