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
    public class LoginTypeService: ILoginTypeService
    {
        private readonly ILoginTypeRepository _loginTypeRepository;
        public LoginTypeService(ILoginTypeRepository loginTypeRepository)
        {
            _loginTypeRepository = loginTypeRepository;
        }
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
        public async Task<int> InsertLoginType(string name, string key, string createdBy)
        {
            LoginType loginType = new LoginType();
            loginType.LoginTypeName = name;
            loginType.LoginTypeKey = key;
            loginType.IsActive = true;
            loginType.CreatedOn = DateTime.Now;
            loginType.CreatedBy = createdBy;
            return await _loginTypeRepository.InsertLoginType(loginType.ToEntityModel());
        }
    }
}
