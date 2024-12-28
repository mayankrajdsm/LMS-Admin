using LMS.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.Interface
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetCountries();
        Task<Country> GetCountryById(Guid countryId);
        Task<int> InsertCountry(Country country);
        Task<int> UpdateCountry(Country country);
        Task<int> DeleteCountry(Guid countryId);
    }
}
