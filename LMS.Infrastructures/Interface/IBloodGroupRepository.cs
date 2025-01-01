using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface IBloodGroupRepository
    {
Task<IEnumerable<BloodGroup>> GetBloodGroups();
        Task<BloodGroup> GetBloodGroupById(Guid id);
        Task<int> InsertBloodGroup(BloodGroup bloodGroup);
        Task<int> UpdateBloodGroup(BloodGroup bloodGroup);
        Task<int> DeleteBloodGroup(Guid bloodGroupId);
    }
}
