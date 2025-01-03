﻿using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface ILoginTypeService
    {
        Task<List<LoginType>> GetLoginTypes();
        Task<LoginType> GetLoginTypeById(string roleId);
        Task<int> InsertLoginType(LoginType loginType);
        Task<int> UpdateLoginType(LoginType loginType);
    }
}
