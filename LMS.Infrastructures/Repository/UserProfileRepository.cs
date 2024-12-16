using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastructures.Repository
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly TestContext _context;

        public UserProfileRepository(TestContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<UserProfile>> GetAllUsers()
        {
            return null;
        }
        public async Task<int> InsertUser(UserProfile profile)
        {
            return await _context.SaveChangesAsync();
        }
    }
}
