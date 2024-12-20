using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Repository
{
    public class LoginTypeRepository : ILoginTypeRepository
    {
        private readonly TestContext _context;
        public LoginTypeRepository(TestContext context) => _context = context;
        public async Task<IEnumerable<LoginType>> GetLoginTypes() => _context.LoginTypes.ToList();
        public async Task<LoginType> GetLoginTypeById(Guid roleId) => await _context.LoginTypes.FindAsync(roleId);
        public async Task<int> InsertLoginType(LoginType loginType)
        {
            _context.LoginTypes.Add(loginType);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateLoginType() => await _context.SaveChangesAsync();
    }
}
