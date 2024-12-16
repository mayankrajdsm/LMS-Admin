using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Repository
{
    public class LoginTypeRepository : ILoginTypeRepository
    {
        private readonly TestContext _lMSDbContext;
        public LoginTypeRepository(TestContext lMSDbContext)
        {
            _lMSDbContext = lMSDbContext;
        }
        public async Task<IEnumerable<LoginType>> GetLoginTypes()
        {
            return _lMSDbContext.LoginTypes.ToList();
        }
        public async Task<int> InsertLoginType(LoginType loginType)
        {
            _lMSDbContext.LoginTypes.Add(loginType);
            return await _lMSDbContext.SaveChangesAsync();
        }
    }
}
