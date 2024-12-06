using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;

namespace LMS.Infrastructures.Repository
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly LMSDbContext _context;

        public UserProfileRepository(LMSDbContext context)
        {
            _context = context;
        }
        public async Task<int> AddUser(UserProfile profile)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserProfile>> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
