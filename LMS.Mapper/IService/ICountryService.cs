using LMS.Infrastructures.Interface;
using LMS.Mapper.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Mapper.IService
{
    public interface ICountryService
    {
        Task<List<Country>> GetCountries();
    }
}
