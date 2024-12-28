using LMS.Infrastructures.Interface;
using LMS.Infrastructures.Repository;
using LMS.Mapper.BusinessObject;
using LMS.Mapper.ConversionHelper;
using LMS.Mapper.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.Services
{
    public class LoginTypeService : ILoginTypeService
    {
        private readonly ILoginTypeRepository _loginTypeRepository;
        public LoginTypeService(ILoginTypeRepository loginTypeRepository) => _loginTypeRepository = loginTypeRepository;
        public async Task<List<LoginType>> GetLoginTypes()
        {
            List<LoginType> loginTypes = new List<LoginType>();
            var existingLoginTypes = await _loginTypeRepository.GetLoginTypes();
            foreach (var loginType in existingLoginTypes)
            {
                loginTypes.Add(loginType.ToBusinessObject());
            }
            return loginTypes;
        }
        public async Task<LoginType> GetLoginTypeById(string roleId)
        {
            var loginType = await _loginTypeRepository.GetLoginTypeById(new Guid(roleId));
            return loginType.ToBusinessObject();
        }
        public async Task<int> InsertLoginType(LoginType loginType) => await _loginTypeRepository.InsertLoginType(loginType.ToEntityModel());
        public async Task<int> UpdateLoginType(LoginType loginType) => await _loginTypeRepository.UpdateLoginType();
    }
}
