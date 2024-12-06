using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Infrastructures.Models;

namespace LMS.Infrastructures.Interface
{
    public interface IUserProfileRepository
    {
        Task<IEnumerable<UserProfile>> GetAllUsers();
        Task<int> AddUser(UserProfile profile);
    }
}
